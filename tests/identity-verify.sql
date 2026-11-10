SELECT "MigrationId" FROM erp_core."__IdentityMigrationsHistory" ORDER BY "MigrationId";
SELECT u."Email", u."IsActive", u."IdentityEnabled", u."EmailConfirmed", u."IsBootstrapAdmin", r."Name" AS platform_role,
       (u."PasswordHash" IS NOT NULL AND u."PasswordHash" <> '') AS has_password_hash
FROM erp_core."Users" u
LEFT JOIN erp_core."PlatformUserRoles" ur ON ur."UserId" = u."Id"
LEFT JOIN erp_core."PlatformRoles" r ON r."Id" = ur."RoleId"
WHERE upper(u."Email") = upper(:'admin_email');
SELECT count(*) AS bootstrap_administrators FROM erp_core."Users" WHERE "IsBootstrapAdmin";
