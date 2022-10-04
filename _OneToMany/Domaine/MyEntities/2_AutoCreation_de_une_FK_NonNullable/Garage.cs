using System.Collections.Generic;

namespace Domaine.MyEntities
{
    // Voiture  * <---------- 1  Garage
    public class Garage
    {
        //"Id" de par son nom est automatiquement identifié comme étant une PK (et autoincr. si déclarée de type int).
        //Rem.: si ce champ s'appelait : [NomEntite]Id, on aurait le même chose.
        public int Id { get; set; } //int et Surtout pas uint, sinon pas moyen de le mettre en autoincrement (Identity) cette PK.
        
        public string Nom { get; set; }

        public IList<Voiture> Voitures { get; set; } //<<< Le simple fait d'avoir ceci, fait que d'emblée :
                                                     //     la table Voitures va se voir ajouter automatiquement un champ FK
                                                     //     de nom : GarageId (c-à-d : [NomEntite][NomChampPKDeCetteEntite])
                                                     //              FK alors PAR DEFAUT, sans autre précision :
                                                     //               de type int, et nullable attention.
                                                     //             (cf. dans classe Voiture, comment je l'ai rendue Non nullable). 
    }
}

