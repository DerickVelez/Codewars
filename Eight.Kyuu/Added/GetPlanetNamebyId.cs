﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight.Kyuu.Added
{
    public class GetPlanetNamebyId
    {
        public static string GetPlanetName(int id)
        {
            switch (id)
            {
                case 1:
                    return "Mercury";
                case 2:
                    return "Venus";
                case 3:
                    return "Earth";
                case 4:
                    return "Mars";
                case 5:
                    return "Jupiter";
                case 6:
                    return "Saturn";
                case 7:
                    return "Uranus";
                case 8:
                    return "Neptune";
                default:
                    return "Sun";
            }
        }
    }
}
