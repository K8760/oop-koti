﻿using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Valitse jokin reaalimaailman asia ja suunnittele siitä luokkarakenne UML-editorilla.
             * Tee uusi projekti. Ohjelmoi suunnittelema luokkasi sekä käytä tekemääsi luokkaa edellisten
             * tehtävien mukaisesti.*/

            Mikro mikro = new Mikro();

            mikro.SaakoVirtaa = true;
            mikro.Teho = 1200;
            mikro.Kesto = 10;

            mikro.Kaynnista();

        }
    }
}
