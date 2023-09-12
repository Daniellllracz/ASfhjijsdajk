using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASfhjijsdajk.src
{
    class Sportolo
    {
        public string Nev { get; set; }
        public bool Kategoria { get; set; }
        public string Egyesulet { get; set; }

        public int[] PontSzamok { get; set; }

        public Sportolo(string r)
        {
            var v = r.Split(';');
            Nev = v[0];
            Kategoria = v[1] == "Felnott ferfi";
            Egyesulet = v[2] == "n.a." ? null : v[2];
            PontSzamok = new int[8];
            for (int i = 0; i < PontSzamok.Length; i++)
            {
                PontSzamok[i] = int.Parse(v[i + 3]);

            }
        }

    }
}
