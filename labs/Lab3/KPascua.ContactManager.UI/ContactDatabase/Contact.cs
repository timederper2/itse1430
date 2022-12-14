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

        public Contact ( string lastName, string email ) : base()
        {
            LastName = lastName;
            Email = email;
        }
        public Contact ( int id, string firstName, string lastName, string email, string notes, bool isFavorite )
        {
            Id=id;
            _firstName=firstName;
            _lastName=lastName;
            _email=email;
            _notes=notes;
            IsFavorite=isFavorite;
        }

        public int Id { get; set; }
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
                errors.Add(new ValidationResult("Last Name is required", new[] { nameof(LastName) }));

            if (Email.Length == 0)
                errors.Add(new ValidationResult("Email is required", new[] { nameof(Email) }));

            return errors;
        }
    }
}