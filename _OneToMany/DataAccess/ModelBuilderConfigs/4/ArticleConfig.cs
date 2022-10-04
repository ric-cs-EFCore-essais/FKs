using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Domaine.MyEntities;


namespace DataAccess.ModelBuilderConfigs
{
    public class ArticleConfig : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> entityModelBuilder)
        {
            entityModelBuilder
                .Property(article => article.Code)
                .IsRequired();
        }
    }
}
