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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTitre = new System.Windows.Forms.TextBox();
            this.pagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pages = new PhotoAlbumGenerator.pages();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hTMLTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date30Janvier2020DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date20200130DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.related1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.related1NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.related2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.related2NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.related3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.related3NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbxIndexLocation = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(478, 704);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Créer les pages";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom de la page";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "HTML text";
            // 
            // tbxTitre
            // 
            this.tbxTitre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagesBindingSource, "Title", true));
            this.tbxTitre.Location = new System.Drawing.Point(87, 4);
            this.tbxTitre.Name = "tbxTitre";
            this.tbxTitre.Size = new System.Drawing.Size(353, 20);
            this.tbxTitre.TabIndex = 4;
            this.tbxTitre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxTitre_KeyUp);
            // 
            // pagesBindingSource
            // 
            this.pagesBindingSource.DataMember = "Pages";
            this.pagesBindingSource.DataSource = this.pages;
            // 
            // pages
            // 
            this.pages.DataSetName = "pages";
            this.pages.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbxNom
            // 
            this.tbxNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagesBindingSource, "Name", true));
            this.tbxNom.Location = new System.Drawing.Point(87, 30);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(353, 20);
            this.tbxNom.TabIndex = 5;
            // 
            // tbxText
            // 
            this.tbxText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagesBindingSource, "HTML text", true));
            this.tbxText.Location = new System.Drawing.Point(87, 58);
            this.tbxText.Name = "tbxText";
            this.tbxText.Size = new System.Drawing.Size(353, 317);
            this.tbxText.TabIndex = 6;
            this.tbxText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date (30 janvier 2020)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date (2020-01-30)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Catégorie";
            // 
            // tbxDate
            // 
            this.tbxDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagesBindingSource, "Date (30 janvier 2020)", true));
            this.tbxDate.Location = new System.Drawing.Point(575, 4);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.Size = new System.Drawing.Size(204, 20);
            this.tbxDate.TabIndex = 10;
            // 
            // tbxDateYYYYMMDD
            // 
            this.tbxDateYYYYMMDD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagesBindingSource, "Date (2020-01-30)", true));
            this.tbxDateYYYYMMDD.Location = new System.Drawing.Point(575, 30);
            this.tbxDateYYYYMMDD.Name = "tbxDateYYYYMMDD";
            this.tbxDateYYYYMMDD.Size = new System.Drawing.Size(204, 20);
            this.tbxDateYYYYMMDD.TabIndex = 11;
            // 
            // cbxCategorie
            // 
            this.cbxCategorie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagesBindingSource, "Category", true));
            this.cbxCategorie.FormattingEnabled = true;
            this.cbxCategorie.Items.AddRange(new object[] {
            "événement",
            "portrait",
            "paysage",
            "nature",
            "street",
            "divers"});
            this.cbxCategorie.Location = new System.Drawing.Point(575, 56);
            this.cbxCategorie.Name = "cbxCategorie";
            this.cbxCategorie.Size = new System.Drawing.Size(204, 21);
            this.cbxCategorie.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fichiers";
            // 
            // tbxFichiers
            // 
            this.tbxFichiers.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagesBindingSource, "Folder", true));
            this.tbxFichiers.Location = new System.Drawing.Point(575, 85);
            this.tbxFichiers.Name = "tbxFichiers";
            this.tbxFichiers.Size = new System.Drawing.Size(204, 20);
            this.tbxFichiers.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 83);
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
            this.label8.Location = new System.Drawing.Point(457, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Album suivant";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Album-suivant";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Album-précédant";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(457, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Album précédant";
            // 
            // tbxSuivantNom
            // 
            this.tbxSuivantNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagesBindingSource, "NextName", true));
            this.tbxSuivantNom.Location = new System.Drawing.Point(575, 147);
            this.tbxSuivantNom.Name = "tbxSuivantNom";
            this.tbxSuivantNom.Size = new System.Drawing.Size(204, 20);
            this.tbxSuivantNom.TabIndex = 21;
            // 
            // tbxSuivantTitre
            // 
            this.tbxSuivantTitre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagesBindingSource, "Next", true));
            this.tbxSuivantTitre.Location = new System.Drawing.Point(575, 121);
            this.tbxSuivantTitre.Name = "tbxSuivantTitre";
            this.tbxSuivantTitre.Size = new System.Drawing.Size(204, 20);
            this.tbxSuivantTitre.TabIndex = 20;
            this.tbxSuivantTitre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxSuivantTitre_KeyUp);
            // 
            // tbxPrecedantNom
            // 
            this.tbxPrecedantNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagesBindingSource, "PrevName", true));
            this.tbxPrecedantNom.Location = new System.Drawing.Point(575, 199);
            this.tbxPrecedantNom.Name = "tbxPrecedantNom";
            this.tbxPrecedantNom.Size = new System.Drawing.Size(204, 20);
            this.tbxPrecedantNom.TabIndex = 23;
            // 
            // tbxPrecedantTitre
            // 
            this.tbxPrecedantTitre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagesBindingSource, "Prev", true));
            this.tbxPrecedantTitre.Location = new System.Drawing.Point(575, 173);
            this.tbxPrecedantTitre.Name = "tbxPrecedantTitre";
            this.tbxPrecedantTitre.Size = new System.Drawing.Size(204, 20);
            this.tbxPrecedantTitre.TabIndex = 22;
            this.tbxPrecedantTitre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxPrecedantTitre_KeyUp);
            // 
            // tbxRecommande3
            // 
            this.tbxRecommande3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagesBindingSource, "Related3", true));
            this.tbxRecommande3.Location = new System.Drawing.Point(575, 329);
            this.tbxRecommande3.Name = "tbxRecommande3";
            this.tbxRecommande3.Size = new System.Drawing.Size(204, 20);
            this.tbxRecommande3.TabIndex = 29;
            this.tbxRecommande3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxRecommande3_KeyUp);
            // 
            // tbxRecommande2
            // 
            this.tbxRecommande2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagesBindingSource, "Related2", true));
            this.tbxRecommande2.Location = new System.Drawing.Point(575, 277);
            this.tbxRecommande2.Name = "tbxRecommande2";
            this.tbxRecommande2.Size = new System.Drawing.Size(204, 20);
            this.tbxRecommande2.TabIndex = 28;
            this.tbxRecommande2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxRecommande2_KeyUp);
            // 
            // tbxRecommande1
            // 
            this.tbxRecommande1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagesBindingSource, "Related1", true));
            this.tbxRecommande1.Location = new System.Drawing.Point(575, 225);
            this.tbxRecommande1.Name = "tbxRecommande1";
            this.tbxRecommande1.Size = new System.Drawing.Size(204, 20);
            this.tbxRecommande1.TabIndex = 27;
            this.tbxRecommande1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxRecommande1_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(457, 332);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Recommandé 3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(457, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Recommandé 2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(457, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Recommandé 1";
            // 
            // tbxRecommande1Nom
            // 
            this.tbxRecommande1Nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagesBindingSource, "Related1Name", true));
            this.tbxRecommande1Nom.Location = new System.Drawing.Point(575, 251);
            this.tbxRecommande1Nom.Name = "tbxRecommande1Nom";
            this.tbxRecommande1Nom.Size = new System.Drawing.Size(204, 20);
            this.tbxRecommande1Nom.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(457, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Recommandé 1";
            // 
            // tbxRecommande2Nom
            // 
            this.tbxRecommande2Nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagesBindingSource, "Related2Name", true));
            this.tbxRecommande2Nom.Location = new System.Drawing.Point(575, 303);
            this.tbxRecommande2Nom.Name = "tbxRecommande2Nom";
            this.tbxRecommande2Nom.Size = new System.Drawing.Size(204, 20);
            this.tbxRecommande2Nom.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(457, 306);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Recommandé 2";
            // 
            // tbxRecommande3Nom
            // 
            this.tbxRecommande3Nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagesBindingSource, "Related3Name", true));
            this.tbxRecommande3Nom.Location = new System.Drawing.Point(575, 355);
            this.tbxRecommande3Nom.Name = "tbxRecommande3Nom";
            this.tbxRecommande3Nom.Size = new System.Drawing.Size(204, 20);
            this.tbxRecommande3Nom.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(457, 358);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Recommandé 3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.hTMLTextDataGridViewTextBoxColumn,
            this.date30Janvier2020DataGridViewTextBoxColumn,
            this.date20200130DataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.folderDataGridViewTextBoxColumn,
            this.nextDataGridViewTextBoxColumn,
            this.nextNameDataGridViewTextBoxColumn,
            this.prevDataGridViewTextBoxColumn,
            this.prevNameDataGridViewTextBoxColumn,
            this.related1DataGridViewTextBoxColumn,
            this.related1NameDataGridViewTextBoxColumn,
            this.related2DataGridViewTextBoxColumn,
            this.related2NameDataGridViewTextBoxColumn,
            this.related3DataGridViewTextBoxColumn,
            this.related3NameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pagesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 387);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 282);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // hTMLTextDataGridViewTextBoxColumn
            // 
            this.hTMLTextDataGridViewTextBoxColumn.DataPropertyName = "HTML text";
            this.hTMLTextDataGridViewTextBoxColumn.HeaderText = "HTML text";
            this.hTMLTextDataGridViewTextBoxColumn.Name = "hTMLTextDataGridViewTextBoxColumn";
            // 
            // date30Janvier2020DataGridViewTextBoxColumn
            // 
            this.date30Janvier2020DataGridViewTextBoxColumn.DataPropertyName = "Date (30 janvier 2020)";
            this.date30Janvier2020DataGridViewTextBoxColumn.HeaderText = "Date (30 janvier 2020)";
            this.date30Janvier2020DataGridViewTextBoxColumn.Name = "date30Janvier2020DataGridViewTextBoxColumn";
            // 
            // date20200130DataGridViewTextBoxColumn
            // 
            this.date20200130DataGridViewTextBoxColumn.DataPropertyName = "Date (2020-01-30)";
            this.date20200130DataGridViewTextBoxColumn.HeaderText = "Date (2020-01-30)";
            this.date20200130DataGridViewTextBoxColumn.Name = "date20200130DataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // folderDataGridViewTextBoxColumn
            // 
            this.folderDataGridViewTextBoxColumn.DataPropertyName = "Folder";
            this.folderDataGridViewTextBoxColumn.HeaderText = "Folder";
            this.folderDataGridViewTextBoxColumn.Name = "folderDataGridViewTextBoxColumn";
            // 
            // nextDataGridViewTextBoxColumn
            // 
            this.nextDataGridViewTextBoxColumn.DataPropertyName = "Next";
            this.nextDataGridViewTextBoxColumn.HeaderText = "Next";
            this.nextDataGridViewTextBoxColumn.Name = "nextDataGridViewTextBoxColumn";
            // 
            // nextNameDataGridViewTextBoxColumn
            // 
            this.nextNameDataGridViewTextBoxColumn.DataPropertyName = "NextName";
            this.nextNameDataGridViewTextBoxColumn.HeaderText = "NextName";
            this.nextNameDataGridViewTextBoxColumn.Name = "nextNameDataGridViewTextBoxColumn";
            // 
            // prevDataGridViewTextBoxColumn
            // 
            this.prevDataGridViewTextBoxColumn.DataPropertyName = "Prev";
            this.prevDataGridViewTextBoxColumn.HeaderText = "Prev";
            this.prevDataGridViewTextBoxColumn.Name = "prevDataGridViewTextBoxColumn";
            // 
            // prevNameDataGridViewTextBoxColumn
            // 
            this.prevNameDataGridViewTextBoxColumn.DataPropertyName = "PrevName";
            this.prevNameDataGridViewTextBoxColumn.HeaderText = "PrevName";
            this.prevNameDataGridViewTextBoxColumn.Name = "prevNameDataGridViewTextBoxColumn";
            // 
            // related1DataGridViewTextBoxColumn
            // 
            this.related1DataGridViewTextBoxColumn.DataPropertyName = "Related1";
            this.related1DataGridViewTextBoxColumn.HeaderText = "Related1";
            this.related1DataGridViewTextBoxColumn.Name = "related1DataGridViewTextBoxColumn";
            // 
            // related1NameDataGridViewTextBoxColumn
            // 
            this.related1NameDataGridViewTextBoxColumn.DataPropertyName = "Related1Name";
            this.related1NameDataGridViewTextBoxColumn.HeaderText = "Related1Name";
            this.related1NameDataGridViewTextBoxColumn.Name = "related1NameDataGridViewTextBoxColumn";
            // 
            // related2DataGridViewTextBoxColumn
            // 
            this.related2DataGridViewTextBoxColumn.DataPropertyName = "Related2";
            this.related2DataGridViewTextBoxColumn.HeaderText = "Related2";
            this.related2DataGridViewTextBoxColumn.Name = "related2DataGridViewTextBoxColumn";
            // 
            // related2NameDataGridViewTextBoxColumn
            // 
            this.related2NameDataGridViewTextBoxColumn.DataPropertyName = "Related2Name";
            this.related2NameDataGridViewTextBoxColumn.HeaderText = "Related2Name";
            this.related2NameDataGridViewTextBoxColumn.Name = "related2NameDataGridViewTextBoxColumn";
            // 
            // related3DataGridViewTextBoxColumn
            // 
            this.related3DataGridViewTextBoxColumn.DataPropertyName = "Related3";
            this.related3DataGridViewTextBoxColumn.HeaderText = "Related3";
            this.related3DataGridViewTextBoxColumn.Name = "related3DataGridViewTextBoxColumn";
            // 
            // related3NameDataGridViewTextBoxColumn
            // 
            this.related3NameDataGridViewTextBoxColumn.DataPropertyName = "Related3Name";
            this.related3NameDataGridViewTextBoxColumn.HeaderText = "Related3Name";
            this.related3NameDataGridViewTextBoxColumn.Name = "related3NameDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbxRecommande3Nom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.tbxTitre);
            this.panel1.Controls.Add(this.tbxRecommande2Nom);
            this.panel1.Controls.Add(this.tbxNom);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.tbxText);
            this.panel1.Controls.Add(this.tbxRecommande1Nom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbxRecommande3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbxRecommande2);
            this.panel1.Controls.Add(this.tbxDate);
            this.panel1.Controls.Add(this.tbxRecommande1);
            this.panel1.Controls.Add(this.tbxDateYYYYMMDD);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbxCategorie);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.tbxFichiers);
            this.panel1.Controls.Add(this.tbxPrecedantNom);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.tbxPrecedantTitre);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbxSuivantNom);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbxSuivantTitre);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 380);
            this.panel1.TabIndex = 37;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(478, 675);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(559, 675);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 39;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(640, 675);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(721, 675);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 41;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearch.Location = new System.Drawing.Point(78, 675);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(394, 20);
            this.tbxSearch.TabIndex = 36;
            this.tbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearch_KeyPress);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 678);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Recherche";
            // 
            // tbxIndexLocation
            // 
            this.tbxIndexLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxIndexLocation.Location = new System.Drawing.Point(159, 709);
            this.tbxIndexLocation.Name = "tbxIndexLocation";
            this.tbxIndexLocation.Size = new System.Drawing.Size(313, 20);
            this.tbxIndexLocation.TabIndex = 42;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(78, 707);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 712);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "Fichiers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 735);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbxIndexLocation);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(816, 478);
            this.Name = "Form1";
            this.Text = "WebEdit";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource pagesBindingSource;
        private pages pages;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hTMLTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn date30Janvier2020DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn date20200130DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn folderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn related1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn related1NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn related2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn related2NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn related3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn related3NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbxIndexLocation;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label19;
    }
}

