using System.ComponentModel.DataAnnotations;

namespace ContactDatabase
{
    public class Contact : IValidatableObject
    {
        public Contact () : this("", "")
        {

        }
        public Contact ( string name ) : this(name, "")
        {

        }

        public Contact ( string firstName, string notes ) : base()
        {
            FirstName = firstName;
            Notes = notes;
        }
        public int Id { get; private set; }
        public string FirstName
        {
            get => _firstName ?? "";
            set => _firstName = value?.Trim() ?? "";
        }
        private string _firstName;
        public string LastName
        {
            get { return _lastName ?? ""; }
            set { _lastName = value?.Trim() ?? ""; }
        }
        private string _lastName;
        public string Email
        {
            get { return _email ?? ""; }
            set { _email = value?.Trim() ?? ""; }
        }
        private string _email;

        public string Notes
        {
            get { return _notes ?? ""; }
            set { _notes = value?.Trim() ?? ""; }
        }
        private string _notes;

        public bool IsFavorite { get; set; }

        public Contact Clone ()
        {
            var contact = new Contact();
            CopyTo(contact);

            return contact;
        }

        public void CopyTo ( Contact contact )
        {
            contact.FirstName = FirstName;
            contact.LastName = LastName;
            contact.Email = Email;
            contact.Notes = Notes;
            contact.IsFavorite = IsFavorite;
        }


        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            var errors = new List<ValidationResult>();

            if (LastName.Length == 0)
                errors.Add(new ValidationResult("Title is required", new[] { nameof(LastName) }));

            if (Email.Length == 0)
                errors.Add(new ValidationResult("Rating is required", new[] { nameof(Email) }));

            return errors;
        }
    }
}