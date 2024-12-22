/* Programe calculatrice permettant d'effectuer les opérations :
 d'addition, de soustraction, de multiplication, de division et de puissance. 
*/
namespace calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {


                double num1 = 0;        
                double num2 = 0;
                double result = 0;

            do                                        
            {
                
                  
                // Affichage d'acceuil
                Console.WriteLine(" ---------------- ");
                Console.WriteLine(" ---------------- ");                            
                Console.WriteLine("/ Bienvenue dans /");
                Console.WriteLine("/ la calculatrice/");
                Console.WriteLine("/ console C#     /");
                Console.WriteLine(" ---------------- ");
                Console.WriteLine(" ---------------- ");

                // Gestion du cas ou c'est la première opération
                if (result == 0)
                    {  

                    Console.Write("Enter un premier nombre : ");
                // Gestion du cas ou l'utilisateur n'entre pas un chiffre 
                    while (!double.TryParse(Console.ReadLine(), out num1)) 
                    {
                    Console.Write("Saisie invalide. Entrez un nombre valide : ");
                    }

                    }
                else 
                {
                // Gestion du cas ou ce n'est pas la premiere opération
                    num1 = result;
                    Console.WriteLine($"{num1}");
                }


                //Demande a l'utilisateur le second nombre
                Console.Write("Entrer un autre nombre: ");
                    while (!double.TryParse(Console.ReadLine(), out num2))       
                    {
                // Affichage en cas de mauvaise saisie 
                    Console.Write("Saisie invalide. Entrez un nombre valide : ");    
                    }


                // Affichage pour choix de l'opérateur
                Console.WriteLine(" choisissez l'opérateur: ");
                Console.WriteLine("\t+ : Pour l'addition");                          
                Console.WriteLine("\t- : Pour la soustraction");
                Console.WriteLine("\t* : Pour la multiplication");
                Console.WriteLine("\t/ : Pour la division");
                Console.WriteLine("\t^ : Pour la puissance");
                Console.WriteLine("\t% : Pour le modulo");

                string operateur = Console.ReadLine();
                // Opération selon le choix de l'utilisateur 
                switch (operateur)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;                       
                        break;
                    case "/":
                // Gestion de la division par zéro non autorisé
                    if (num2 != 0) {                                                    
                        result = num1 / num2;
                    }
                        else {
                            Console.WriteLine("La division par zéro n'est pas authorisé ");
                        }
                        break;
                    case "^": 
                        result = Math.Pow (num1, num2);
                        break;
                    case "%": 
                        result = num1 % num2;
                        break;
                // Gestion de l'opérateur différent de ceux proposé a l'utilisateur
                    default:                                                             
                        Console.WriteLine("choissisez un opérateur proposé");
                        continue;
                }
                // Affichage de l'opération effectuer et du résultat 
                Console.WriteLine($"Le résultat de {num1} {operateur} {num2} = {result}");
                // Affichage option continuer 
                Console.Write("souhaitez vous continuer? (O = oui , N = Non): ");
            }
                 // Gestion pour la saisie de l'option continuer 
                 while (Console.ReadLine().ToUpper() == "O");                             

                 Console.WriteLine("A bientot pour d'autres calculs ^__^  ! ");
        }
    }
}