using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Domaine.MyEntities;


namespace DataAccess.ModelBuilderConfigs
{
    public class VoitureConfig : IEntityTypeConfiguration<Voiture>
    {
        public void Configure(EntityTypeBuilder<Voiture> entityModelBuilder)
        {

            entityModelBuilder
                .HasKey(voiture => voiture.Immatric); //PK explicitement mentionnée ici.

            entityModelBuilder
                .Property(voiture => voiture.Modele)
                .IsRequired();

        }
    }
}
