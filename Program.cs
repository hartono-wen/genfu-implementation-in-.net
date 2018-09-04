/*
 * This project is to show how to use GenFu to generate dummy data.
 * GenFu home page: http://genfu.io/
 * GitHub of GenFu: https://github.com/MisterJames/GenFu/
 * Credit belongs to the creators of GenFu.
 * I merely try to give a simple example of GenFu usage since I think this is a quick way to generate dummy data.
 */

using System;
using System.Linq;

namespace GenFuUsageSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = GenFu.GenFu.ListOf<Contact>();
            foreach (var contact in contacts.OrderBy(x => x.Id))
            {
                Console.WriteLine(contact.ToString());
            }

            Console.WriteLine(string.Empty);

            var books = GenFu.GenFu.ListOf<Book>();
            foreach (var book in books)
            {
                Console.WriteLine(book.ToString());
            }

            Console.ReadLine();
        }
    }

    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{Id}: {FirstName} {LastName} - {EmailAddress} - {PhoneNumber}";
        }
    }

    public class Book
    {
        public Guid Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }

        public override string ToString()
        {
            return $"{Id}: {ISBN} - {Title} by {AuthorName}";
        }
    }


}
