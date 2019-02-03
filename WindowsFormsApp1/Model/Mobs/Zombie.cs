using CastleBetaForm.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleBetaForm.Model.Mobs
{
    class Zombie : AbstractMob
    {
        public Zombie(decimal spawnx, decimal spawny)
        {
            Skin = Resources.ZombieAndSkeleton;
            LocationX = spawnx;
            LocationY = spawny;
            Speed = (decimal)0.5;
            WidthOfImage = 32;
            HeightOfImage = 41;
            CoordsOfImage = new List<int>{0, 215, 32, 215, 64, 215, 32, 215,
                                        0, 151, 32, 151, 64, 151, 32, 151,
                                        0, 23, 33, 23, 65, 23, 33, 23,
                                        0, 87, 32, 87, 64 , 87, 32, 87};
        }
    }
}