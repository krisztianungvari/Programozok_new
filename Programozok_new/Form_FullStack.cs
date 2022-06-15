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
    public partial class Form_FullStack : Form
    {
        public Form_FullStack(string funkcio)
        {
            InitializeComponent();
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
    }
}
