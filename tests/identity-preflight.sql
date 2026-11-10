SELECT count(*) AS existing_users FROM erp_core."Users";
SELECT count(*) AS bootstrap_email_conflicts FROM erp_core."Users" WHERE upper("Email") = upper(:'admin_email');
SELECT table_name FROM information_schema.tables WHERE table_schema = 'erp_core'
  AND table_name IN ('__IdentityMigrationsHistory', 'IdentityUserClaims', 'IdentityUserLogins', 'IdentityUserTokens', 'PlatformRoles', 'PlatformRoleClaims', 'PlatformUserRoles');
SELECT column_name FROM information_schema.columns WHERE table_schema = 'erp_core' AND table_name = 'Users'
  AND column_name IN ('UserName', 'NormalizedUserName', 'NormalizedEmail', 'EmailConfirmed', 'SecurityStamp', 'ConcurrencyStamp', 'PhoneNumber', 'PhoneNumberConfirmed', 'TwoFactorEnabled', 'LockoutEnd', 'LockoutEnabled', 'AccessFailedCount', 'IdentityEnabled', 'IsBootstrapAdmin');
