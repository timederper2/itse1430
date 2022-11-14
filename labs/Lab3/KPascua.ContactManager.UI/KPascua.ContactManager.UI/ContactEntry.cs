using ContactDatabase;
using System.ComponentModel;

namespace KPascua.ContactManager.UI
{
    public partial class ContactEntry : Form
    {
        public ContactEntry ()
        {
            InitializeComponent();
        }

        /// <summary>Gets or sets the movie being edited.</summary>
        public Contact SelectedContact { get; set; }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            //Do any init just before UI is rendered
            if (SelectedContact != null)
            {
                //Load UI
                _txtFirstName.Text = SelectedContact.FirstName;
                _txtLastName.Text = SelectedContact.LastName;
                _chkFavoriteContact.Checked = SelectedContact.IsFavorite;
                _txtEmail.Text = SelectedContact.Email;
                _txtNotes.Text = SelectedContact.Notes;
            };

            //Force validation
            ValidateChildren();
        }

        private void OnSave ( object sender, EventArgs e )
        {
            //Force validation of children
            if (!ValidateChildren())
                return;

            var btn = sender as Button;

            var contact = new Contact();
            contact.FirstName = _txtFirstName.Text;
            contact.LastName = _txtLastName.Text;
            contact.IsFavorite = _chkFavoriteContact.Checked;
            contact.Email = _txtEmail.Text;
            contact.Notes = _txtNotes.Text;

            //var validator = new ObjectValidator();            
            //if (!movie.Validate(out var error))
            //if (!new ObjectValidator().IsValid(movie, out var error))
            if (!ObjectValidator.IsValid(contact, out var error))
            {
                DisplayError(error, "Save");
                return;
            };

            //Get rid of form by
            // setting Form's DialogResult to a reasonable value
            // Call Close()
            SelectedContact = contact;
            DialogResult = DialogResult.OK;
            Close();
        }

        #region Private Members

        private void DisplayError ( string message, string title )
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        private void OnValidateTitle ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                //Not valid
                _errors.SetError(control, "Title is required");
                e.Cancel = true;
            } else
            {
                //Valid
                _errors.SetError(control, "");
            };
        }

        private void OnValidateRating ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                //Not valid
                _errors.SetError(control, "Rating is required");
                e.Cancel = true;
            } else
            {
                //Valid
                _errors.SetError(control, "");
            };
        }

    }
}