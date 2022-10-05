using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Domaine.MyEntities;


namespace Infra.DataAccess.ModelBuilderConfigs
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

            entityModelBuilder
                .HasIndex(voiture => new { voiture.Immatric })
                .IsUnique(); //PAS DE DOUBLON autorisé sur ce champ

        }
    }
}
