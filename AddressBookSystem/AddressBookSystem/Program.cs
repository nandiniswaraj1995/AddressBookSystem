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
            Console.WriteLine("Enter the book name in which you want to Edit data:");
            string bookNameHasReocrd = Console.ReadLine();
            Console.WriteLine("Enter Person's FirstName to edit data:");
            string recordNameToEdit = Console.ReadLine();
            AddressBook.edit(bookNameHasReocrd, recordNameToEdit);
            Console.WriteLine("Enter the book name in which you want to Delete data:");
            string bookName1 = Console.ReadLine();
            AddressBook.delete(bookName1);







        }
    }
}
