using System.ComponentModel;

using ContactDatabase;

namespace KPascua.ContactManager.UI
{
    public partial class ContactEntry : Form
    {
        public ContactEntry ()
        {
            InitializeComponent();
        }

        public Contact SelectedContact { get; set; }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            if (SelectedContact != null)
            {
                _txtLastName.Text = SelectedContact.LastName;
                _txtFirstName.Text = SelectedContact.FirstName;
                _chkFavoriteContact.Checked = SelectedContact.IsFavorite;
                _txtEmail.Text = SelectedContact.Email;
                _txtNotes.Text = SelectedContact.Notes;
            }

            ValidateChildren();
        }

        private void OnSave ( object sender, EventArgs e )
        {

            if (!ValidateChildren())
                return;

            var btn = sender as Button;

            var contact = new Contact();
            contact.FirstName = _txtFirstName.Text;
            contact.LastName = _txtLastName.Text;
            contact.IsFavorite = _chkFavoriteContact.Checked;
            contact.Email = _txtEmail.Text;
            contact.Notes = _txtNotes.Text;

            if (!ObjectValidator.IsValid(contact, out var error))
            {
                DisplayError(error, "Save");
                return;
            };

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

        private void OnValidateLast ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {

                _errors.SetError(control, "Last Name is required");
                e.Cancel = true;
            } else
            {

                _errors.SetError(control, "");
            };
        }

        private void OnValidateEmail ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Email is required");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            };
        }

        bool IsValidEmail ( string source )
        {
            return System.Net.Mail.MailAddress.TryCreate(source, out var address);
        }
    }
}