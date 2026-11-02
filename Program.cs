namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    {
        /*
        Arthur dispose de 5 flèches pour chasser un cerf.

        Consignes :
        - Demander au joueur si chaque tir touche ou rate la cible.
        - Décrémenter le nombre de flèches après chaque tir.
        - Compter le nombre de tirs réussis.
        - Arrêter la chasse lorsque les 5 flèches sont utilisées.
        - Arrêter immédiatement la chasse si le cerf est touché 3 fois.
        - Si la saisie est invalide, demander une nouvelle réponse
          sans consommer de flèche.
        - Afficher le bilan final de la chasse.
        */
        int flèches = 5;
        int tirsRéussis = 0;

        while (flèches > 0 && tirsRéussis < 3)
        {
            Console.WriteLine("Le tir touche-t-il la cible ? (touché/raté) : ");
            string réponse = Console.ReadLine();

            if (réponse == "touché")
            {
                tirsRéussis++;
                flèches--;
                Console.WriteLine("Bien joué ! Vous avez touché la cible.");
            }
            else if (réponse == "raté")
            {
                flèches--;
                Console.WriteLine("Le tir a raté la cible.");
            }
            else
            {
                Console.WriteLine("Veuillez répondre par 'touché' ou 'raté'.");
            }
        }

        Console.WriteLine($"Bilan de chasse. Tirs réussis : {tirsRéussis} \nFlèches restantes : {flèches} \n résultat : {'Chasse réussie' if tirsRéussis >= 3 else 'Chasse échouée'}");
    }
}