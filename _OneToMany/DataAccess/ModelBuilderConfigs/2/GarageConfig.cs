using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Domaine.MyEntities;


namespace DataAccess.ModelBuilderConfigs
{
    public class GarageConfig : IEntityTypeConfiguration<Garage>
    {
        public void Configure(EntityTypeBuilder<Garage> entityModelBuilder)
        {
            entityModelBuilder
                .Property(garage => garage.Nom)
                .IsRequired();
        }
    }
}
