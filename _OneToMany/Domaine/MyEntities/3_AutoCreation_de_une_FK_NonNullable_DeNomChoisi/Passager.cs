namespace Domaine.MyEntities
{
    // Passager  * <---------- 1  Train
    public class Passager //Le simple fait que l'entité Train possède une property public : IList<Passager>, va faire que :
    {                  //     automatiquement la table Passagers va se voir ajouter en base un champ FK
                       //     de nom PAR DEFAUT : TrainId (c-à-d : [NomEntiteTrain][NomChampPKDeCetteEntiteTrain])
                       //                  (FK alors PAR DEFAUT, sans autre précision : de type int, et nullable attention).
                       // Ici (dans PassagerConfig) on renomme cette FK.

        //"Id" de par son nom est automatiquement identifié comme étant une PK (et autoincr. si déclarée de type int).
        //Rem.: si ce champ s'appelait : [NomEntite]Id, on aurait le même chose.
        public int Id { get; set; } //int et Surtout pas uint, sinon pas moyen de le mettre en autoincrement (Identity) cette PK.


        public string NumeroSecu { get; set; }


        public Train Train { get; set; } // << sert JUSTE et uniquement ! à pouvoir écrire ceci dans PassagerConfig :
                                         //    entityModelBuilder.HasOne(passager => passager.Train)
                                         //   et ce  qui le suit (.WithMany(...)).
    }
}
