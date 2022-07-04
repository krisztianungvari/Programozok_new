using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programozok_new
{
    public partial class Form_FullStack : Form
    {
        string funkcio;
        Full full;
        public Form_FullStack(string funkcio)
        {
            InitializeComponent();
            this.funkcio = funkcio;
        }

        private void button_fullstackHozzaadas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_fullstackNev.Text))
            {
                MessageBox.Show("A név megadása kötelező!");
                textBox_fullstackNev.Focus();
                return;
            }
            try
            {
                Program.formnyito.sql.CommandText = $"INSERT INTO `prog` (`idprog`, `nev`, `beosztas`, `tapasztalat`) VALUES (NULL, '{textBox_fullstackNev.Text}', 'fullstack', '{(int)num_fullstackTapasztalat.Value}');";
                Program.formnyito.sql.ExecuteNonQuery();
                long progid = Program.formnyito.sql.LastInsertedId;
                Program.formnyito.sql.CommandText = $"INSERT INTO `full` (`idfull`, `html_ismeret`, `css_ismeret`, `javascript_ismeret`, `php_ismeret`, `python_ismeret`, `java_ismeret`) VALUES ('{progid}', '{num_fullstackHtml.Value}', '{num_fullstackCss.Value}', '{num_fullstackJavascript.Value}', '{num_fullstackPhp.Value}', '{num_fullstackPython.Value}', '{num_fullstackJava.Value}');";
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

        private void Form_FullStack_Load(object sender, EventArgs e)
        {
            if (funkcio.Equals("Show"))
            {
                full = (Full)Program.formnyito.listBox_Programozok.SelectedItem;
                textBox_fullstackNev.Text = full.Nev;
                textBox_fullstackNev.ReadOnly = true;
                num_fullstackTapasztalat.Value = full.Tapasztalat;
                num_fullstackTapasztalat.ReadOnly = true;
                num_fullstackHtml.Value = full.Html;
                num_fullstackHtml.ReadOnly = true;
                num_fullstackCss.Value = full.Css;
                num_fullstackCss.ReadOnly = true;
                num_fullstackJavascript.Value = full.JavaScript;
                num_fullstackJavascript.ReadOnly = true;
                num_fullstackPhp.Value = full.Php;
                num_fullstackPhp.ReadOnly = true;
                num_fullstackPython.Value = full.Python;
                num_fullstackPython.ReadOnly = true;
                num_fullstackJava.Value = full.Java;
                num_fullstackJava.ReadOnly = true;
                button_fullstackHozzaadas.Hide();
            }
        }

        private void button_toHTML_full_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "adatok mentése";
            saveFileDialog.Filter = "HTML file|*.html";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine(full.toHTML());
                }

                MessageBox.Show("Sikeres mentés!");
            }
            else
            {
                MessageBox.Show("Nem történt mentés!");
            }
        }
    }
}
