﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week08.Abstractions;

namespace week08.Entities
{
    public class BallFactory : IToyFactory
    {
        public Color BallColor { get; set; }
        public Abstractions.Toy CreateNew()
        {
            return new Ball(BallColor);
        }
    }
}
