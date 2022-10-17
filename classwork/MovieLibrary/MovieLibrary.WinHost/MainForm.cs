﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();
        }

        private void OnMovieAdd ( object sender, EventArgs e )
        {
            var child = new MovieForm();

            //Showing form modally
            if (child.ShowDialog() !=
                    DialogResult.OK)
                return;
            //child.Show();

            //TODO: Save this off
            var movie = child.SelectedMovie;
        }

        private bool Confirm ( string message, string title )
        {
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return result == DialogResult.Yes;
        }

        private void DisplayError ( string message, string title )
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _miMovieDelete_Click ( object sender, EventArgs e )
        {
            if (!Confirm("Are you sure you want to delete the movie?", "Delete"))
                return;

            //TODO: Implement
            DisplayError("Not implemented yet", "Delete");
        }
    }
}