using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ContactDatabase;

using Microsoft.VisualBasic.Devices;

namespace KPascua.ContactManager.UI;

public partial class ContactDisplay : Form
{
    public ContactDisplay ()
    {
        InitializeComponent();
    }

    protected override void OnFormClosing ( FormClosingEventArgs e )
    {
        base.OnFormClosing(e);

        if (Confirm("Are you sure you want to leave?", "Close"))
            return;

        e.Cancel = true;
    }

    protected override void OnFormClosed ( FormClosedEventArgs e )
    {
        base.OnFormClosed(e);
    }

    protected override void OnLoad ( EventArgs e )
    {
        base.OnLoad(e);

        UpdateUI(true);
    }

    private void OnContactAdd ( object sender, EventArgs e )
    {
        var child = new ContactEntry();

        do
        {
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            if (_contacts.Add(child.SelectedContact, out var error) != null)
            {
                UpdateUI();
                return;
            };

            DisplayError(error, "Add Failed");
        } while (true);
    }

    private void OnContactDelete ( object sender, EventArgs e )
    {
        var contact = GetSelectedContact();
        if (contact == null)
            return;

        if (!Confirm($"Are you sure you want to delete '{contact.LastName}'?", "Delete"))
            return;

        _contacts.Remove(contact.Id);
        UpdateUI();
    }

    private void OnContactEdit ( object sender, EventArgs e )
    {
        var contact = GetSelectedContact();
        if (contact == null)
            return;

        var child = new ContactEntry();
        child.SelectedContact = contact;

        do
        {
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            if (_contacts.Update(contact.Id, child.SelectedContact, out var error))
            {
                UpdateUI();
                return;
            };

            DisplayError(error, "Update Failed");
        } while (true);
    }

    private void OnFileExit ( object sender, EventArgs e )
    {
        Close();
    }

    private void OnHelpAbout ( object sender, EventArgs e )
    {
        var about = new AboutForm();

        about.ShowDialog();
    }

    private void UpdateUI ()
    {
        UpdateUI(false);
    }

    private void UpdateUI ( bool initialLoad )
    {
        var contacts = _contacts.GetAll();

        if (initialLoad && contacts.Any())
        {
            if (Confirm("Do you want to seed some movies?", "Database Empty"))
            {
                _contacts.Seed();
                contacts = _contacts.GetAll();
            };
        };

        _lstContacts.Items.Clear();

        var items = contacts.OrderBy(x => x.LastName)
                          .ThenBy(x => x.FirstName)
                          .ToArray();
      
        _lstContacts.Items.AddRange(items);
       
    }
    
    private Contact GetSelectedContact ()
    { 
        return _lstContacts.SelectedItem as Contact;
    }

    private bool Confirm ( string message, string title )
    {
        DialogResult result = MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        return result == DialogResult.Yes;
    }

    private void DisplayError ( string message, string title )
    {
        MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private IContactDatabase _contacts = new ContactDatabase.Memory.MemoryContactDatabase();
}
