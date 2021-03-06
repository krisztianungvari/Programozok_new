using MySql.Data.MySqlClient;
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

namespace Programozok_new
{
    public partial class Form1 : Form
    {
        public MySqlConnection connection = null;
        public MySqlCommand sql = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frissit();
        }

        public void frissit()
        {
            listBox_Programozok.Items.Clear();
            string frontSql = "SELECT prog.idprog, prog.nev, prog.beosztas, prog.tapasztalat, front.idfront, front.html_ismeret, front.css_ismeret, front.javascript_ismeret FROM prog JOIN front ON prog.idprog = front.idfront";
            string fullSql = "SELECT prog.idprog, prog.nev, prog.beosztas, prog.tapasztalat, full.idfull, full.html_ismeret, full.css_ismeret, full.javascript_ismeret, full.php_ismeret, full.python_ismeret, full.java_ismeret FROM prog JOIN full ON prog.idprog = full.idfull";
            string backSql = "SELECT prog.idprog, prog.nev, prog.beosztas, prog.tapasztalat, back.idback,back.php_ismeret, back.python_ismeret, back.java_ismeret FROM prog JOIN back ON prog.idprog = back.idback";

            MySqlConnectionStringBuilder sw = new MySqlConnectionStringBuilder();
            sw.Server = "localhost";
            sw.UserID = "root";
            sw.Password = "";
            sw.Database = "programozok";
            connection = new MySqlConnection(sw.ConnectionString);
            try
            {
                connection.Open();
                sql = connection.CreateCommand();
                sql.CommandText = backSql;
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int idprog = dr.GetInt32("idprog");
                        string nev = dr.GetString("nev");
                        string beosztas = dr.GetString("beosztas");
                        int tapasztalat = dr.GetInt32("tapasztalat");
                        int php_ismeret = dr.GetInt32("php_ismeret");
                        int python_ismeret = dr.GetInt32("python_ismeret");
                        int java_ismeret = dr.GetInt32("java_ismeret");

                        Back back = new Back(nev, beosztas, tapasztalat, 0, php_ismeret, python_ismeret, java_ismeret, dr.GetInt32("idback"), dr.GetInt32("idprog"));
                        listBox_Programozok.Items.Add(back);
                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            try
            {
                MySqlCommand sql = connection.CreateCommand();
                sql.CommandText = fullSql;
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int idprog = dr.GetInt32("idprog");
                        string nev = dr.GetString("nev");
                        string beosztas = dr.GetString("beosztas");
                        int tapasztalat = dr.GetInt32("tapasztalat");
                        int html_ismeret = dr.GetInt32("html_ismeret");
                        int css_ismeret = dr.GetInt32("css_ismeret");
                        int javascript_ismeret = dr.GetInt32("javascript_ismeret");
                        int php_ismeret = dr.GetInt32("php_ismeret");
                        int python_ismeret = dr.GetInt32("python_ismeret");
                        int java_ismeret = dr.GetInt32("java_ismeret");

                        Full full = new Full(nev, beosztas, tapasztalat, 0, html_ismeret, css_ismeret, javascript_ismeret, python_ismeret, python_ismeret, java_ismeret, dr.GetInt32("idfull"), dr.GetInt32("idprog"));
                        listBox_Programozok.Items.Add(full);
                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            try
            {
                MySqlCommand sql = connection.CreateCommand();
                sql.CommandText = frontSql;
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int idprog = dr.GetInt32("idprog");
                        string nev = dr.GetString("nev");
                        string beosztas = dr.GetString("beosztas");
                        int tapasztalat = dr.GetInt32("tapasztalat");
                        int html_ismeret = dr.GetInt32("html_ismeret");
                        int css_ismeret = dr.GetInt32("css_ismeret");
                        int javascript_ismeret = dr.GetInt32("javascript_ismeret");


                        Front front = new Front(nev, beosztas, tapasztalat, 0, html_ismeret, css_ismeret, javascript_ismeret, dr.GetInt32("idprog"), dr.GetInt32("idfront"));
                        listBox_Programozok.Items.Add(front);
                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        private void button_ujFrontend_Click(object sender, EventArgs e)
        {
            Form_Frontend form_Frontend = new Form_Frontend("new");
            form_Frontend.ShowDialog();
        }

        private void button_ujBackend_Click(object sender, EventArgs e)
        {
            Form_Backend form_Backend = new Form_Backend("new");
            form_Backend.ShowDialog();
        }

        private void button_ujFullstack_Click(object sender, EventArgs e)
        {
            Form_FullStack form_FullStack = new Form_FullStack("new");
            form_FullStack.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan ki szeretne lépni?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                // a kilépési folyamatot lehet vele megszakítni! A Form closing event-et indítottam el, és a Cancel = true ezt megszakítja.
                e.Cancel = true;
            }
        }

        private void listBox_Programozok_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox_Programozok.SelectedIndex < 0)
            {
                return;
            }
            var prog = listBox_Programozok.SelectedItem;
            if (prog.GetType() == typeof(Front))
            {
               
                Form_Frontend front = new Form_Frontend("Show");
                // Az ablakból létrehoztunk egy példányt
                front.Show(); //Megjelenítjük a felhasználó számára!
            }
            else if (prog.GetType() == typeof(Back))
            {
               
                Form_Backend back = new Form_Backend("Show");
                back.Show();
            }
            else if (prog.GetType() == typeof(Full))
            {
                
                Form_FullStack full = new Form_FullStack("Show");
                full.Show();
            }
            else
            {
                MessageBox.Show("Egyik sem!");
            }
        }

        private void button_mentesHTML_Click(object sender, EventArgs e)
        {
            if (listBox_Programozok.Items.Count < 1)
            {
                return;
            }
            // Szétválogatju ka lista elemeit típusonként!
            List<Front> frontend = new List<Front>();
            List<Back> backend = new List<Back>();
            List<Full> fulstack = new List<Full>();
            foreach (var prog in listBox_Programozok.Items)
            {
                
                if (prog.GetType() == typeof(Front))
                {
                    frontend.Add((Front)prog);
                }
                else if (prog.GetType() == typeof(Back))
                {
                    backend.Add((Back)prog);
                }
                else if (prog.GetType() == typeof(Full))
                {
                    fulstack.Add((Full)prog);
                }
                else
                {
                    MessageBox.Show("Nem sikerült!");
                }
            }//Válogatás vége!

            // kiíratás most következik!
            using (StreamWriter sw = new StreamWriter("Programozok.html"))
            {
                sw.WriteLine("<h3>Frontendes programozok</h3>");
                if (frontend.Count > 0)
                {
                    sw.WriteLine("<table><tr><th>" + string.Join("</th><th>", "Név", "Beosztás", "Tapasztalat", "Havi Fizetés", "HTML ismeret", "CSS ismeret", "JavaScript ismeret") + "</th></tr>");
                    foreach (Front front in frontend)
                    {
                        //egy - egy Frontendes programozó minden adata
                        sw.WriteLine(front.toHTML());
                    }
                    sw.WriteLine("</table>");
                    //Frontendes programozók vége!
                }
                else
                {
                    sw.WriteLine("<p>Nincs forntendes!</p>");
                }

            }
            using (StreamWriter sw = new StreamWriter("Programozok.html"))
            {
                sw.WriteLine("<h3>Backendes programozok</h3>");
                if (backend.Count > 0)
                {
                    sw.WriteLine("<table><tr><th>" + string.Join("</th><th>", "Név", "Beosztás", "Tapasztalat", "Havi Fizetés", "Php ismeret", "Python ismeret", "Java ismeret") + "</th></tr>");
                    foreach (Back back in backend)
                    {
                       
                        sw.WriteLine(back.toHTML());
                    }
                    sw.WriteLine("</table>");
                    //Backendesendes programozók vége!
                }
                else
                {
                    sw.WriteLine("<p>Nincs Backendes!</p>");
                }
            }
            using (StreamWriter sw = new StreamWriter("Programozok.html"))
            {
                sw.WriteLine("<h3>Fullstack programozok</h3>");
                if (fulstack.Count > 0)
                {
                    sw.WriteLine("<table><tr><th>" + string.Join("</th><th>", "Név", "Beosztás", "Tapasztalat", "Havi Fizetés", "HTML ismeret", "CSS ismeret", "JavaScript ismeret","Php ismeret","Python ismeret", "Java ismeret") + "</th></tr>");
                    foreach (Full full in fulstack)
                    {
                        sw.WriteLine(full.toHTML());
                    }
                    sw.WriteLine("</table>");
                  
                }
                else
                {
                    sw.WriteLine("<p>Nincs Fullstackes!</p>");
                }

            }


        }
    }
}
