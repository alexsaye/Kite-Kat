﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KiteKat.EcsCore.Components;

namespace KiteKat.Components
{
    class Kite : IEcsComponent
    {
        public int RopeEntity;
        public int PlayerEntity;
    }
}