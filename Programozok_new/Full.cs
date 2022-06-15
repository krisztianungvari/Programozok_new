using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozok_new
{
    class Full : Prog,ToCSV
    {
        int fullid;
        int html;
        int css;
        int javaScript;
        int php;
        int python;
        int java;

        public Full(string nev, string beosztas, int tapasztalat, double haviFizetes, int html, int css, int javaScript, int php, int python, int java, int fullid, int progid) : base(nev, beosztas, tapasztalat, haviFizetes, progid)
        {
            Html = html;
            Css = css;
            JavaScript = javaScript;
            Php = php;
            Python = python;
            Java = java;
            this.fullid = fullid;
        }

        public int Html { get => html; set => html = value; }
        public int Css { get => css; set => css = value; }
        public int JavaScript { get => javaScript; set => javaScript = value; }
        public int Php { get => php; set => php = value; }
        public int Python { get => python; set => python = value; }
        public int Java { get => java; set => java = value; }
        public int Fullid { get => fullid; set => fullid = value; }

        public string tocsv()
        {
            return string.Join(";", this.Nev.ToString(), this.Beosztas, this.Tapasztalat, this.HaviFizetes, html, css, javaScript, php, python, java);
        }
        public override string ToString()
        {
            return Nev + " - " + Beosztas;
        }
    }
}
