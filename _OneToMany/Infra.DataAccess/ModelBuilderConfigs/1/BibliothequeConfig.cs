using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Domaine.MyEntities;


namespace Infra.DataAccess.ModelBuilderConfigs
{
    public class BibliothequeConfig : IEntityTypeConfiguration<Bibliotheque>
    {
        public void Configure(EntityTypeBuilder<Bibliotheque> entityModelBuilder)
        {
            entityModelBuilder
                .Property(biblio => biblio.Nom)
                .IsRequired();
        }
    }
}
