namespace PhotoAlbumGenerator
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTitre = new System.Windows.Forms.TextBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDate = new System.Windows.Forms.TextBox();
            this.tbxDateYYYYMMDD = new System.Windows.Forms.TextBox();
            this.cbxCategorie = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxFichiers = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxSuivantNom = new System.Windows.Forms.TextBox();
            this.tbxSuivantTitre = new System.Windows.Forms.TextBox();
            this.tbxPrecedantNom = new System.Windows.Forms.TextBox();
            this.tbxPrecedantTitre = new System.Windows.Forms.TextBox();
            this.tbxRecommande3 = new System.Windows.Forms.TextBox();
            this.tbxRecommande2 = new System.Windows.Forms.TextBox();
            this.tbxRecommande1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxRecommande1Nom = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxRecommande2Nom = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxRecommande3Nom = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Créer la page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom de la page";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "HTML text";
            // 
            // tbxTitre
            // 
            this.tbxTitre.Location = new System.Drawing.Point(96, 6);
            this.tbxTitre.Name = "tbxTitre";
            this.tbxTitre.Size = new System.Drawing.Size(353, 20);
            this.tbxTitre.TabIndex = 4;
            this.tbxTitre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxTitre_KeyUp);
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(96, 32);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(353, 20);
            this.tbxNom.TabIndex = 5;
            // 
            // tbxText
            // 
            this.tbxText.Location = new System.Drawing.Point(96, 60);
            this.tbxText.Name = "tbxText";
            this.tbxText.Size = new System.Drawing.Size(353, 378);
            this.tbxText.TabIndex = 6;
            this.tbxText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date (30 janvier 2020)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date (2020-01-30)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Catégorie";
            // 
            // tbxDate
            // 
            this.tbxDate.Location = new System.Drawing.Point(584, 6);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.Size = new System.Drawing.Size(204, 20);
            this.tbxDate.TabIndex = 10;
            // 
            // tbxDateYYYYMMDD
            // 
            this.tbxDateYYYYMMDD.Location = new System.Drawing.Point(584, 32);
            this.tbxDateYYYYMMDD.Name = "tbxDateYYYYMMDD";
            this.tbxDateYYYYMMDD.Size = new System.Drawing.Size(204, 20);
            this.tbxDateYYYYMMDD.TabIndex = 11;
            // 
            // cbxCategorie
            // 
            this.cbxCategorie.FormattingEnabled = true;
            this.cbxCategorie.Items.AddRange(new object[] {
            "événement",
            "portrait",
            "paysage",
            "nature",
            "street",
            "divers"});
            this.cbxCategorie.Location = new System.Drawing.Point(584, 58);
            this.cbxCategorie.Name = "cbxCategorie";
            this.cbxCategorie.Size = new System.Drawing.Size(204, 21);
            this.cbxCategorie.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fichiers";
            // 
            // tbxFichiers
            // 
            this.tbxFichiers.Location = new System.Drawing.Point(584, 87);
            this.tbxFichiers.Name = "tbxFichiers";
            this.tbxFichiers.Size = new System.Drawing.Size(204, 20);
            this.tbxFichiers.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Album suivant";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(466, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Album-suivant";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(466, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Album-précédant";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(466, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Album précédant";
            // 
            // tbxSuivantNom
            // 
            this.tbxSuivantNom.Location = new System.Drawing.Point(584, 163);
            this.tbxSuivantNom.Name = "tbxSuivantNom";
            this.tbxSuivantNom.Size = new System.Drawing.Size(204, 20);
            this.tbxSuivantNom.TabIndex = 21;
            // 
            // tbxSuivantTitre
            // 
            this.tbxSuivantTitre.Location = new System.Drawing.Point(584, 137);
            this.tbxSuivantTitre.Name = "tbxSuivantTitre";
            this.tbxSuivantTitre.Size = new System.Drawing.Size(204, 20);
            this.tbxSuivantTitre.TabIndex = 20;
            this.tbxSuivantTitre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxSuivantTitre_KeyUp);
            // 
            // tbxPrecedantNom
            // 
            this.tbxPrecedantNom.Location = new System.Drawing.Point(584, 215);
            this.tbxPrecedantNom.Name = "tbxPrecedantNom";
            this.tbxPrecedantNom.Size = new System.Drawing.Size(204, 20);
            this.tbxPrecedantNom.TabIndex = 23;
            // 
            // tbxPrecedantTitre
            // 
            this.tbxPrecedantTitre.Location = new System.Drawing.Point(584, 189);
            this.tbxPrecedantTitre.Name = "tbxPrecedantTitre";
            this.tbxPrecedantTitre.Size = new System.Drawing.Size(204, 20);
            this.tbxPrecedantTitre.TabIndex = 22;
            this.tbxPrecedantTitre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxPrecedantTitre_KeyUp);
            // 
            // tbxRecommande3
            // 
            this.tbxRecommande3.Location = new System.Drawing.Point(584, 345);
            this.tbxRecommande3.Name = "tbxRecommande3";
            this.tbxRecommande3.Size = new System.Drawing.Size(204, 20);
            this.tbxRecommande3.TabIndex = 29;
            this.tbxRecommande3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxRecommande3_KeyUp);
            // 
            // tbxRecommande2
            // 
            this.tbxRecommande2.Location = new System.Drawing.Point(584, 293);
            this.tbxRecommande2.Name = "tbxRecommande2";
            this.tbxRecommande2.Size = new System.Drawing.Size(204, 20);
            this.tbxRecommande2.TabIndex = 28;
            this.tbxRecommande2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxRecommande2_KeyUp);
            // 
            // tbxRecommande1
            // 
            this.tbxRecommande1.Location = new System.Drawing.Point(584, 241);
            this.tbxRecommande1.Name = "tbxRecommande1";
            this.tbxRecommande1.Size = new System.Drawing.Size(204, 20);
            this.tbxRecommande1.TabIndex = 27;
            this.tbxRecommande1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxRecommande1_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(466, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Recommandé 3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(466, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Recommandé 2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(466, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Recommandé 1";
            // 
            // tbxRecommande1Nom
            // 
            this.tbxRecommande1Nom.Location = new System.Drawing.Point(584, 267);
            this.tbxRecommande1Nom.Name = "tbxRecommande1Nom";
            this.tbxRecommande1Nom.Size = new System.Drawing.Size(204, 20);
            this.tbxRecommande1Nom.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(466, 270);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Recommandé 1";
            // 
            // tbxRecommande2Nom
            // 
            this.tbxRecommande2Nom.Location = new System.Drawing.Point(584, 319);
            this.tbxRecommande2Nom.Name = "tbxRecommande2Nom";
            this.tbxRecommande2Nom.Size = new System.Drawing.Size(204, 20);
            this.tbxRecommande2Nom.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(466, 322);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Recommandé 2";
            // 
            // tbxRecommande3Nom
            // 
            this.tbxRecommande3Nom.Location = new System.Drawing.Point(584, 371);
            this.tbxRecommande3Nom.Name = "tbxRecommande3Nom";
            this.tbxRecommande3Nom.Size = new System.Drawing.Size(204, 20);
            this.tbxRecommande3Nom.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(466, 374);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Recommandé 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxRecommande3Nom);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbxRecommande2Nom);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbxRecommande1Nom);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbxRecommande3);
            this.Controls.Add(this.tbxRecommande2);
            this.Controls.Add(this.tbxRecommande1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbxPrecedantNom);
            this.Controls.Add(this.tbxPrecedantTitre);
            this.Controls.Add(this.tbxSuivantNom);
            this.Controls.Add(this.tbxSuivantTitre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbxFichiers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxCategorie);
            this.Controls.Add(this.tbxDateYYYYMMDD);
            this.Controls.Add(this.tbxDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxText);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.tbxTitre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTitre;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.RichTextBox tbxText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxDate;
        private System.Windows.Forms.TextBox tbxDateYYYYMMDD;
        private System.Windows.Forms.ComboBox cbxCategorie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxFichiers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxSuivantNom;
        private System.Windows.Forms.TextBox tbxSuivantTitre;
        private System.Windows.Forms.TextBox tbxPrecedantNom;
        private System.Windows.Forms.TextBox tbxPrecedantTitre;
        private System.Windows.Forms.TextBox tbxRecommande3;
        private System.Windows.Forms.TextBox tbxRecommande2;
        private System.Windows.Forms.TextBox tbxRecommande1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxRecommande1Nom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbxRecommande2Nom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxRecommande3Nom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

