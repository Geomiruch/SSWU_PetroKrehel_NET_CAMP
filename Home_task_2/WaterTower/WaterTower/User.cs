using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterTower
{
    internal class User
    {
        private readonly string _name;
        private readonly double _consumption;
        private double _used = 0;

        public User(string name, double consumption) 
        {
            this._consumption = consumption;
            this._name = name;
        }

        public double TryToGetWater(WaterTower tower)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Користувач {this._name} набрав {this._used} літрів води з {this._consumption} бажаних";
        }
    }
}
