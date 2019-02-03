using CastleBetaForm.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleBetaForm.Model.Mobs
{
    class Skeleton : AbstractMob
    {
        public Skeleton(decimal spawnx, decimal spawny)
        {
            Skin = Resources.ZombieAndSkeleton;
            LocationX = spawnx;
            LocationY = spawny;
            Speed = (decimal)0.5;
            WidthOfImage = 32;
            HeightOfImage = 49;
            CoordsOfImage = new List<int> {192, 207, 223, 207, 255, 207, 223, 207,
                                            192, 143, 224, 143, 256, 143, 224, 143,
                                            193 , 15, 224, 15, 255, 15, 224, 15,
                                            192, 79, 224, 79, 256, 79, 224, 79};
        }
    }
}