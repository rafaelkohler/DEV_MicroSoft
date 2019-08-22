namespace EmpresaAerea
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelEmpresaAerea : DbContext
    {
        // Your context has been configured to use a 'ModelEmpresaAerea' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EmpresaAerea.ModelEmpresaAerea' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelEmpresaAerea' 
        // connection string in the application configuration file.
        public ModelEmpresaAerea()
            : base("name=ModelEmpresaAerea")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Passagem>()
                .HasOptional<FormaPagamento>(f => f.Pagamento)
                .WithOptionalPrincipal<Passagem>(p => p.Passagem);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Voo> Voos { get; set; }

        public virtual DbSet<Poltrona> Poltornas { get; set; }

        public virtual DbSet<Pessoa> Pessoas { get; set; }

        public virtual DbSet<Passagem> Passagens { get; set; }

        public virtual DbSet<FormaPagamento> FormaPagamentos { get; set; }

        public virtual DbSet<Cidade> Cidades { get; set; }

        public virtual DbSet<Aviao> Avioes { get; set; }
    }
}