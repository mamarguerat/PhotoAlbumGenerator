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
        string html1 = "<!doctype html>\r\n" +
"\r\n" +
"<html lang=\"fr\"\r\n" +
"    class=\"minimal-style is-menu-fixed is-always-fixed is-selection-shareable blog-animated header-light header-small\"\r\n" +
"    data-effect=\"slideUp\">\r\n" +
"\r\n" +
"<head>\r\n" +
"    <meta charset=\"utf-8\">\r\n" +
"    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n" +
"    <meta name=\"description\" content=\"Photos de Martin Marguerat, album ";
        string html1_1 = "\">\r\n" +
"    <meta name=\"keywords\" content=\"personal, blog, html5\">\r\n" +
"    <meta name=\"author\" content=\"Martin Marguerat\">\r\n" +
"    <title>"; //Les Digitales 2020
        string html2 = " - Martin Marguerat</title>\r\n" +
"\r\n" +
"    <!-- FAV and TOUCH ICONS -->\r\n" +
"    <link rel=\"shortcut icon\" href=\"/images/ico/favicon.ico\">\r\n" +
"    <link rel=\"apple-touch-icon\" href=\"/images/ico/apple-touch-icon.png\" />\r\n" +
"\r\n" +
"    <!-- FONTS -->\r\n" +
"    <link rel=\"stylesheet\" media=\"print\" onload=\"this.onload=null;this.removeAttribute('media');\"\r\n" +
"        href=\"https://fonts.googleapis.com/css?family=Lato:400,700|Noto+Sans:400,400i,700,700i|Poppins:300,400,500,600,700\"\r\n" +
"        rel=\"stylesheet\">\r\n" +
"\r\n" +
"    <!-- STYLES -->\r\n" +
"    <link rel=\"stylesheet\" type=\"text/css\" href=\"/css/bootstrap.min.css\">\r\n" +
"    <link rel=\"stylesheet\" type=\"text/css\" href=\"/css/fonts/fontello/css/fontello.css\">\r\n" +
"    <link rel=\"stylesheet\" type=\"text/css\" href=\"/js/jquery.magnific-popup/magnific-popup.css\">\r\n" +
"    <link rel=\"stylesheet\" type=\"text/css\" href=\"/js/jquery.fluidbox/fluidbox.css\">\r\n" +
"    <link rel=\"stylesheet\" type=\"text/css\" href=\"/js/owl-carousel/owl.carousel.css\">\r\n" +
"    <link rel=\"stylesheet\" type=\"text/css\" href=\"/js/selection-sharer/selection-sharer.css\">\r\n" +
"    <link rel=\"stylesheet\" type=\"text/css\" href=\"/css/rotate-words.css\">\r\n" +
"    <link rel=\"stylesheet\" type=\"text/css\" href=\"/css/align.css\">\r\n" +
"    <link rel=\"stylesheet\" type=\"text/css\" href=\"/css/main.css\">\r\n" +
"    <link rel=\"stylesheet\" type=\"text/css\" href=\"/js/shortcodes/shortcodes.css\">\r\n" +
"    <link rel=\"stylesheet\" type=\"text/css\" href=\"/css/768.css\">\r\n" +
"    <link rel=\"stylesheet\" type=\"text/css\" href=\"/css/992.css\">\r\n" +
"    <link rel=\"stylesheet\" type=\"text/css\" href=\"/css/554.css\">\r\n" +
"\r\n" +
"    <!-- INITIAL SCRIPTS -->\r\n" +
"    <script src=\"/js/modernizr.min.js\"></script>\r\n" +
"    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js\"></script>\r\n" +
"    <script>\r\n" +
"        if (!window.jQuery) {\r\n" +
"            document.write('<script src=\"js/jquery-3.1.1.min.js\"><\\/script>');\r\n" +
"        }\r\n" +
"    </script>\r\n" +
"    <!-- Global site tag (gtag.js) - Google Analytics -->\r\n" +
"    <script async src=\"https://www.googletagmanager.com/gtag/js?id=UA-180198114-1\"></script>\r\n" +
"    <script>\r\n" +
"        window.dataLayer = window.dataLayer || [];\r\n" +
"        function gtag() { dataLayer.push(arguments); }\r\n" +
"        gtag('js', new Date());\r\n" +
"\r\n" +
"        gtag('config', 'UA-180198114-1');\r\n" +
"    </script>\r\n" +
"    <script src=\"https://code.jquery.com/jquery-3.1.1.js\"\r\n" +
"        integrity=\"sha256-2Kok7MbOyxpgUVvAk/HJ2jigOSYS2auK4Pfzbm7uH60=\" crossorigin=\"anonymous\">\r\n" +
"        </script>\r\n" +
"    <script>\r\n" +
"        $(function () {\r\n" +
"            $(\"#header\").load(\"/header.html\");\r\n" +
"            $(\"#footer\").load(\"/footer.html\");\r\n" +
"        });\r\n" +
"    </script>\r\n" +
"</head>\r\n" +
"\r\n" +
"<body class=\" single \">\r\n" +
"    <!-- page -->\r\n" +
"    <div id=\"page\" class=\"hfeed site\">\r\n" +
"        <div id=\"header\"></div>\r\n" +
"        <!-- site-main -->\r\n" +
"        <div id=\"main\" class=\"site-main\">\r\n" +
"            <div class=\"layout-medium\">\r\n" +
"                <div id=\"primary\" class=\"content-area\">\r\n" +
"                    <!-- site-content -->\r\n" +
"                    <div id=\"content\" class=\"site-content\" role=\"main\">\r\n" +
"                        <!-- .hentry -->\r\n" +
"                        <article class=\"hentry post single-post format-gallery\">\r\n" +
"                            <!-- .entry-header -->\r\n" +
"                            <header class=\"entry-header\">\r\n" +
"                                <!-- .entry-title -->\r\n" +
"                                <h1 class=\"entry-title\">"; //Les Digitales 2020
        string html3 = "</h1>\r\n" +
"                                <!-- .entry-meta -->\r\n" +
"                                <div class=\"entry-meta\">\r\n" +
"                                    <span class=\"cat-links\">\r\n" +
"                                        <a href=\""; //Link catégorie
        string html3_1 = "\" title=\"Voir tous les albums "; //Evénementiel
        string html3_2 = "\"\r\n" +
"                                            rel=\"category tag\">"; //Evénementiel
        string html4 = "</a>\r\n" +
"                                    </span>\r\n" +
"                                    <span class=\"entry-date\">\r\n" +
"                                        <time class=\"entry-date\" datetime=\""; //2020-09-12
        string html5 = "T00:00:00+01:00\">"; //12 septembre 2020
        string html6 = "</time>\r\n" +
"                                    </span>\r\n" +
"                                </div>\r\n" +
"                                <!-- .entry-meta -->\r\n" +
"                            </header>\r\n" +
"                            <!-- .entry-header -->\r\n" +
"                            <!-- .entry-content -->\r\n" +
"                            <div class=\"entry-content\">\r\n" +
"                                <!-- .gallery -->\r\n" +
"                                <div class=\"gallery link-to-file\">\r\n";
        //For loop
        string htmlimage1 = "                                    <figure class=\"gallery-item\">\r\n" +
"                                        <div class=\"gallery-icon landscape\">\r\n" +
"                                            <a href=\""; //nom/image
        string htmlimage2 = "\"><img\r\n" +
"                                                    src=\""; //nom/image
        string htmlimage3 = "\" class=\"attachment-thumbnail\"\r\n" +
"                                                    alt=\"slide-image\" loading=\"lazy\"></a>\r\n" +
"                                        </div>\r\n" +
"                                    </figure>\r\n";
        string html7 = "                                </div>\r\n" +
"                                <!-- .gallery -->\r\n";
        //"                                <p>He'll want to use your yacht, and I don't want this thing smelling like fish. Steve\r\n" +
        //"                                    Holt! No! I was ashamed to be SEEN with you. I like being with you. Marry me. It's\r\n" +
        //"                                    called 'taking advantage.' It's what gets you ahead in life. I'm a monster. Army had\r\n" +
        //"                                    half a day. I don't criticize you! And if you're worried about criticism, sometimes\r\n" +
        //"                                    a diet is the best defense.</p>\r\n" +
        //"                                <h3>I'm afraid I just blue myself.</h3>\r\n" +
        //"                                <p>First place chick is hot, but has an attitude, doesn't date magicians. Really? Did\r\n" +
        //"                                    nothing cancel? Well, what do you expect, mother? Michael!</p>\r\n" +
        //"                                <p>Really? Did nothing cancel? Did you enjoy your meal, Mom? You drank it fast enough.\r\n" +
        //"                                    Not tricks, Michael, illusions. That's what it said on 'Ask Jeeves.' Really? Did\r\n" +
        //"                                    nothing cancel?</p>\r\n" +
        //"                                <!-- blockquote -->\r\n" +
        //"                                <blockquote>Start a blog today!\r\n" +
        //"                                    <cite>Pixelwars</cite>\r\n" +
        //"                                </blockquote>\r\n" +
        //"                                <!-- blockquote -->\r\n" +
        //"                                <p>Now, when you do this without getting punched in the chest, you'll have more fun.\r\n" +
        //"                                    Whoa, this guy's straight? It's a hug, Michael. I'm hugging you. Well, what do you\r\n" +
        //"                                    expect, mother? I'm afraid I just blue myself.</p>\r\n" +
        //"                                <p>Guy's a pro. Get me a vodka rocks. And a piece of toast. I don't criticize you! And\r\n" +
        //"                                    if you're worried about criticism, sometimes a diet is the best defense. Did you\r\n" +
        //"                                    enjoy your meal, Mom? You drank it fast enough.</p>\r\n" +
        //"                                <p>It's called 'taking advantage.' It's what gets you ahead in life. I've opened a door\r\n" +
        //"                                    here that I regret. Marry me. Guy's a pro.</p>\r\n"
        string html8 = "\r\n                                <!-- .share-links -->\r\n" +
"                                <div class=\"share-links\">\r\n" +
"                                    <h3>Partager cet album</h3>\r\n" +
"                                    <a rel=\"nofollow\" target=\"_blank\"\r\n" +
"                                        href=\"mailto:?subject=Regarde ces photos de Martin Marguerat&amp;body=Regarde cet album photos de Martin Marguerat : "; //Les Digitales 2020
        string html9 = " - https://martinmarguerat.ch/portfolio/"; //les-digitales-2020
        string html10 = "\"\r\n" +
"                                        title=\"Envoyer à un ami par e-mail\"><i class=\"pw-icon-mail\"></i></a>\r\n" +
"\r\n" +
"                                    <a rel=\"nofollow\" target=\"_blank\"\r\n" +
"                                        href=\"https://twitter.com/intent/tweet?text=Voir les photos de: "; //Les Digitales 2020
        string html11 = " (Martin Marguerat) https://martinmarguerat.ch/portfolio/"; //les-digitales-2020
        string html12 = ".html\"\r\n" +
"                                        title=\"Partager sur Twitter\"><i class=\"pw-icon-twitter\"></i></a>\r\n" +
"\r\n" +
"                                    <a rel=\"nofollow\" target=\"_blank\"\r\n" +
"                                        href=\"http://www.facebook.com/sharer/sharer.php?u=https://martinmarguerat.ch/portfolio/"; //les-digitales-2020
        string html13 = "&amp;t="; //Les Digitales 2020
        string html14 = "\"\r\n" +
"                                        title=\"Partager sur Facebook\"><i class=\"pw-icon-facebook\"></i></a>\r\n" +
"\r\n" +
"                                    <a rel=\"nofollow\" target=\"_blank\"\r\n" +
"                                        href=\"https://plus.google.com/share?url=https://martinmarguerat.ch/portfolio/"; //les-digitales-2020
        string html15 = "\"\r\n" +
"                                        title=\"Share this post on Google+\"><i class=\"pw-icon-gplus\"></i></a>\r\n" +
"                                </div>\r\n" +
"                                <!-- .share-links -->\r\n" +
"\r\n" +
"                                <!-- .nav-single -->\r\n" +
"                                <nav class=\"nav-single row\">\r\n" +
"                                    <div class=\"nav-previous col-xs-6\">\r\n" +
"                                        <h4>ALBUM PRÉCÉDANT</h4>\r\n" +
"                                        <a href=\"/portfolio/"; //link
        string html16 = "\" rel=\"prev\">"; //TITRE album précédent
        string html17 = "</a>\r\n" +
"                                    </div>\r\n" +
"                                    <div class=\"nav-next col-xs-6\">\r\n" +
"                                        <h4>ALBUM SUIVANT</h4>\r\n" +
"                                        <a href=\"/portfolio/"; //link
        string html18 = "\" rel=\"next\">"; //TITRE album suivant
        string html19 = "</a>\r\n" +
"                                    </div>\r\n" +
"                                </nav>\r\n" +
"                                <!-- .nav-single -->\r\n" +
"                            </div>\r\n" +
"                            <!-- .entry-content -->\r\n" +
"                        </article>\r\n" +
"                        <!-- .hentry -->\r\n";
        //if
        string html20 = "                        <!-- realated-posts -->\r\n" +
"                        <aside class=\"related-posts\">\r\n" +
"                            <h3>D'autres photos qui pourraient t'intéresser</h3>\r\n";
        //loop
        string html21 = "                            <!-- post -->\r\n" +
"                            <div class=\"post-thumbnail\" style=\"background-image:url("; //recommandé 1 nom
        string html22 = "/"; //recommandé 1 nom
        string html23 = "-000.jpg)\">\r\n" +
"                                <!-- .entry-header -->\r\n" +
"                                <header class=\"entry-header\">\r\n" +
"                                    <!-- .entry-title -->\r\n" +
"                                    <h2 class=\"entry-title\"><a href=\"/portfolio/"; //recommandé 1 Nom
        string html24 = "\">"; //Recommandé 1
        string html25 = "</a>\r\n" +
"                                    </h2>\r\n" +
"                                    <p><a href=\"/portfolio/"; //Recommandé 1 Nom
        string html26 = "\" class=\"more-link\">Voir l'album</a></p>\r\n" +
"                                </header>\r\n" +
"                                <!-- .entry-header -->\r\n" +
"                            </div>\r\n" +
"                            <!-- post -->\r\n";
        //end loop
        string html27 = "                        </aside>\r\n" +
"                        <!-- realated-posts -->\r\n";
        //endif
        string html28 = "                    </div>\r\n" +
"                    <!-- site-content -->\r\n" +
"                </div>\r\n" +
"                <!-- primary -->\r\n" +
"            </div>\r\n" +
"            <!-- layout -->\r\n" +
"        </div>\r\n" +
"        <!-- site-main -->\r\n" +
"        <div id=\"footer\"></div>\r\n" +
"    </div>\r\n" +
"    <!-- page -->\r\n" +
"\r\n" +
"    <!-- SCRIPTS -->\r\n" +
"    <script src=\"/js/jquery-migrate-3.0.0.min.js\"></script>\r\n" +
"    <script src=\"/js/fastclick.js\"></script>\r\n" +
"    <script src=\"/js/jquery.fitvids.js\"></script>\r\n" +
"    <script src=\"/js/jquery.viewport.mini.js\"></script>\r\n" +
"    <script src=\"/js/jquery.waypoints.min.js\"></script>\r\n" +
"    <script src=\"/js/jquery-validation/jquery.validate.min.js\"></script>\r\n" +
"    <script src=\"/js/imagesloaded.pkgd.min.js\"></script>\r\n" +
"    <script src=\"/js/jquery.isotope.min.js\"></script>\r\n" +
"    <script src=\"/js/jquery.magnific-popup/jquery.magnific-popup.min.js\"></script>\r\n" +
"    <script src=\"/js/jquery.fluidbox/jquery.fluidbox.min.js\"></script>\r\n" +
"    <script src=\"/js/owl-carousel/owl.carousel.min.js\"></script>\r\n" +
"    <script src=\"/js/selection-sharer/selection-sharer.js\"></script>\r\n" +
"    <script src=\"/js/socialstream.jquery.js\"></script>\r\n" +
"    <script src=\"/js/jquery.collagePlus/jquery.collagePlus.min.js\"></script>\r\n" +
"    <script src=\"/js/main.js\"></script>\r\n" +
"    <script src=\"/js/shortcodes/shortcodes.js\"></script>\r\n" +
"</body>\r\n" +
"\r\n" +
"</html>";
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = tbxFichiers.Text;
            DirectoryInfo d = new DirectoryInfo(path);
            using (StreamWriter sw = File.AppendText(path + "\\" + tbxNom.Text + ".html"))
            {
                sw.Write(html1);
                sw.Write(tbxTitre.Text);
                sw.Write(html1_1);
                sw.Write(tbxTitre.Text);
                sw.Write(html2);
                sw.Write(tbxTitre.Text);
                sw.Write(html3);
                switch(cbxCategorie.SelectedItem.ToString())
                {
                    case "événement":
                        sw.Write("../evenement");
                        break;
                    case "portrait":
                        sw.Write("../portrait");
                        break;
                    case "paysage":
                        sw.Write("../paysage");
                        break;
                    case "nature":
                        sw.Write("../nature");
                        break;
                    case "street":
                        sw.Write("../street");
                        break;
                    case "divers":
                        sw.Write("../divers");
                        break;
                }
                sw.Write(html3_1);
                sw.Write(cbxCategorie.SelectedItem.ToString());
                sw.Write(html3_2);
                sw.Write(cbxCategorie.SelectedItem.ToString());
                sw.Write(html4);
                sw.Write(tbxDateYYYYMMDD.Text);
                sw.Write(html5);
                sw.Write(tbxDate.Text);
                sw.Write(html6);
                Directory.CreateDirectory(path + "\\" + tbxNom.Text);
                FileInfo[] files = d.GetFiles("*.jpg");
                for(int i = 0; i < files.Length; i++)
                {
                    string imageName = tbxNom.Text + "-" + i.ToString("D3") + ".jpg";
                    string filePath = tbxNom.Text + "/" + imageName;
                    File.Move(files[i].FullName, path + "\\" + tbxNom.Text + "\\" + imageName);
                    sw.Write(htmlimage1);
                    sw.Write(filePath);
                    sw.Write(htmlimage2);
                    sw.Write(filePath);
                    sw.Write(htmlimage3);
                }
                sw.Write(html7);
                sw.Write(tbxText.Text);
                sw.Write(html8);
                sw.Write(tbxTitre.Text);
                sw.Write(html9);
                sw.Write(tbxNom.Text);
                sw.Write(html10);
                sw.Write(tbxTitre.Text);
                sw.Write(html11);
                sw.Write(tbxNom.Text);
                sw.Write(html12);
                sw.Write(tbxNom.Text);
                sw.Write(html13);
                sw.Write(tbxTitre.Text);
                sw.Write(html14);
                sw.Write(tbxNom.Text);
                sw.Write(html15);
                sw.Write(tbxPrecedantNom.Text);
                sw.Write(html16);
                sw.Write(tbxPrecedantTitre.Text);
                sw.Write(html17);
                sw.Write(tbxSuivantNom.Text);
                sw.Write(html18);
                sw.Write(tbxSuivantTitre.Text);
                sw.Write(html19);
                if(tbxRecommande1.Text != "" || tbxRecommande2.Text != "" || tbxRecommande3.Text != "")
                {
                    sw.Write(html20);
                    WriteRecommande(tbxRecommande1.Text, tbxRecommande1Nom.Text, sw);
                    WriteRecommande(tbxRecommande2.Text, tbxRecommande2Nom.Text, sw);
                    WriteRecommande(tbxRecommande3.Text, tbxRecommande3Nom.Text, sw);
                    sw.Write(html27);
                }
                sw.Write(html28);
            }
            MessageBox.Show("Success", "Success", MessageBoxButtons.OK);
        }

        private void WriteRecommande(string titre, string nom, StreamWriter sw)
        {
            if(titre != "" && nom != "")
            {
                sw.Write(html21);
                sw.Write(nom);
                sw.Write(html22);
                sw.Write(nom);
                sw.Write(html23);
                sw.Write(nom);
                sw.Write(html24);
                sw.Write(titre);
                sw.Write(html25);
                sw.Write(nom);
                sw.Write(html26);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
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
    }
}
