using System;
using System.Collections.Generic;
using book_club.Models;

namespace book_club
{
    class Program
    {
        static void Main(string[] args)
        {

            // book objects

            var book1 = new Book
            {
                title = "Entangled Life: How Fungi Make Our Worlds, Change Our Minds and Shape Our Futures",
                author = "Merlin Sheldrake"
            };

            var book2 = new Book
            {
                title = "Becoming",
                author = "Michelle Obama"
            };

            var book3 = new Book
            {
                title = "The Art of War",
                author = "Sun Tzu"
            };

            var book4 = new Book
            {
                title = "Robinson Crusoe",
                author = "Daniel Defoe"
            };

            var book5 = new Book
            {   
                title = "Moll Flanders",
                author = "Daniel Defoe"
            };

            var book6 = new Book
            {
                title = "Outlander",
                author = "Diana Gabaldon"
            };

            var book7 = new Book
            {
                title = "Slaughterhouse-Five",
                author = "Kurt Vonnegut"
            };

            var book8 = new Book
            {
                title = "The Princess Bride",
                author = "William Goldman"
            };

            var book9 = new Book
            {
                title = "The Wife Between Us",
                author = "Greer Hendricks and Sarah Pekkanen"
            };

            var book10 = new Book
            {
                title = "Gulliver's Travels",
                author = "Jonathan Swift"
            };

            var book11 = new Book
            {
                title = "The Quiet American",
                author = "Graham Greene"
            };

            var book12 = new Book
            {
                title = "East of Eden",
                author = "John Steinbeck"
            };

            
            // member objects

            var member1 = new Member
            {
                firstName = "Mario",
                lastName = "Mario",
                favouriteBook = new List<Book>{book1},
                readingList = new List<Book>{book8, book12}
            };

            var member2 = new Member
            {
                firstName = "Alison",
                lastName = "Hargreeves",
                favouriteBook = new List<Book>{book2},
                readingList = new List<Book>{book6, book9}
            };

            var member3 = new Member
            {
                firstName = "Phillip",
                lastName = "Coulson",
                favouriteBook = new List<Book>{book3},
                readingList = new List<Book>{book7, book11}
            };

            var member4 = new Member
            {
                firstName = "Elizabeth",
                lastName = "Swann",
                favouriteBook = new List<Book>{book4},
                readingList = new List<Book>{book5, book10}
            };

            // member list
            var members = new List<Member>
            {
                member1, member2, member3, member4
            };

            // recommended book list

            var recommendedBookList = new List<Book>
            {
                book2, book4, book7, book8
            };

            // title
            Console.WriteLine();
            Console.WriteLine("Welcome to the Readers' Roundup!");
            Console.WriteLine();

            while (true)
            {   
                Console.WriteLine();
                Console.WriteLine("What do you want to do? Select the appropriate number.");
                Console.WriteLine("1. See list of members.");
                Console.WriteLine("2. See a list of the members' recommended books.");
                Console.WriteLine("3. See what our members are currently reading.");
                Console.WriteLine("4. Add a new member.");
                Console.WriteLine("5. Add a book to the recommendation list.");
                Console.WriteLine("Press X to exit.");
                Console.WriteLine();

                var readerInput = Console.ReadLine().Trim();

                if (readerInput == "x" || readerInput == "X")
                {   
                    Console.WriteLine();
                    Console.WriteLine("Exiting program...");
                    break;
                }

                switch (readerInput)
                {
                    case "1":
                        DisplayMembers();
                        break;
                    case "2":
                        DisplayRecommendedList();
                        break;
                    case "3":
                        DisplayMembersReadingLists();
                        break;
                    case "4":
                        AddNewMember();
                        break;
                    case "5":
                        AddNewRecommendedBook();
                        break;

                }
            }
                



            













            // methods

            void DisplayMembers()
            {   
                Console.WriteLine();
                Console.WriteLine("Member list:");
                foreach (var person in members)
                {
                    Console.WriteLine($"{person.firstName}");
                }
                Console.WriteLine();
                Console.WriteLine("~~~~~");
            }

            void DisplayRecommendedList()
            {   
                Console.WriteLine();
                Console.WriteLine("Recommended books:");
                foreach (var book in recommendedBookList)
                {
                    book.DisplayBook();
                }
                Console.WriteLine();
                Console.WriteLine("~~~~~");
            }

            
            void AddNewMember()
            {   
                Console.WriteLine();
                Console.WriteLine("Please enter first name of new member:");
                var newMemberFirstName = Console.ReadLine().Trim();

                Console.WriteLine("Please enter last name of new member:");
                var newMemberLastName = Console.ReadLine().Trim();

                var newMember = new Member
                {
                    firstName = newMemberFirstName,
                    lastName = newMemberLastName
                };
                
                members.Add(newMember);

                Console.WriteLine();
                Console.WriteLine("New member added!");

                DisplayMembers();

                Console.WriteLine();
            }

            
            void DisplayMembersReadingLists()
            {
                Console.WriteLine();          
                Console.WriteLine("What we are currently reading:");
                foreach (var person in members)
                {
                    Console.WriteLine($"{person.firstName} is reading:");
                    foreach (var book in person.readingList)
                    {
                        book.DisplayBook();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("~~~~~");
            }

            void AddNewRecommendedBook()
            {   
                Console.WriteLine();
                Console.WriteLine("Please enter the title of the book you want to add to the recommendation list:");
                var newRecommendedBookTitle = Console.ReadLine().Trim();

                Console.WriteLine("Please enter the author(s) of the book you want to add to the recommendation list:");
                var newRecommendedBookAuthor = Console.ReadLine().Trim();

                var newBook = new Book
                {
                    title = newRecommendedBookTitle,
                    author = newRecommendedBookAuthor
                };
                
                recommendedBookList.Add(newBook);

                Console.WriteLine();
                Console.WriteLine("New book added to the recommendation list!");

                DisplayRecommendedList();

                Console.WriteLine();

            }


        }

    }
}