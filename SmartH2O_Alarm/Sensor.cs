using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartH2O_Alarm
{
    class Sensor
    {
        public string name;

        public float eqVal;
        public int eqStatus;

        public float grVal;
        public int grStatus;

        public float lsVal;
        public int lsStatus;

        public float btMax;
        public float btMin;
        public int btStatus;

        public int status;

        public Sensor(string name)
        {
            this.name = name;
        }

    }

}
