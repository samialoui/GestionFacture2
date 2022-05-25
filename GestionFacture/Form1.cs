using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionFacture
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
         
        }
        Facture facture = new Facture();

        private void button1_Click(object sender, EventArgs e)
        {
            string prix = txtPrixUnitaire.Text;
            string quantite = txtQuantite.Text;
            Double montant = facture.CalculMontant(prix, quantite);
            txtMontant.Text = montant.ToString();
            
        }

        private void txtDesignation_TextChanged(object sender, EventArgs e)
        {
            if(txtDesignation.Text == "" || txtPrixUnitaire.Text =="" || txtQuantite.Text == "")
            {
                btnCalculMontant.Enabled = false;
            }
            else
            {
                btnCalculMontant.Enabled = true;
            }
        }

        private void txtPrixUnitaire_TextChanged(object sender, EventArgs e)
        {
            if (txtDesignation.Text == "" || txtPrixUnitaire.Text == "" || txtQuantite.Text == "")
            {
                btnCalculMontant.Enabled = false;
            }
            else
            {
                btnCalculMontant.Enabled = true;
            }
        }

        private void txtQuantite_TextChanged(object sender, EventArgs e)
        {
            if (txtDesignation.Text == "" || txtPrixUnitaire.Text == "" || txtQuantite.Text == "")
            {
                btnCalculMontant.Enabled = false;
            }
            else
            {
                btnCalculMontant.Enabled = true;
            }
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            txtDesignation.Text = "";
            txtPrixUnitaire.Text = "";
            txtQuantite.Text = "";
            txtMontant.Text = "";
            txtTotalHt.Text = "";
            txtTotalTTC.Text = "";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            /* listFacture.Items.Add(txtDesignation.Text.ToString() + "       " + txtPrixUnitaire.Text.ToString() +
                 "           " + txtQuantite.Text.ToString() + "      " + txtMontant.Text.ToString());*/

            facture.Designation = txtDesignation.Text;
            facture.PrixUnitaire = txtPrixUnitaire.Text;
            facture.Quantite = txtQuantite.Text;
            facture.Montant = txtMontant.Text;

            bool success = facture.Insert(facture);
            if(success == true)
            {
                MessageBox.Show("Facture a été ajoutée avec succée");
                //videText();
            }
            else
            {
                MessageBox.Show("Ereur, Réessayer autre foix");
            }
            DataTable dt = facture.Select();
            dataGridView1.DataSource = dt;
            //listFacture.items.Add(dt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = facture.Select();
            dataGridView1.DataSource = dt;
            //listFacture.items.Add(dt);

        }

        public void videText()
        {
            txtDesignation.Text = "";
            txtPrixUnitaire.Text = "";
            txtQuantite.Text = "";
            txtMontant.Text = "";
        }
        
        private void btnCalculTTC_Click(object sender, EventArgs e)
        {
            string totalHT = facture.CalculTotHT();
            //double valTotalTTC = totalHT * 1.118;
            txtTotalTTC.Text = facture.CalculTotHT();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
