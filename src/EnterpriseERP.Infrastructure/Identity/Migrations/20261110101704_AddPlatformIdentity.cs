using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EnterpriseERP.Infrastructure.Identity.Migrations
{
    /// <inheritdoc />
    public partial class AddPlatformIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "erp_core");

            // Users is an existing ERP table, excluded from EF's generated operations.
            // Nullable fields and false defaults preserve existing users and keep legacy
            // password hashes disabled until an explicit account migration is designed.
            migrationBuilder.Sql("""
                ALTER TABLE erp_core."Users"
                  ADD COLUMN "UserName" varchar(256),
                  ADD COLUMN "NormalizedUserName" varchar(256),
                  ADD COLUMN "NormalizedEmail" varchar(256),
                  ADD COLUMN "EmailConfirmed" boolean NOT NULL DEFAULT false,
                  ADD COLUMN "SecurityStamp" text,
                  ADD COLUMN "ConcurrencyStamp" text,
                  ADD COLUMN "PhoneNumber" text,
                  ADD COLUMN "PhoneNumberConfirmed" boolean NOT NULL DEFAULT false,
                  ADD COLUMN "TwoFactorEnabled" boolean NOT NULL DEFAULT false,
                  ADD COLUMN "LockoutEnd" timestamp with time zone,
                  ADD COLUMN "LockoutEnabled" boolean NOT NULL DEFAULT false,
                  ADD COLUMN "AccessFailedCount" integer NOT NULL DEFAULT 0,
                  ADD COLUMN "IdentityEnabled" boolean NOT NULL DEFAULT false,
                  ADD COLUMN "IsBootstrapAdmin" boolean NOT NULL DEFAULT false;
                CREATE UNIQUE INDEX "UX_IdentityUsers_NormalizedUserName" ON erp_core."Users" ("NormalizedUserName");
                CREATE INDEX "IX_IdentityUsers_NormalizedEmail" ON erp_core."Users" ("NormalizedEmail");
                CREATE UNIQUE INDEX "UX_IdentityUsers_OneBootstrapAdmin" ON erp_core."Users" ("IsBootstrapAdmin") WHERE "IsBootstrapAdmin";
                """);

            migrationBuilder.CreateTable(
                name: "IdentityUserClaims",
                schema: "erp_core",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentityUserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "erp_core",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserLogins",
                schema: "erp_core",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_IdentityUserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "erp_core",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserTokens",
                schema: "erp_core",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_IdentityUserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "erp_core",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlatformRoles",
                schema: "erp_core",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsSystemRole = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatformRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlatformRoleClaims",
                schema: "erp_core",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatformRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlatformRoleClaims_PlatformRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "erp_core",
                        principalTable: "PlatformRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlatformUserRoles",
                schema: "erp_core",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatformUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_PlatformUserRoles_PlatformRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "erp_core",
                        principalTable: "PlatformRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlatformUserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "erp_core",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IdentityUserClaims_UserId",
                schema: "erp_core",
                table: "IdentityUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityUserLogins_UserId",
                schema: "erp_core",
                table: "IdentityUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PlatformRoleClaims_RoleId",
                schema: "erp_core",
                table: "PlatformRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "erp_core",
                table: "PlatformRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlatformUserRoles_RoleId",
                schema: "erp_core",
                table: "PlatformUserRoles",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) =>
            throw new NotSupportedException("Identity rollback requires a reviewed data-preserving plan.");
    }
}
