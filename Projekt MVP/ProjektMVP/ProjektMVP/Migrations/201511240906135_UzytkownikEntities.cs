namespace ProjektMVP.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class UzytkownikEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UzytkownikEntities",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Imie = c.String(),
                    Nazwisko = c.String(),
                    Login = c.String(),
                    PermissionsId = c.Int(),
                    HotelId = c.Int(),
                    KartaKredytowaId = c.Int(nullable: true)
                })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.UzytkownikEntities");
        }
    }
}
