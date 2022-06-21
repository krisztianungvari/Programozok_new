using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Programozok_new
{
    class Front : Prog, ToCSV, Interface_to_HTML
    {
        int frontid;
        int html;
        int css;
        int javaScript;

        public Front(string nev, string beosztas, int tapasztalat, double haviFizetes, int html, int css, int javaScript, int progid, int frontid) : base(nev, beosztas, tapasztalat, haviFizetes, progid)
        {
            Html = html;
            Css = css;
            JavaScript = javaScript;
            this.frontid = frontid;
        }

        public int Html { get => html; set => html = value; }
        public int Css { get => css; set => css = value; }
        public int JavaScript { get => javaScript; set => javaScript = value; }
        public int Frontid { get => frontid; set => frontid = value; }

        public string tocsv()
        {
            return string.Join(";", this.Nev.ToString(), this.Beosztas, this.Tapasztalat, this.HaviFizetes, html, css, javaScript);
        }

        public string toHTML()
        {
           
          string  vissza = "<tr><td>" + string.Join("</td><td>", this.Nev.ToString(), this.Beosztas, this.Tapasztalat, this.HaviFizetes, html, css, javaScript) + "</td></tr>";
            return vissza;
        }

        public override string ToString()
        {
            return Nev + " - " + Beosztas;
        }
    }
}
