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

namespace Programozok_new
{
    public partial class Form_Frontend : Form
    {
        string funkcio;
        Front front;
        public Form_Frontend(string funkcio)
        {
            InitializeComponent();
            this.funkcio = funkcio;
        }

        private void button_toHTML_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Mentés siekres");
            }
            else
            {
                MessageBox.Show("Mentés sikertelen");
            }


            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Title = "adatok mentése";
            //saveFileDialog.Filter = "HTML file|*.html";
            ////Nem működik mert nem .NET frameworkben van!!
            //if (Invoke((Action)(() => { saveFileDialog.ShowDialog() })) == DialogResult.OK)
            //{
            //    front.toHTML();
            //    MessageBox.Show("Sikeres mentés!");
            //}
            //else
            //{
            //    MessageBox.Show("Nem történt mentés!");
            //}
        }

        private void button_frontHozzaadas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_frontNev.Text))
            {
                MessageBox.Show("A név megadása kötelező!");
                textBox_frontNev.Focus();
                return;
            }

            try
            {
                Program.formnyito.sql.CommandText = $"INSERT INTO `prog` (`idprog`, `nev`, `beosztas`, `tapasztalat`) VALUES(NULL, '{textBox_frontNev.Text}', 'frontend', '{(int)num_frontTapasztalat.Value}');";
                Program.formnyito.sql.ExecuteNonQuery();
                long progid = Program.formnyito.sql.LastInsertedId;
                Program.formnyito.sql.CommandText = $"INSERT INTO `front` (`idfront`, `html_ismeret`, `css_ismeret`, `javascript_ismeret`) VALUES ('{progid}', '{num_frontHtml.Value}', '{num_frontCss.Value}', '{num_frontJavascript.Value}');";
                Program.formnyito.sql.ExecuteNonQuery();
                MessageBox.Show("Sikeres felvitel!");
                Program.formnyito.frissit();
                this.Close();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form_Frontend_Load(object sender, EventArgs e)
        {
            if (funkcio.Equals("Show"))
            {
                front = (Front)Program.formnyito.listBox_Programozok.SelectedItem;
                textBox_frontNev.Text = front.Nev;
                // Így csak megjeleníteni tudjuk, változtatni nem!
                textBox_frontNev.ReadOnly = true;
                num_frontTapasztalat.Value = front.Tapasztalat;
                num_frontTapasztalat.ReadOnly = true;
                num_frontHtml.Value = front.Html;
                num_frontHtml.ReadOnly = true;
                num_frontCss.Value = front.Css;
                num_frontCss.ReadOnly = true;
                num_frontJavascript.Value = front.JavaScript;
                num_frontJavascript.ReadOnly = true;
                button_frontHozzaadas.Hide();
            }
        }
    }
}
