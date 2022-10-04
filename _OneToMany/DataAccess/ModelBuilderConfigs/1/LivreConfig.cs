using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Domaine.MyEntities;


namespace DataAccess.ModelBuilderConfigs
{
    public class LivreConfig : IEntityTypeConfiguration<Livre>
    {
        public void Configure(EntityTypeBuilder<Livre> entityModelBuilder)
        {
            entityModelBuilder
                .Property(livre => livre.Titre)
                .IsRequired();


            //Comme explicité dans les classes Livre et Bibliotheque, le champ "BibliothequeId"
            // a été généré AUTOMATIQUEMENT en base par EF, du fait que la classe Bibliotheque
            // ait un membre de type : IList<Livre>, (alors que la classe Livre n'a pas de membre BibliothequeId). 
            entityModelBuilder
                .Property("BibliothequeId")
                .IsRequired();
            //    Rem.: syntaxe  entityModelBuilder.Property(livre => livre.BibliothequeId).IsRequired();
            //          interdite CAR justement le membre BibliothequeId n'existe PAS dans l'entité Livre
            //          (mais existe bien en base par contre).  
            //          ici on veut juste le rendre NON nullable, car vu comme il a été créé, il l'est par défaut !

        }
    }
}
