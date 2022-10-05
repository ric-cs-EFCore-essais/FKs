using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Domaine.MyEntities;


namespace Infra.DataAccess.ModelBuilderConfigs
{
    public class PassagerConfig : IEntityTypeConfiguration<Passager>
    {
        public void Configure(EntityTypeBuilder<Passager> entityModelBuilder)
        {
            entityModelBuilder
                .Property(passager => passager.NumeroSecu)
                .IsRequired();

            entityModelBuilder
                .HasOne(passager => passager.Train)  //1 passager ------> 1 Train
                  //Rem.: la syntaxe juste ci-dessous concernera alors un Train (comme l'indique sa lambda).

                .WithMany(train => train.Passagers)  //1 Train --------> many Passager.
                   //Rem.: la syntaxe juste ci-dessous concernera alors un Passager
                .HasForeignKey("My_TrainId_FK") //<< Nom de FK personnalisé(au lieu de TrainId), et rattaché à la dernière entité évoquée au-dessus (donc ici "Passager" dans "train.Passagers").
                .IsRequired() //<<< S'applique au champ juste ci-dessus, donc à la FK : <<<< et c'est grâce à ce IsRequired()
                              //    que cette FK sera NON nullable !!!
                ;

            entityModelBuilder 
                .HasIndex(passager => new { passager.NumeroSecu }) 
                .IsUnique(); //PAS DE DOUBLON autorisé sur ce champ


            //AIDE requête SQL de visu. :
            // select * from dbo.Passagers as P
            //          inner join dbo.Trains as T
            //          on T.Id = P.My_TrainId_FK
            // order by T.Id;

        }
    }
}
