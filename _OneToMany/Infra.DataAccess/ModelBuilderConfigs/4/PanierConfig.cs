using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Domaine.MyEntities;


namespace Infra.DataAccess.ModelBuilderConfigs
{
    public class PanierConfig : IEntityTypeConfiguration<Panier>
    {
        public void Configure(EntityTypeBuilder<Panier> entityModelBuilder)
        {
            entityModelBuilder
                .Property(panier => panier.Reference)
                .IsRequired();

            entityModelBuilder
                .HasMany(panier => panier.Articles)
                //Rem.: la syntaxe juste ci-dessous concernera alors un Article (comme l'indique sa lambda d'ailleurs).

                .WithOne(article => article.Panier) //<<< Equivaudra à :  .WithOne("Panier")
                //.WithOne("Panier")
                .HasForeignKey("My_PanierId") //Renommage FK
                .IsRequired()//<<< S'applique au champ juste ci-dessus, donc à la FK : <<<< et c'est grâce à ce IsRequired()
                             //    que cette FK sera NON nullable !!!
                ;


            //AIDE requête SQL de visu. :
            // select * from dbo.Articles as A
            //          inner join dbo.Paniers as P
            //          on P.Id = A.My_PanierId
            // order by P.Id;

        }
    }
}
