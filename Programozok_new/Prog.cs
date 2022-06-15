using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozok_new
{
    class Prog
    {
        int id;
        string nev;
        string beosztas;
        int tapasztalat;
        double haviFizetes;

        public Prog(string nev, string beosztas, int tapasztalat, double haviFizetes, int id)
        {
            Nev = nev;
            Beosztas = beosztas;
            Tapasztalat = tapasztalat;
            HaviFizetes = haviFizetes;
            this.Id = id;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Beosztas { get => beosztas; set => beosztas = value; }
        public int Tapasztalat { get => tapasztalat; set => tapasztalat = value; }
        public double HaviFizetes { get => haviFizetes; set => haviFizetes = value; }
        public int Id { get => id; set => id = value; }
    }
}
