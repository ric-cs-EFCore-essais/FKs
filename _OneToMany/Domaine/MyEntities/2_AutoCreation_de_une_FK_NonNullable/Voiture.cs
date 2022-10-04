using System;

namespace Domaine.MyEntities
{
    // Voiture  * <---------- 1  Garage
    public class Voiture //Le simple fait que l'entité Garage possède une property public : IList<Voiture>, va faire que :
    {                  //     automatiquement la table Voitures va se voir ajouter en base un champ FK
                       //     de nom : GarageId (c-à-d : [NomEntiteGarage][NomChampPKDeCetteEntiteGarage])
                       //              (FK alors PAR DEFAUT, sans autre précision : de type int, et nullable attention).

        public Guid Immatric { get; set; } //Je le paramétrerai en PK dans VoitureConfig
                                           //Rappel : un Guid est une chaîne alpha-num censée être unique.

        public string Modele { get; set; }


        public int GarageId { get; set; } //<<<< permet ainsi de rendre d'emblée Non nullable la FK qui sera autocréée en base
                                          // (et dont le nom sera justement par défaut : "GarageId" en effet).
                                          // Rem.: elle serait encore nullable, si j'avais mis ici :
                                          //        int?  au lieu de int  .  

                                            // REMARQUE : si j'avais mis à la place de ...int GarageId..., juste :
                                            //  public Garage Garage { get; set; }  ça n'aurait rien apporté,
                                            //  la FK créée automatiquement serait restée nullable,
                                            //  comme explicité.

    }
}
