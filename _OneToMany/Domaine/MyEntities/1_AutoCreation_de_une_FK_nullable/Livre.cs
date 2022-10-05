using System;

namespace Domaine.MyEntities
{
    // Livre  * <----------  Bibliotheque
    public class Livre //Le simple fait que l'entité Bibliotheque possède une property public : IList<Livre>, va faire que :
    {                  //     automatiquement la table Livres va se voir ajouter en base un champ FK
                       //     de nom : BibliothequeId (c-à-d : [NomEntiteBiblio][NomChampPKDeCetteEntiteBiblio])
                       //              (FK alors PAR DEFAUT, sans autre précision : de type int, et nullable attention).


        //"Id" de par son nom est automatiquement identifié comme étant une PK (et autoincr. si déclarée de type int).
        //Rem.: si ce champ s'appelait : [NomEntite]Id, on aurait le même chose.        
        public int Id { get; set; } //int et Surtout pas uint, sinon pas moyen de le mettre en autoincrement (Identity) cette PK.

        public string Titre { get; set; }

        public DateTime? DatePublication { get; set; }

        //L'inconvénient de ne pas avoir explicitement déclaré ici une FK (BibliothequeId) vers Bibliotheque, fait que 
        //celle-ci est automatiquement créée par EF en base(comme expliquée) MAIS cette FK est alors nullable :/
        // Pour rattrapper le coup, j'ai donc ajouté ensuite dans LivreConfig, ceci (qui marche nickel) :
        //    entityModelBuilder.Property("BibliothequeId").IsRequired()
        //    Rem.: syntaxe  entityModelBuilder.Property(livre => livre.BibliothequeId).IsRequired()
        //          interdite CAR justement le membre BibliothequeId n'existe PAS dans l'entité Livre (mais existe bien en base par contre).  
    }
}
