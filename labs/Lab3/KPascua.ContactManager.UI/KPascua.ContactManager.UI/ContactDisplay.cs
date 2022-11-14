using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic.Devices;

namespace KPascua.ContactManager.UI
{
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
            var movie = GetSelectedContact();
            if (movie == null)
                return;

            if (!Confirm($"Are you sure you want to delete '{contact.Title}'?", "Delete"))
                return;

            _contacts.Remove(movie.Id);
            UpdateUI();
        }

        private void OnMovieEdit ( object sender, EventArgs e )
        {
            var movie = GetSelectedContact();
            if (movie == null)
                return;

            var child = new ContactEntry();
            child.SelectedContact = movie;

            do
            {
                if (child.ShowDialog(this) != DialogResult.OK)
                    return;

                if (_contacts.Update(contact.Id, child.SelectedMovie, out var error))
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

            //Extension methods - static methods on static classes
            // 1. Expose a static method as an instance method for discoverability
            // 2. Called like instance methods (on an instance)
            // 3. Compiler rewrites code to call static method on static class
            //Enumerable.Count(movies) == movies.Count()            
            if (initialLoad &&
                    //movies.Count() == 0)
                    //movies.FirstOrDefault() == null)            
                    contacts.Any())
            {
                if (Confirm("Do you want to seed some movies?", "Database Empty"))
                {
                    //SeedMovieDatabase.Seed(_movies);
                    _contacts.Seed();
                    contacts = _contacts.GetAll();
                };
            };

            _lstContacts.Items.Clear();

            //Func<Movie, string> someFunc = OrderByTitle;
            //var someResult = someFunc(new Movie());

            //Order movies by title, then by release year
            //Chain calls together
            //          movies.OrderBy(OrderByTitle());
            //  foreach item in source
            //      sortValue = func(item)
            //      compare sortValue to other values
            //var items = movies.OrderBy(OrderByTitle)
            //               .ThenBy(OrderByReleaseYear)
            var items = contacts.OrderBy(x => x.Title)
                              .ThenBy(x => x.ReleaseYear)
                              .ToArray();
            //movies = movies.ThenBy();

            //Use Enumerable 
            //_lstMovies.Items.AddRange(Enumerable.ToArray(movies));
            _lstContacts.Items.AddRange(items);
            //foreach (var movie in movies)
            //    _lstMovies.Items.Add(movie);
        }
        //private string OrderByTitle ( Movie movie )  //Func<Movie, string>
        //{
        //    return movie.Title;
        //}
        //private int OrderByReleaseYear ( Movie movie )  //Func<Movie, int>
        //{
        //    return movie.ReleaseYear;
        //}

        private Contact GetSelectedMovie ()
        {
            //var allTextBoxes = Controls.OfType<TextBox>();
            //IEnumerable<Movie> temp = _lstMovies.SelectedItems.OfType<Movie>();

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

        private IContactDatabase _contacts = new Memory.MemoryMovieDatabase();
    }
}
