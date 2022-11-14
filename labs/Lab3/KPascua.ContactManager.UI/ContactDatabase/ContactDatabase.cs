using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDatabase
{
    public abstract class ContactDatabase : IContactDatabase
    {
        
        public Contact Add ( Contact contact, out string errorMessage )
        {
            
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

           
            if (!ObjectValidator.IsValid(contact, out errorMessage))
                return null;

            var existing = FindByTitle(contact.LastName);
            if (existing != null)
            {
                errorMessage = "Movie must be unique";
                return null;
            };

            
            contact = AddCore(contact);

            errorMessage = null;
            return contact;
        }

          
        public Contact Get ( int id )
        {
            //TODO: Error
            if (id <= 0)
                return null;

            return GetCore(id);
        }

                      
        public IEnumerable<Contact> GetAll ()
        {
            return GetAllCore();
        }

               
        public void Remove ( int id )
        {
            if (id <= 0)
                return;

            RemoveCore(id);
        }
    
        public bool Update ( int id, Contact contact, out string errorMessage )
        {
            //Validate movie
            if (contact == null)
            {
                errorMessage = "Contact cannot be null";
                return false;
            };

            if (!ObjectValidator.IsValid(contact, out errorMessage))
                return false;

            //Movie must already exist
            var oldContact = GetCore(id);
            if (oldContact == null)
            {
                errorMessage = "Contact does not exist";
                return false;
            };

            //Must be unique
            var existing = FindByTitle(contact.LastName);
            if (existing != null && existing.Id != id)
            {
                errorMessage = "Contact must be unique";
                return false;
            };

            UpdateCore(id, contact);

            errorMessage = null;
            return true;
        }

        
        protected abstract Contact AddCore ( Contact contact );

       
        protected abstract Contact GetCore ( int id );

        protected abstract IEnumerable<Contact> GetAllCore();

        
        protected abstract void RemoveCore ( int id );

        
        protected abstract void UpdateCore ( int id, Contact contact );

        protected abstract Contact FindByTitle ( string lastName );
    }
}
