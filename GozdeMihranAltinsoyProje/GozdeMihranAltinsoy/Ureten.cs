﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GozdeMihranAltinsoy
{
    class Ureten : CORHandler
    {
        public override void Istek(SatisYetkisi satisyetkisi)
        {
            if (satisyetkisi.Yetki == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} Ödeme Onaylandı...", this.GetType().Name);
            }

            else if (successor != null)
                successor.Istek(satisyetkisi);
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} Ödeme Onaylanlanmadı...", this.GetType().Name);
            }

        }
    }
}
