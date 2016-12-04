using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense.Classes
{
    public class Configuration
    {
        public Map getMap()
        {
            return new Map();
        }

        public int getNbTower()
        {
            return 0;
        }

        public int getNbLevel()
        {
            return 0;
        }

        public List<Mob> getMobs()
        {
            return new List<Mob>();
        }

        public int getNbLifes()
        {
            return 0;
        }
    }
}
