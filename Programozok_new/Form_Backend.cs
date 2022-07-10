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
    public partial class Form_Backend : Form
    {
        string funkcio;
        Back back;
        public Form_Backend(string funkcio)
        {
            InitializeComponent();
            this.funkcio = funkcio;
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

        private void Form_Backend_Load(object sender, EventArgs e)
        {
            if (funkcio.Equals("Show"))
            {
                back = (Back)Program.formnyito.listBox_Programozok.SelectedItem;
                textBox_backNev.Text = back.Nev;
                textBox_backNev.ReadOnly = true;
                num_backTapasztalat.Value = back.Tapasztalat;
                num_backTapasztalat.ReadOnly = true;
                num_backPhp.Value = back.Php;
                num_backPhp.ReadOnly = true;
                num_backPython.Value = back.Python;
                num_backPython.ReadOnly = true;
                num_backJava.Value = back.Java;
                num_backJava.ReadOnly = true;
                button_backHozzaadas.Hide();
            }
        }

        private void button_toHTML_back_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "adatok mentése";
            saveFileDialog.Filter = "HTML file|*.html";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine(back.toHTML());
                }

                MessageBox.Show("Sikeres mentés!");
            }
            else
            {
                MessageBox.Show("Nem történt mentés!");
            }
        }

        private void button_backmentesCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "adatok mentése";
            saveFileDialog.Filter = "CSV file|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine(back.tocsv());
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
