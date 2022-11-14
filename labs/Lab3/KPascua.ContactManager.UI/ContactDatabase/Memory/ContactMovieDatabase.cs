using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDatabase.Memory
{
    public class MemoryContactDatabase : ContactDatabase
    {
        protected override Contact AddCore ( Contact contact )
        {
            contact.Id = _id++;
            _contacts.Add(contact.Clone());

            return contact;
        }

        protected override Contact GetCore ( int id )
        {
            return _contacts.FirstOrDefault(x => x.Id == id)?.Clone();
        }

        protected override IEnumerable<Contact> GetAllCore ()
        {
           
            return from contact in _contacts
                   orderby contact.LastName, contact.FirstName
                   select contact.Clone();
        }

        
        protected override void RemoveCore ( int id )
        {
            var movie = FindById(id);
            _contacts.Remove(movie);
          
        }

        protected override void UpdateCore ( int id, Contact movie )
        {
            var oldContact = FindById(id);
            movie.CopyTo(oldContact);
            oldContact.Id = id;
        }

       
        protected override Contact FindByTitle ( string title )
        {
            return _contacts.FirstOrDefault(
                        x => String.Equals(x.LastName, title, StringComparison.OrdinalIgnoreCase));
        }

        #region Private Members

       
        private Contact FindById ( int id )
        {
        
            return _contacts.FirstOrDefault(x => x.Id == id);

        }
     
        private int _id = 1;

        private List<Contact> _contacts = new List<Contact>();
        #endregion
    }
}
