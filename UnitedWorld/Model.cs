using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitedWorld
{
    class Model
    {
        public Map Map { get; private set; }

        public Model(Map map)
        {
            Map = map;
        }
    }
}
