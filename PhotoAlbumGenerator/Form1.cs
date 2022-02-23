using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PhotoAlbumGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in App.Pages.Rows)
            {
                string path = row["Folder"].ToString();
                DirectoryInfo d = new DirectoryInfo(path);
                string text = File.ReadAllText("main.html");
                text = text.Replace("$TITLE", row["Title"].ToString());
                text = text.Replace("$NAME", row["Name"].ToString());

                string category = "";
                switch (row["Category"].ToString())
                {
                    case "événement":
                        category = "evenement";
                        break;
                    case "portrait":
                        category = "portrait";
                        break;
                    case "paysage":
                        category = "paysage";
                        break;
                    case "nature":
                        category = "nature";
                        break;
                    case "street":
                        category = "street";
                        break;
                    case "divers":
                        category = "divers";
                        break;
                }

                text = text.Replace("$CATEGORY", category);
                text = text.Replace("$DATE_SHORT", row["Date (2020-01-30)"].ToString());
                text = text.Replace("$DATE", row["Date (30 janvier 2020)"].ToString());

                text = text.Replace("$COMMENT", row["HTML text"].ToString());

                FileInfo[] files = d.GetFiles("*.jpg");
                string gallery = "";
                for (int i = 0; i < files.Length; i++)
                {
                    string imageName = row["Name"].ToString() + "-" + i.ToString("D3") + ".jpg";
                    File.Move(files[i].FullName, path + "\\" + imageName);

                    string image = File.ReadAllText("gallery.html");
                    image = image.Replace("$FILE_NAME", imageName);
                    gallery = gallery + image;
                }

                text = text.Replace("$GALLERY", gallery);

                text = text.Replace("$PREV_TITLE", row["Prev"].ToString());
                text = text.Replace("$PREV", row["PrevName"].ToString());
                text = text.Replace("$NEXT_TITLE", row["Next"].ToString());
                text = text.Replace("$NEXT", row["NextName"].ToString());

                string related = "";
                related = related + WriteRecommande(row["Related1"].ToString(), row["Related1Name"].ToString());
                related = related + WriteRecommande(row["Related2"].ToString(), row["Related2Name"].ToString());
                related = related + WriteRecommande(row["Related3"].ToString(), row["Related3Name"].ToString());
                text = text.Replace("$RELATED", related);

                File.WriteAllText(path + "/index.html", text);
            }



            MessageBox.Show("Success", "Success", MessageBoxButtons.OK);
        }

        private string WriteRecommande(string titre, string nom)
        {
            if (titre != "" && nom != "")
            {
                string related = File.ReadAllText("related.html");
                related = related.Replace("$RELATED_NAME", nom);
                related = related.Replace("$RELATED_TITLE", titre);
                return related;
            }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxFichiers.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void tbxTitre_KeyUp(object sender, KeyEventArgs e)
        {
            tbxNom.Text = tbxTitre.Text.ToLower().Replace(" ", "-").Replace("é", "e").Replace("è", "e").Replace("à", "a");
        }

        private void tbxSuivantTitre_KeyUp(object sender, KeyEventArgs e)
        {
            tbxSuivantNom.Text = tbxSuivantTitre.Text.ToLower().Replace(" ", "-").Replace("é", "e").Replace("è", "e").Replace("à", "a");
        }

        private void tbxPrecedantTitre_KeyUp(object sender, KeyEventArgs e)
        {
            tbxPrecedantNom.Text = tbxPrecedantTitre.Text.ToLower().Replace(" ", "-").Replace("é", "e").Replace("è", "e").Replace("à", "a");
        }

        private void tbxRecommande1_KeyUp(object sender, KeyEventArgs e)
        {
            tbxRecommande1Nom.Text = tbxRecommande1.Text.ToLower().Replace(" ", "-").Replace("é", "e").Replace("è", "e").Replace("à", "a");
        }

        private void tbxRecommande2_KeyUp(object sender, KeyEventArgs e)
        {
            tbxRecommande2Nom.Text = tbxRecommande2.Text.ToLower().Replace(" ", "-").Replace("é", "e").Replace("è", "e").Replace("à", "a");
        }

        private void tbxRecommande3_KeyUp(object sender, KeyEventArgs e)
        {
            tbxRecommande3Nom.Text = tbxRecommande3.Text.ToLower().Replace(" ", "-").Replace("é", "e").Replace("è", "e").Replace("à", "a");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Use singleton pattern to create an instance
        static pages db;
        protected static pages App
        {
            get
            {
                if (db == null)
                    db = new pages();
                return db;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Read file, then load data to dataset
            string fileName = string.Format("{0}//data.dat", Application.StartupPath);
            if (File.Exists(fileName))
                App.Pages.ReadXml(fileName);
            pagesBindingSource.DataSource = App.Pages;
            panel1.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //End edit, save dataset to file
                pagesBindingSource.EndEdit();
                App.Pages.AcceptChanges();
                App.Pages.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));
                panel1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.Pages.RejectChanges();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            tbxTitre.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pagesBindingSource.ResetBindings(false);
            panel1.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                //Add a new row
                App.Pages.AddPagesRow(App.Pages.NewPagesRow());
                pagesBindingSource.MoveLast();
                tbxTitre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.Pages.RejectChanges();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    pagesBindingSource.RemoveCurrent();
            }
        }

        private void tbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//Enter key
            {
                if (!string.IsNullOrEmpty(tbxSearch.Text))
                {
                    //you can use linq to query data
                    var query = from o in App.Pages
                                where o.Title.ToLowerInvariant().Contains(tbxSearch.Text.ToLowerInvariant())
                                select o;
                    dataGridView1.DataSource = query.ToList();
                }
                else
                    dataGridView1.DataSource = pagesBindingSource;
            }
        }
    }
}
