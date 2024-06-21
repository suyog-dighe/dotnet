using System;

namespace inheritance
{
    // Single Inheritance Example
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("Book Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Pages: " + Pages);
        }
    }

    class EBook : Book, IDigital
    {
        public string Format { get; set; } // e.g., PDF, EPUB, MOBI
        public double FileSize { get; set; } // in MB

        public void DisplayEBookDetails()
        {
            DisplayDetails();
            Console.WriteLine("Format: " + Format);
            Console.WriteLine("File Size: " + FileSize + " MB");
        }

        public void DisplayDigitalDetails()
        {
            Console.WriteLine("This is a digital content in " + Format + " format.");
        }
    }

    // Multilevel Inheritance Example
    class Location
    {
        public string Country { get; set; }

        public void ShowCountry()
        {
            Console.WriteLine("Country: " + Country);
        }
    }

    class City : Location
    {
        public string CityName { get; set; }

        public void ShowCityName()
        {
            Console.WriteLine("City: " + CityName);
        }
    }

    class CapitalCity : City
    {
        public string CapitalStatus { get; set; }

        public void ShowCapitalStatus()
        {
            ShowCountry();
            ShowCityName();
            Console.WriteLine("Status: " + CapitalStatus);
        }
    }

    // Hierarchical Inheritance Example
    class Algorithm
    {
        public string Name { get; set; }
        public string Complexity { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("Algorithm Name: " + Name);
            Console.WriteLine("Complexity: " + Complexity);
        }
    }

    class SortingAlgorithm : Algorithm
    {
        public string SortType { get; set; }

        public void DisplaySortingDetails()
        {
            DisplayDetails();
            Console.WriteLine("Sort Type: " + SortType);
        }
    }

    // Hybrid Inheritance Example
    interface IDigital
    {
        void DisplayDigitalDetails();
    }

    class DigitalContent : IDigital
    {
        public string ContentName { get; set; }
        public string Format { get; set; }

        public void DisplayDigitalDetails()
        {
            Console.WriteLine("Digital Content: " + ContentName);
            Console.WriteLine("Format: " + Format);
        }
    }

    // Multiple Inheritance using Interfaces Example
    interface IReadable
    {
        void Read();
    }

    class DigitalBook : EBook, IReadable
    {
        public void Read()
        {
            Console.WriteLine("Reading the digital book: " + Title);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Inheritance Example:");
            EBook myEBook = new EBook
            {
                Title = "C# Programming",
                Author = "John Doe",
                Pages = 350,
                Format = "PDF",
                FileSize = 5.5
            };
            myEBook.DisplayEBookDetails();
            Console.WriteLine();

            Console.WriteLine("Multilevel Inheritance Example:");
            CapitalCity paris = new CapitalCity
            {
                Country = "France",
                CityName = "Paris",
                CapitalStatus = "Capital City"
            };
            paris.ShowCapitalStatus();
            Console.WriteLine();

            Console.WriteLine("Hierarchical Inheritance Example:");
            SortingAlgorithm quickSort = new SortingAlgorithm
            {
                Name = "Quick Sort",
                Complexity = "O(n log n)",
                SortType = "Divide and Conquer"
            };
            quickSort.DisplaySortingDetails();
            Console.WriteLine();

            Console.WriteLine("Hybrid Inheritance Example:");
            DigitalContent music = new DigitalContent
            {
                ContentName = "Music Album",
                Format = "MP3"
            };
            music.DisplayDigitalDetails();
            Console.WriteLine();

            // Hybrid Inheritance with EBook
            Console.WriteLine("Hybrid Inheritance with EBook:");
            myEBook.DisplayDigitalDetails();
            Console.WriteLine();

            // Multiple Inheritance using Interfaces
            Console.WriteLine("Multiple Inheritance using Interfaces Example:");
            DigitalBook digitalBook = new DigitalBook
            {
                Title = "Advanced C#",
                Author = "Jane Smith",
                Pages = 500,
                Format = "EPUB",
                FileSize = 3.2
            };
            digitalBook.DisplayEBookDetails();
            digitalBook.Read();

            Console.ReadKey();
        }
    }
}
