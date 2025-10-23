using System;
using System.Collections.Generic;

namespace PrinterQueueApp
{
    class Program
    {
        static Queue<string> printerQueue = new Queue<string>();

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("===== Printer Queue Menu =====");
                Console.WriteLine("1. Add Document to Queue");
                Console.WriteLine("2. Print Next Document");
                Console.WriteLine("3. Print All Documents");
                Console.WriteLine("4. Show Queue Status");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        AddDocument();
                        break;

                    case "2":
                        PrintNextDocument();
                        break;

                    case "3":
                        PrintAllDocuments();
                        break;

                    case "4":
                        ShowQueueStatus();
                        break;

                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting Printer Queue Application.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select between 1 and 5.\n");
                        break;
                }
            }
        }

        static void AddDocument()
        {
            Console.Write("Enter document name to add to queue: ");
            string docName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(docName))
            {
                Console.WriteLine("Document name cannot be empty.\n");
                return;
            }
            printerQueue.Enqueue(docName);
            Console.WriteLine($"Document \"{docName}\" added to the queue.\n");
        }

        static void PrintNextDocument()
        {
            if (printerQueue.Count == 0)
            {
                Console.WriteLine("Printer queue is empty. No documents to print.\n");
                return;
            }

            string doc = printerQueue.Dequeue();
            Console.WriteLine($"Printing document: \"{doc}\" ... Done.\n");
        }

        static void PrintAllDocuments()
        {
            if (printerQueue.Count == 0)
            {
                Console.WriteLine("Printer queue is empty. No documents to print.\n");
                return;
            }

            Console.WriteLine("Printing all documents in the queue:");
            while (printerQueue.Count > 0)
            {
                string doc = printerQueue.Dequeue();
                Console.WriteLine($"Printing document: \"{doc}\" ... Done.");
            }
            Console.WriteLine();
        }

        static void ShowQueueStatus()
        {
            if (printerQueue.Count == 0)
            {
                Console.WriteLine("Printer queue is empty.\n");
                return;
            }

            Console.WriteLine("Documents currently in the printer queue:");
            foreach (var doc in printerQueue)
            {
                Console.WriteLine($"- {doc}");
            }
            Console.WriteLine();
        }
    }
}
