using Core.Models;
namespace Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            int choice;
            do
            {
                Console.WriteLine("Menu:\n1.Kitab elave et.\n2.Butun kitablarin siyahisina bax.\n3.Ada gore axtaris et.\n4.kitabi sil.\n5.Value deyerine gore axtaris et.\n0.Proqrami bitir.");
                choice=Convert.ToInt32(Console.ReadLine());


                if (choice == 1)
                {
                    Console.WriteLine("Kitabin adini  daxil edin:");
                    string name=Console.ReadLine();

                    Console.WriteLine(" ");
                    Console.WriteLine("Yazicini daxil edin:");
                    string authorName=Console.ReadLine();

                    Console.WriteLine(" ");
                    string pageCountStr = " ";
                    int pageCount;
                    do
                    {
                        Console.WriteLine("Sehife sayini daxil edin:");
                        pageCountStr = Console.ReadLine();
                    }
                    while (!int.TryParse(pageCountStr, out pageCount));

                    Books newBook = new Books(name,authorName,pageCount);

                    library.AddBook(newBook);
                    Console.WriteLine("Kitab elave edildi!");
                }
                else if (choice == 2)
                {
                    for(int i = 0; i < library.ShowAllBooks().Length; i++)
                    {
                        Console.WriteLine(library.ShowAllBooks()[i]);
                        Console.WriteLine("-------------------");
                    }
                }
                else if(choice == 3)
                {
                    Console.WriteLine("Axtaris etmek istediyiniz value deyerini daxil edin:");
                    string value=Console.ReadLine();

                    foreach(var item in library.FindAllBooksByName(value))
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("------------------------------------------");
                }
                else if( choice == 4)
                {
                    Console.WriteLine("Ada gore silmek istediyiniz kitaba uygun deyer daxil edin:");
                    string value=Console.ReadLine();

                    foreach(var item in library.RemoveAllBooksByName(value))
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Value deyerini daxil edin:");
                    string value=Console.ReadLine();

                    foreach(var item in library.SearchBooks(value))
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("------------------------");
                }
            }
            while (choice!=0);

            Console.WriteLine("Proqram bitdi!");

        }
    }
}
