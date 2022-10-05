using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Domaine.MyEntities;


namespace Infra.DataAccess.ModelBuilderConfigs
{
    public class TrainConfig : IEntityTypeConfiguration<Train>
    {
        public void Configure(EntityTypeBuilder<Train> entityModelBuilder)
        {
            entityModelBuilder
                .Property(train => train.Reference)
                .IsRequired();

        }
    }
}
