using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliMania
{
    class Library
    {
        private String Name { get; set; }
        private List<Item> itemList;
        private List<Item> itemBorrowList;

        public Library(String name)
        {
            Name = name;
            itemList = new List<Item>();
            itemBorrowList = new List<Item>();
        }

        public void addBook()
        {
            Console.WriteLine("********** Formulaire d'ajout de livre **********");

            Console.WriteLine("Choisissez le titre du livre :");
            String title = Console.ReadLine();

            Console.WriteLine("Renseignez le nom et prénom de l'autheur :");
            String author = Console.ReadLine();

            Console.WriteLine("Renseignez l'ISBN du livre :");
            int isbn = int.Parse(Console.ReadLine());

            Console.WriteLine("Choisissez un ou plusieurs genre(s) pour le livre :");
            BookType bookType = BookType.EROTICISM;

            Console.WriteLine("Indiquez le nombre de livre en stock :");
            int stock = int.Parse(Console.ReadLine());

            int uniqueId = itemList.Count() + 1; // Rechanger par la function d'Alexandre
            Book book = new Book(isbn, bookType,author, uniqueId, title, stock);
            itemList.Add(book);
        }

        public void addCD()
        {

        }

        public void addMusic()
        {

        }

        public void mainMenu()
        {
            Console.WriteLine("\n\n******************************");
            Console.WriteLine("***** " + Name + " *****");
            Console.WriteLine("******************************");
            Console.WriteLine("Voici la liste des fonctionnalités disponibles :");
            Console.WriteLine("1) Lister toute la bibiliothèque");
            Console.WriteLine("2) Rechercher un livre par son titre");
            Console.WriteLine("3) Rechercher un CD par son titre");
            Console.WriteLine("4) Ajouter un livre");
            Console.WriteLine("5) Ajouter un CD");
            Console.WriteLine("6) Ramener un livre emprunté");
            Console.WriteLine("Ou tapez 'q' pour quitter");
            Console.WriteLine("Tapez le numéro correspondant à votre choix :");
            choiceMenu();
        }

        private void choiceMenu()
        {
            String userChoice = Console.ReadLine();
            if(userChoice == "q")
            {
                return;
            }
            else
            {
                int numberChoice = int.Parse(userChoice);
                switch (numberChoice)
                {
                    case 4:
                        addBook();
                        break;
                    default:
                        Console.WriteLine("Choix non reconnu.");
                        break;
                }
                mainMenu();
            }
        }
    }
}
