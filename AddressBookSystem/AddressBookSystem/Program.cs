using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
   public  class Program
    {
       public static  Dictionary<string, Contact> addressBookStore = new Dictionary<string, Contact>();
        static void Main(string[] args)
        {

            Console.WriteLine("Wellcome To Address Book System Program!");
            Console.WriteLine("*****************************************");
            Console.WriteLine("Enter the book name you want to store");
            string bookName = Console.ReadLine();
            AddressBook.addBook(bookName);
            Console.WriteLine("Enter the book name in which you want to Edit data:");
            string bookNameHasReocrd = Console.ReadLine();
            AddressBook.edit(bookNameHasReocrd);
        }
    }
}
