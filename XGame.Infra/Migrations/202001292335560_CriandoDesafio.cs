namespace Desafio.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoDesafio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Cpf = c.String(nullable: false, maxLength: 255, unicode: false),
                        Uf = c.String(maxLength: 50, unicode: false),
                        Datanascimento = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Email = c.String(nullable: false, maxLength: 200, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true, name: "UK_JOGADOR_EMAIL");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Usuario", "UK_JOGADOR_EMAIL");
            DropTable("dbo.Usuario");
            DropTable("dbo.Pessoa");
        }
    }
}
