﻿using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace AddressBookSystem
{
    public class FileOperation
    {
       
        public static void ReadFromStreamReader()
        {
            String path = "E:\\AddressBook\\AddressBookSystem\\AddressBookSystem\\AddressBookSystem\\AddreddBook.txt";
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        String s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }
                else
                {
                    throw new AddressBookException(AddressBookException.ExceptionType.FILE_NOT_EXIST, "File Not Exists");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void WriteUsingStreamWriter()
        {
            String path = "E:\\AddressBook\\AddressBookSystem\\AddressBookSystem\\AddressBookSystem\\AddreddBook.txt";
            try
            {
                if (File.Exists(path))
                {
                    using (StreamWriter sr = File.AppendText(path))
                    {

                        Console.WriteLine("Book Name");
                        sr.Write("Book Name  : ");
                        string bookName = Console.ReadLine();
                        sr.WriteLine(bookName);
                        Console.WriteLine("Enter First Name");
                        sr.Write("First Name  : ");
                        string name = Console.ReadLine();
                        sr.WriteLine(name);
                        Console.WriteLine("Enter Last Name");
                        sr.Write("Last Name  : ");
                        string lname = Console.ReadLine();
                        sr.WriteLine(lname);
                      
                        sr.Close();
                        Console.WriteLine(File.ReadAllText(path));
                    }
                }

                else
                {
                    throw new AddressBookException(AddressBookException.ExceptionType.FILE_NOT_EXIST, "File Not Exists");

                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
    }


        public static void ReadFromCSVReader()
        {
            string importFilePath = "E:\\AddressBook\\AddressBookSystem\\AddressBookSystem\\AddressBookSystem\\ContactData.csv";
            string exportFilePath = "E:\\AddressBook\\AddressBookSystem\\AddressBookSystem\\AddressBookSystem\\exportData.csv";

            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Contact>().ToList();
                Console.WriteLine("Read data successfully from contaceData csv.");
                foreach (Contact contactData in records)
                { 
                    Console.Write("\t" + contactData.first_name);
                    Console.Write("\t" + contactData.last_name);
                    Console.Write("\t" + contactData.address);
                    Console.Write("\t" + contactData.city);
                    Console.Write("\t" + contactData.state);
                    Console.Write("\t" + contactData.zip);
                    Console.Write("\t" + contactData.phone_number);
                    Console.Write("\t" + contactData.email);
                    Console.WriteLine();
                    Console.WriteLine("*******************************Readin from csv file and Write to csv file **********************************");
                    //Writing csv file

                    using (var writer = new StreamWriter(exportFilePath))
                    using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        csvExport.WriteRecords(records);
                    }
                }
            }
        }



    }





}

