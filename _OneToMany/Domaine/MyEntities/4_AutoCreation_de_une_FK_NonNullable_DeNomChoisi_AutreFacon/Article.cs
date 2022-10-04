namespace Domaine.MyEntities
{
    // Article  * <---------- 1  Panier
    public class Article //Le simple fait que l'entité Panier possède une property public : IList<Article>, va faire que :
    {                  //     automatiquement la table Articles va se voir ajouter en base un champ FK
                       //     de nom PAR DEFAUT : PanierId (c-à-d : [NomEntitePanier][NomChampPKDeCetteEntitePanier])
                       //                  (FK alors PAR DEFAUT, sans autre précision : de type int, et nullable attention).
                       // Ici (dans PanierConfig) on renomme cette FK.

        //"Id" de par son nom est automatiquement identifié comme étant une PK (et autoincr. si déclarée de type int).
        //Rem.: si ce champ s'appelait : [NomEntite]Id, on aurait le même chose.
        public int Id { get; set; } //int et Surtout pas uint, sinon pas moyen de le mettre en autoincrement (Identity) cette PK.


        public string Code { get; set; }


        public Panier Panier { get; set; } // << sert JUSTE et uniquement ! à pouvoir écrire ceci dans PanierConfig :
                                           //    entityModelBuilder.WithOne(article => article.Panier)
                                           //    ou encore entityModelBuilder.WithOne("Panier")
    }
}
