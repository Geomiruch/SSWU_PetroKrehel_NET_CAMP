using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterTower
{
    internal class WaterTower:ICloneable
    {
        private readonly double _maxWaterLevel;
        public double CurrentWaterLevel 
        {
            get
            {
                return CurrentWaterLevel;
            }
            set
            {
                if(value<0)
                {
                    CurrentWaterLevel = 0;
                }
                else if(value>this._maxWaterLevel)
                {
                    CurrentWaterLevel=this._maxWaterLevel;
                }
                else
                {
                    CurrentWaterLevel = value;
                }
            } 
        }

        public WaterTower(double maxWaterLevel, double currentWaterLevel)
        {
            this._maxWaterLevel = maxWaterLevel;
            this.CurrentWaterLevel = currentWaterLevel;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {

            return $"У вежі зараз {this.CurrentWaterLevel} літрів води з {this._maxWaterLevel} допустимих";

        }
    }
}
