namespace Café_Love.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pedidos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PedidoCode = c.String(),
                        PedidotName = c.String(),
                        Description = c.String(),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pedidoes");
        }
    }
}
