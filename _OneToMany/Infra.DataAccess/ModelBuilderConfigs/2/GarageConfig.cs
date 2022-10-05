using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Domaine.MyEntities;


namespace Infra.DataAccess.ModelBuilderConfigs
{
    public class GarageConfig : IEntityTypeConfiguration<Garage>
    {
        public void Configure(EntityTypeBuilder<Garage> entityModelBuilder)
        {
            entityModelBuilder
                .Property(garage => garage.Nom)
                .IsRequired();

            entityModelBuilder
                .HasIndex(garage => new { garage.Nom })
                .IsUnique(); //PAS DE DOUBLON autorisé sur ce champ
        }
    }
}
