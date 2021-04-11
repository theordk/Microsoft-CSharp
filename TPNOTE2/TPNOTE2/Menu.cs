﻿using System;
using System.Windows.Forms;

namespace TPNOTE2
{
    public partial class Menu : Form
    {
        

        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Listener of "Gestion des Etudiants"  open corresponding Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gestionDesEtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create the Form
            Gestion_Etudiants gestionEtudiantsForm = new Gestion_Etudiants();

            // Set the Parent Form of the "Gestion Etudiant" window.
            gestionEtudiantsForm.MdiParent = this;

            //Hide current Form
            //this.Hide();

            // Display the Form
            gestionEtudiantsForm.Show();
        }

        /// <summary>
        /// Listener of "Gestion des Notes"  open corresponding Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gestionDesNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create the Form
            Gestion_Notes gestionNotesForm = new Gestion_Notes();

            // Set the Parent Form of the "Gestion des Notes" window.
            gestionNotesForm.MdiParent = this;

            //Hide current Form
            //this.Hide();

            // Display the Form
            gestionNotesForm.Show();
        }

        /// <summary>
        /// Listener of "Consultation"  open corresponding Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_Consultation_Click(object sender, EventArgs e)
        {
            // Create the Form
            Consultation consultationForm = new Consultation();

            // Set the Parent Form of the "Gestion des Notes" window.
            consultationForm.MdiParent = this;

            //Hide current Form
            //this.Hide();

            // Display the Form
            consultationForm.Show();
        }

        /// <summary>
        /// Quit the Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
