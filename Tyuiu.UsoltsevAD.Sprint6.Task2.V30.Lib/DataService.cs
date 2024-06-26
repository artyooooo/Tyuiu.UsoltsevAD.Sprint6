﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.UsoltsevAD.Sprint6.Task2.V30.Lib
{
    public class DataService : ISprint6Task2V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[stopValue - startValue + 1];
            for (int x = startValue, i = 0; x <= stopValue; i++, x++)
            {
                if ((Math.Sin(x) + 3) != 0)
                {
                    result[i] = Math.Round((5 * x + 2.5) / (Math.Sin(x) + 3) + 2 * x + Math.Cos(x), 2);
                }
                else
                {
                    result[i] = 0;
                }
            }
            return result;
        }
    }
}
