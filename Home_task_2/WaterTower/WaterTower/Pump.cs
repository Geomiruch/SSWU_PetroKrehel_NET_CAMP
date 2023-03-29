using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterTower
{
    internal class Pump
    {
        private readonly double _power;
        private WaterTower _tower;
        private bool _turnedOn = false;
        public Pump(WaterTower tower, double power)
        {
            this._power = power;
            this._tower = (WaterTower)tower.Clone();
        }

        public bool NeedWater()
        {
            throw new NotImplementedException();
        }
        public void TurnOn()
        {

        }
        public void TurnOff()
        {

        }
        public void Fill()
        {

        }
        public override string ToString()
        {
            if(this._turnedOn)
            {
                return $"Помпа працює з потужністю {this._power} літрів води за одиницю часу";
            }
            else
            {
                return $"Помпа вимкнена";
            }
        }
    }
}
