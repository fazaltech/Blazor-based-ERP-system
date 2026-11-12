# Enterprise ERP

This .NET 10 Blazor Interactive Server solution connects to an existing PostgreSQL ERP database. It remains a non-production foundation: tenant isolation, tenant-scoped authorization and ERP workflows are not implemented. The dashboard and platform tenant page do not expose ERP business records.

## Local user management

Registration at `/account/register` creates an inactive account with no roles. A SuperAdmin approves it at `/users`. The directory shows up to 200 users, roles and direct permissions. Administrators can activate, disable, unlock, reset passwords, assign/remove supported roles, and assign/remove `platform.users.view` for read-only directory access. These operations invalidate existing authentication cookies. The protected bootstrap administrator cannot be modified from this page.

No email is sent. `/account/forgot-password` directs users to an administrator, who must verify identity before setting a replacement password. It does not issue public reset tokens. New user-module pages and HTTP endpoints call `UserService` in Application, which calls `IUserRepository`; Infrastructure implements that repository using Identity managers and EF models. Existing login/logout endpoints still use Identity managers directly. No schema migration is needed for these additions.

This is not a complete lifecycle module yet: self-service profile/password changes, auditable recovery requests, searchable pagination, and custom role/permission catalogs remain outstanding. Tenant role labels assigned here are platform Identity roles and do not authorize tenant business data.

## Run locally

Install the .NET 10 SDK and start PostgreSQL. The Web project reads `ConnectionStrings:DefaultConnection` from .NET user secrets or environment variables; do not commit passwords.

```powershell
dotnet restore
dotnet tool restore
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Host=localhost;Port=5432;Database=enterprise_erp;Username=<user>;Password=<password>" --project src/EnterpriseERP.Web
dotnet run --project src/EnterpriseERP.Web
```

Open the address printed by the application and sign in at `/account/login`. Use HTTPS outside local development. Login and logout are HTTP POSTs protected by antiforgery tokens. The application does not automatically migrate the database or seed administrators at startup.

## Identity and bootstrap

Identity uses bigint keys and the existing `erp_core."Users"` table. The Identity migration adds security fields to that table; pre-existing users have `IdentityEnabled = false` and cannot sign in until a deliberate legacy-account migration is designed. Tenant roles remain in the existing `Roles` and `UserRoles` tables. `PlatformRoles` and `PlatformUserRoles` represent platform-wide Identity roles, because existing ERP roles require a tenant. Supporting claims, logins and token tables are separate Identity objects. These platform roles do **not** grant tenant data access or implement tenant authorization.

`AddPlatformIdentity` was applied to `enterprise_erp` on 10 November 2026, using its own `erp_core."__IdentityMigrationsHistory"`. It does not apply the separate ERP baseline. [identity-migration.sql](identity-migration.sql) is the reviewed generated script. The ERP model excludes the added Identity columns, and the Identity model excludes the existing users table from generated migrations. Any future change to that shared table needs a carefully reviewed, explicit migration and coordination between contexts.

Initial administrator bootstrap is an explicit operation. Set these values using user secrets or a secure environment, including a strong password, then execute the command:

```powershell
dotnet user-secrets set "IdentitySeed:SuperAdminEmail" "<email>" --project src/EnterpriseERP.Web
dotnet user-secrets set "IdentitySeed:SuperAdminFullName" "<full name>" --project src/EnterpriseERP.Web
dotnet user-secrets set "IdentitySeed:SuperAdminPassword" "<strong password>" --project src/EnterpriseERP.Web
dotnet run --project src/EnterpriseERP.Web -- --bootstrap-superadmin
dotnet user-secrets remove "IdentitySeed:SuperAdminPassword" --project src/EnterpriseERP.Web
```

Bootstrap never resets an existing password. It refuses to promote an existing unmarked user or create a second bootstrap administrator. Re-running it for the same marked administrator can restore its platform role; the password configuration is still required, but is not used to change the existing password. The database also restricts the bootstrap marker to one user. The bootstrap password used for the initial administrator was removed from user secrets after creation.

## ERP schema and baseline

`existing-schema.sql` is a schema-only inventory taken before the Identity migration. The 202-table scaffold is generated infrastructure persistence code, not a validated domain model. EF reverse engineering does not necessarily capture every database constraint and object. `ExistingDatabaseBaseline` is a no-op migration with an EF snapshot; `baseline-review.sql` creates only EF's ERP migration-history table and records that baseline. **This ERP baseline remains unapplied.** Before applying it, compare the model to the current schema, including the new Identity columns, constraints, indexes, defaults, sequences and provider limitations. Validate it on a restored copy and take a tested backup. Do not run an original generated initial migration against the existing tables.

Generate and review future scripts, and test them on a separate database before applying:

```powershell
dotnet ef migrations add <Name> --project src/EnterpriseERP.Infrastructure --startup-project src/EnterpriseERP.Web --context ERPDbContext --output-dir Persistence/Migrations
dotnet ef migrations script --idempotent --project src/EnterpriseERP.Infrastructure --startup-project src/EnterpriseERP.Web --context ERPDbContext --output migration-review.sql
```

Identity migrations use `--context ApplicationIdentityDbContext` and `Identity/Migrations`; inspect all SQL before applying. Neither context should recreate, drop, or alter existing business tables without an explicit data-preserving plan.

## Tests

`dotnet test tests/EnterpriseERP.UnitTests` runs offline model checks. Identity integration tests require the separate database named `enterprise_erp_identity_test_20261110`, loaded with the schema-only inventory, `tests/identity-legacy-fixture.sql`, and `identity-migration.sql`. They refuse to run against another database. Configure `ERP_IDENTITY_TEST_CONNECTION` and `ERP_IDENTITY_TEST_PASSWORD` to run them; otherwise they are skipped. The test database contains test accounts and must never use real administrator passwords. The tests cover bootstrap idempotency, legacy-user preservation, login and logout, antiforgery, account lockout, inactive accounts, and role denial. They do not establish tenant isolation.

## Remaining work

Implement tenant resolution, server-side tenant and branch authorization, tenant-safe relationships, tenant role management, permissions, audit logging, production operations, and ERP CRUD. Cross-tenant access has not been implemented or tested. Do not expose business records until those controls are in place.
