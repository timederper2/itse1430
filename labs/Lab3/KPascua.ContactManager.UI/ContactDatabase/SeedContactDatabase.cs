using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDatabase
{
    public static class MovieDatabaseExtensions
    {   public static void Seed ( this IContactDatabase database )
        {
            var contacts = new Contact[] {
                new Contact() {
                    LastName = "Daba",
                    FirstName = "Dee",
                    Email = "waddyanaw@gmail.com",
                    Notes = "Good bait supply",
                    IsFavorite = true,
                },
                new Contact() {
                    LastName = "Dee",
                    FirstName = "Daba",
                    Email = "waddyanaw333@gmail.com",
                    Notes = "Good hook supply",
                    IsFavorite = false,
                },
                new Contact() {
                    LastName = "Storm",
                    FirstName = "Hashery",
                    Email = "potatotomato@gmail.com",
                    Notes = "Unreliable, but worth it",
                    IsFavorite = false,
                }
            };
            foreach (var contact in contacts)
                database.Add(contact, out var error);
        }
    }
}
