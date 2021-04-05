using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptApp
{
    public class MoneyInfo
    {
        public double MoneyValue { get; set; }
        public double Weight { get; set; }
        public MoneyInfo(double moneyValue, double weight)
        {
            this.MoneyValue = moneyValue;
            this.Weight = weight;
        }
    }
}
