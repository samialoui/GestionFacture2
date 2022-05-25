
namespace GestionFacture
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtDesignat = new System.Windows.Forms.Label();
            this.txtMontantHt = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.Label();
            this.txtPrixUnitaire = new System.Windows.Forms.TextBox();
            this.btnCalculMontant = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnCalculTTC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalHt = new System.Windows.Forms.TextBox();
            this.txtTot = new System.Windows.Forms.Label();
            this.txtTotalTTC = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(216, 67);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(151, 20);
            this.txtDesignation.TabIndex = 1;
            this.txtDesignation.TextChanged += new System.EventHandler(this.txtDesignation_TextChanged);
            // 
            // txtDesignat
            // 
            this.txtDesignat.AutoSize = true;
            this.txtDesignat.Location = new System.Drawing.Point(130, 74);
            this.txtDesignat.Name = "txtDesignat";
            this.txtDesignat.Size = new System.Drawing.Size(63, 13);
            this.txtDesignat.TabIndex = 2;
            this.txtDesignat.Text = "Designation";
            // 
            // txtMontantHt
            // 
            this.txtMontantHt.AutoSize = true;
            this.txtMontantHt.Location = new System.Drawing.Point(130, 235);
            this.txtMontantHt.Name = "txtMontantHt";
            this.txtMontantHt.Size = new System.Drawing.Size(64, 13);
            this.txtMontantHt.TabIndex = 4;
            this.txtMontantHt.Text = "Montant HT";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(216, 228);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.ReadOnly = true;
            this.txtMontant.Size = new System.Drawing.Size(151, 20);
            this.txtMontant.TabIndex = 3;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(130, 174);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(47, 13);
            this.txt.TabIndex = 6;
            this.txt.Text = "Quantité";
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(216, 167);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(151, 20);
            this.txtQuantite.TabIndex = 5;
            this.txtQuantite.TextChanged += new System.EventHandler(this.txtQuantite_TextChanged);
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(130, 126);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(63, 13);
            this.t.TabIndex = 8;
            this.t.Text = "Prix Unitaire";
            // 
            // txtPrixUnitaire
            // 
            this.txtPrixUnitaire.Location = new System.Drawing.Point(216, 119);
            this.txtPrixUnitaire.Name = "txtPrixUnitaire";
            this.txtPrixUnitaire.Size = new System.Drawing.Size(151, 20);
            this.txtPrixUnitaire.TabIndex = 7;
            this.txtPrixUnitaire.TextChanged += new System.EventHandler(this.txtPrixUnitaire_TextChanged);
            // 
            // btnCalculMontant
            // 
            this.btnCalculMontant.Location = new System.Drawing.Point(216, 283);
            this.btnCalculMontant.Name = "btnCalculMontant";
            this.btnCalculMontant.Size = new System.Drawing.Size(151, 23);
            this.btnCalculMontant.TabIndex = 9;
            this.btnCalculMontant.Text = "Calculer";
            this.btnCalculMontant.UseVisualStyleBackColor = true;
            this.btnCalculMontant.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Location = new System.Drawing.Point(216, 364);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(151, 23);
            this.btnReinitialiser.TabIndex = 10;
            this.btnReinitialiser.Text = "Réinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = true;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(216, 324);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(151, 23);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnCalculTTC
            // 
            this.btnCalculTTC.Location = new System.Drawing.Point(409, 364);
            this.btnCalculTTC.Name = "btnCalculTTC";
            this.btnCalculTTC.Size = new System.Drawing.Size(321, 23);
            this.btnCalculTTC.TabIndex = 12;
            this.btnCalculTTC.Text = "Calculer";
            this.btnCalculTTC.UseVisualStyleBackColor = true;
            this.btnCalculTTC.Click += new System.EventHandler(this.btnCalculTTC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total HT";
            // 
            // txtTotalHt
            // 
            this.txtTotalHt.Location = new System.Drawing.Point(510, 286);
            this.txtTotalHt.Name = "txtTotalHt";
            this.txtTotalHt.ReadOnly = true;
            this.txtTotalHt.Size = new System.Drawing.Size(220, 20);
            this.txtTotalHt.TabIndex = 15;
            // 
            // txtTot
            // 
            this.txtTot.AutoSize = true;
            this.txtTot.Location = new System.Drawing.Point(406, 329);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(55, 13);
            this.txtTot.TabIndex = 18;
            this.txtTot.Text = "Total TTC";
            // 
            // txtTotalTTC
            // 
            this.txtTotalTTC.Location = new System.Drawing.Point(510, 324);
            this.txtTotalTTC.Name = "txtTotalTTC";
            this.txtTotalTTC.ReadOnly = true;
            this.txtTotalTTC.Size = new System.Drawing.Size(220, 20);
            this.txtTotalTTC.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(409, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 53);
            this.dataGridView1.TabIndex = 19;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(486, 144);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 20;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.txtTotalTTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalHt);
            this.Controls.Add(this.btnCalculTTC);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.btnCalculMontant);
            this.Controls.Add(this.t);
            this.Controls.Add(this.txtPrixUnitaire);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.txtMontantHt);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.txtDesignat);
            this.Controls.Add(this.txtDesignation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label txtDesignat;
        private System.Windows.Forms.Label txtMontantHt;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.TextBox txtPrixUnitaire;
        private System.Windows.Forms.Button btnCalculMontant;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnCalculTTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalHt;
        private System.Windows.Forms.Label txtTot;
        private System.Windows.Forms.TextBox txtTotalTTC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

