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
            string path = tbxFichiers.Text;
            DirectoryInfo d = new DirectoryInfo(path);
            string text = File.ReadAllText("main.html");
            text = text.Replace("$TITLE", tbxTitre.Text);
            text = text.Replace("$NAME", tbxNom.Text);

            string category = "";
            switch (cbxCategorie.SelectedItem.ToString())
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
            text = text.Replace("$DATE_SHORT", tbxDateYYYYMMDD.Text);
            text = text.Replace("$DATE", tbxDate.Text);

            text = text.Replace("$COMMENT", tbxText.Text);

            FileInfo[] files = d.GetFiles("*.jpg");
            string gallery = "";
            for (int i = 0; i < files.Length; i++)
            {
                string imageName = tbxNom.Text + "-" + i.ToString("D3") + ".jpg";
                File.Move(files[i].FullName, path + "\\" + imageName);

                string image = File.ReadAllText("gallery.html");
                image = image.Replace("$FILE_NAME", imageName);
                gallery = gallery + image;
            }

            text = text.Replace("$GALLERY", gallery);

            text = text.Replace("$PREV_TITLE", tbxPrecedantTitre.Text);
            text = text.Replace("$PREV", tbxPrecedantNom.Text);
            text = text.Replace("$NEXT_TITLE", tbxSuivantTitre.Text);
            text = text.Replace("$NEXT", tbxSuivantNom.Text);

            string related = "";
            related = related + WriteRecommande(tbxRecommande1.Text, tbxRecommande1Nom.Text);
            related = related + WriteRecommande(tbxRecommande2.Text, tbxRecommande2Nom.Text);
            related = related + WriteRecommande(tbxRecommande3.Text, tbxRecommande3Nom.Text);
            text = text.Replace("$RELATED", related);

            File.WriteAllText(path + "/index.html", text);

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
    }
}
