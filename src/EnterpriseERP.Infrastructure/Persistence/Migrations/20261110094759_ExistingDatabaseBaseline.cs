using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnterpriseERP.Infrastructure.Persistence.Migrations;

// The snapshot represents an existing database. This migration must never recreate it.
public partial class ExistingDatabaseBaseline : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder) { }

    protected override void Down(MigrationBuilder migrationBuilder) =>
        throw new NotSupportedException("The existing-database baseline cannot be rolled back automatically.");
}
