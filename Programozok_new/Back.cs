using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozok_new
{
    class Back : Prog, ToCSV, Interface_to_HTML
    {
        int backid;
        int php;
        int python;
        int java;

        public Back(string nev, string beosztas, int tapasztalat, double haviFizetes, int php, int python, int java, int backid, int progid) : base(nev, beosztas, tapasztalat, haviFizetes, progid)
        {
            Php = php;
            Python = python;
            Java = java;
            this.Backid = backid;
        }

        public int Php { get => php; set => php = value; }
        public int Python { get => python; set => python = value; }
        public int Java { get => java; set => java = value; }
        public int Backid { get => backid; set => backid = value; }

        public string tocsv()
        {
            return string.Join(";", this.Nev.ToString(), this.Beosztas, this.Tapasztalat, this.HaviFizetes, php, python, java);
        }

        public string toHTML()
        {
            string vissza = "<tr><td>" + string.Join("</td><td>", this.Nev.ToString(), this.Beosztas, this.Tapasztalat, this.HaviFizetes, php, python, java) + "</td></tr>";
            return vissza;
        }

        public override string ToString()
        {
            return Nev + " - " + Beosztas;
        }
    }
}
