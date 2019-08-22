namespace ORMEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _201908192125 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pessoas", "Cidade_Id1", "dbo.Cidades");
            DropIndex("dbo.Pessoas", new[] { "Cidade_Id1" });
            RenameColumn(table: "dbo.Cidades", name: "nomeC_cdade", newName: "nome_Cidade");
            DropColumn("dbo.Pessoas", "Cidade_Id1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pessoas", "Cidade_Id1", c => c.Int());
            RenameColumn(table: "dbo.Cidades", name: "nome_Cidade", newName: "nomeC_cdade");
            CreateIndex("dbo.Pessoas", "Cidade_Id1");
            AddForeignKey("dbo.Pessoas", "Cidade_Id1", "dbo.Cidades", "Id");
        }
    }
}
