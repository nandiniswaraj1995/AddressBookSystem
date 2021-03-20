using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
   public  class Program
    {
        public static Dictionary<string, List<Contact>> addressBookStore = new Dictionary<string, List<Contact>>();

        static void Main(string[] args)
        {

            Console.WriteLine("Wellcome To Address Book System Program!");
            Console.WriteLine("*****************************************");
            Console.WriteLine("Enter the book name you want to store");
            string bookName = Console.ReadLine();
            AddressBook.addBook(bookName);


        }
    }
}
