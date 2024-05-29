using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.UsoltsevAD.Sprint6.Task1.V30.Lib
{
    public class DataService : ISprint6Task1V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[Math.Abs(startValue) + Math.Abs(stopValue) + 1];
            for (int i = startValue, x = 0; i <= stopValue; i++, x++)
            {
                if ((Math.Cos(i) - 2 * x) != 0)
                {
                    result[x] = Math.Round((2 * i - 3) / (Math.Cos(i) - 2 * i) + 5 * x - 6, 2);
                }
                else
                {
                    result[x] = 0;
                }
            }
            return result;
        }
    }
}
