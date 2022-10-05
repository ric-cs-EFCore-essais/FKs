using System.Collections.Generic;

namespace Domaine.MyEntities
{
    // Article  * <---------- 1  Panier
    public class Panier
    {
        //"Id" de par son nom est automatiquement identifié comme étant une PK (et autoincr. si déclarée de type int).
        //Rem.: si ce champ s'appelait : [NomEntite]Id, on aurait le même chose.
        public int Id { get; set; } //int et Surtout pas uint, sinon pas moyen de le mettre en autoincrement (Identity) cette PK.
        
        public string Reference { get; set; }

        public IList<Article> Articles { get; set; } //<<< Le simple fait d'avoir ceci, fait que d'emblée :
                                                     //     la table Articles va se voir ajouter automatiquement un champ FK
                                                     //     de nom PAR DEFAUT : PanierId (c-à-d : [NomEntite][NomChampPKDeCetteEntite])
                                                     //                         FK alors PAR DEFAUT, sans autre précision :
                                                     //                           de type int, et nullable attention.
                                                     //           Rem.:  ici (dans PanierConfig) on renomme cette FK.

        public double MontantTotal { get; set; } //Sera float en base.
    }
}

