﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Animal.Base;
using Model.Place.Base;

namespace Model.Place
{
    public class Cage : ZoneBase<ITerestrial>
    {
        public Cage(String name, int maxi) : base(name, maxi) { }
    }
}
