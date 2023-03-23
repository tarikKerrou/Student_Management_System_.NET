using GestionEtudiant.DSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEtudiant
{
    public partial class Form1 : Form

    {
        StudentTableAdapter ada = new StudentTableAdapter();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grd.DataSource = ada.GetData();
        }

        private void btnajt_Click(object sender, EventArgs e)
        {
            string name = textname.Text;

            int age = int.Parse(textage.Text);
            ada.Insert(name, age);
            // Vider les zones de texte
            textname.Text = "";
            textage.Text = "";


            grd.DataSource = ada.GetData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textname.Text;

            int age = int.Parse(textage.Text);
            ada.Insert(name, age);
            // Vider les zones de texte
            textname.Text = "";
            textage.Text = "";


            grd.DataSource = ada.GetData();
        }

        private void age_Click(object sender, EventArgs e)
        {

        }

        private void btnsup_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée
            if (grd.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de la ligne sélectionnée
                int Id = Convert.ToInt32(grd.SelectedRows[0].Cells["Id"].Value);
                string nom = Convert.ToString(grd.SelectedRows[0].Cells["name"].Value);
                int age = Convert.ToInt32(grd.SelectedRows[0].Cells["age"].Value);

                // Supprimer la ligne de la table
                ada.Delete(Id, nom, age);

                // Rafraîchir la grille de données
                grd.DataSource = ada.GetData();
            }
        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (grd.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de la ligne sélectionnée
                int Id = Convert.ToInt32(grd.SelectedRows[0].Cells["Id"].Value);
                string nom = Convert.ToString(grd.SelectedRows[0].Cells["name"].Value);
                int age = Convert.ToInt32(grd.SelectedRows[0].Cells["age"].Value);



                textname.Text = nom;
                textage.Text = age.ToString();
            }
        }

        private void textage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
