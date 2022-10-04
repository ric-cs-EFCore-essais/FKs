using System.Collections.Generic;

namespace Domaine.MyEntities
{
    // Passager  * <---------- 1  Train
    public class Train
    {
        //"Id" de par son nom est automatiquement identifié comme étant une PK (et autoincr. si déclarée de type int).
        //Rem.: si ce champ s'appelait : [NomEntite]Id, on aurait le même chose.
        public int Id { get; set; } //int et Surtout pas uint, sinon pas moyen de le mettre en autoincrement (Identity) cette PK.
        
        public string Reference { get; set; }

        public IList<Passager> Passagers { get; set; } //<<< Le simple fait d'avoir ceci, fait que d'emblée :
                                                       //     la table Passagers va se voir ajouter automatiquement un champ FK
                                                       //     de nom PAR DEFAUT : TrainId (c-à-d : [NomEntite][NomChampPKDeCetteEntite])
                                                       //                         FK alors PAR DEFAUT, sans autre précision :
                                                       //                           de type int, et nullable attention.
                                                       //           Rem.:  ici (dans PassagerConfig) on renomme cette FK.
    }
}

