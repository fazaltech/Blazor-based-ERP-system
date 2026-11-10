using EnterpriseERP.Infrastructure.Persistence.Migrations;
using EnterpriseERP.Infrastructure.Persistence.Scaffold;
using EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseERP.UnitTests;

public class ExistingSchemaModelTests
{
    private static ERPDbContext CreateContext() => new(
        new DbContextOptionsBuilder<ERPDbContext>()
            .UseNpgsql("Host=localhost;Database=unused;Username=unused;Password=unused")
            .Options);

    [Fact]
    public void ReverseEngineeredModelIncludesAllInspectedTables()
    {
        using var context = CreateContext();
        Assert.Equal(202, context.Model.GetEntityTypes().Count());
    }

    [Theory]
    [InlineData(typeof(Tenant), "Tenants", "erp_core")]
    [InlineData(typeof(Item), "Items", "erp_inventory")]
    [InlineData(typeof(Warehouse), "Warehouses", "erp_inventory")]
    public void ImportantEntitiesUseExistingQuotedTableNames(Type type, string table, string schema)
    {
        using var context = CreateContext();
        var entity = context.Model.FindEntityType(type);
        Assert.NotNull(entity);
        Assert.Equal(table, entity.GetTableName());
        Assert.Equal(schema, entity.GetSchema());
        Assert.NotNull(entity.FindPrimaryKey());
    }

    [Fact]
    public void BaselineHasNoSchemaOperations()
    {
        Assert.Empty(new ExistingDatabaseBaseline().UpOperations);
    }
}
