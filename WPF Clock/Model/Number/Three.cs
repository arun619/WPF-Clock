﻿using WPF_Clock.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Clock.Model.Number
{
    public class Three : Figure
    {
        private static float[,] POINTS = {
            {0.361878453038674f, 0.298342541436464f},   {0.348066298342541f, 0.149171270718232f},   {0.475138121546961f, 0.0994475138121547f},
            {0.549723756906077f, 0.0994475138121547f},  {0.861878453038674f, 0.0994475138121547f},  {0.806629834254144f, 0.530386740331492f},
            {0.549723756906077f, 0.530386740331492f},   {0.87292817679558f,  0.530386740331492f},   {0.828729281767956f, 0.994475138121547f},
            {0.552486187845304f, 0.994475138121547f},   {0.298342541436464f, 0.994475138121547f},   {0.30939226519337f,  0.828729281767956f},
            {0.312154696132597f, 0.790055248618785f}
        };

        private static Three INSTANCE = new Three();

        protected Three() : base(POINTS)
        {
        }

        public static Three getInstance()
        {
            return INSTANCE;
        }
    }
}