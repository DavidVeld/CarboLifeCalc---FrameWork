using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarboLifeAPI.Data
{
    [Serializable]
    public class CarboSeqProperties
    {
        public string propertyName { get; set; }
        public double value { get; set; }
        public int sequestrationPeriod { get; set; }
        public string comment { get; set; }
        public CarboSeqProperties()
        {
            propertyName = "Sequestration";
            value = 0;
            sequestrationPeriod = 40;
            comment = "";
        }

        public void calculate()
        {

        }
    }
}
