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
    public partial class Form_Backend : Form
    {
        public Form_Backend(string funkcio)
        {
            InitializeComponent();
        }

        private void button_backHozzaadas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_backNev.Text))
            {
                MessageBox.Show("A név megadása kötelező!");
                textBox_backNev.Focus();
                return;
            }
            try
            {
                Program.formnyito.sql.CommandText = $"INSERT INTO `prog` (`idprog`, `nev`, `beosztas`, `tapasztalat`) VALUES(NULL, '{textBox_backNev.Text}', 'backend', '{(int)num_backTapasztalat.Value}');";
                Program.formnyito.sql.ExecuteNonQuery();
                long progid = Program.formnyito.sql.LastInsertedId;
                Program.formnyito.sql.CommandText = $"INSERT INTO `back` (`idback`, `php_ismeret`, `python_ismeret`, `java_ismeret`) VALUES('{progid}', '{num_backPhp.Value}', '{num_backPython.Value}', '{num_backJava}');";
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
