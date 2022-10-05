using Microsoft.EntityFrameworkCore;


using Domaine.MyEntities;
using Infra.DataAccess.ModelBuilderConfigs;

namespace Infra.DataAccess
{
    public class MyApplicationDbContext : DbContext
    {
        public MyApplicationDbContext(DbContextOptions<MyApplicationDbContext> options) : base(options)
        {
        }

        //--------------------------------------

        // Pour 1_AutoCreation_de_une_FK_nullable
        public DbSet<Bibliotheque> Bibliotheques { get; set; }
        public DbSet<Livre> Livres { get; set; }

        
        // 2_AutoCreation_de_une_FK_NonNullable
        public DbSet<Garage> Garages { get; set; }
        public DbSet<Voiture> Voitures { get; set; }


        // 3_AutoCreation_de_une_FK_NonNullable_DeNomChoisi
        public DbSet<Train> Trains { get; set; }
        public DbSet<Passager> Passagers { get; set; }


        // 4_AutoCreation_de_une_FK_NonNullable_DeNomChoisi_AutreFacon
        public DbSet<Panier> Paniers { get; set; }
        public DbSet<Article> Articles { get; set; }




        //---------- Utilisation de la Fluent API, permet de paramétrer sans passer par des annotations, et donc sans toucher aux classes du Domaine ------------
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Pour 1_AutoCreation_de_une_FK_nullable
            modelBuilder.ApplyConfiguration(new BibliothequeConfig());
            modelBuilder.ApplyConfiguration(new LivreConfig());

            // 2_AutoCreation_de_une_FK_NonNullable
            modelBuilder.ApplyConfiguration(new GarageConfig());
            modelBuilder.ApplyConfiguration(new VoitureConfig());

            // 3_AutoCreation_de_une_FK_NonNullable_DeNomChoisi
            modelBuilder.ApplyConfiguration(new TrainConfig());
            modelBuilder.ApplyConfiguration(new PassagerConfig());

            // 4_AutoCreation_de_une_FK_NonNullable_DeNomChoisi_AutreFacon
            modelBuilder.ApplyConfiguration(new PanierConfig());
            modelBuilder.ApplyConfiguration(new ArticleConfig());

        }

    }
}
