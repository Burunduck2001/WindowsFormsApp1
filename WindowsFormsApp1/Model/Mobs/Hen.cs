using CastleBetaForm.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleBetaForm.Model.Mobs
{
    class Hen : AbstractMob
    {
        public Hen(int spawnx, int spawny)
        {
            //TODO рандомно спавнть в комнате
            Skin = Resources.chick_48x64;
            LocationX = spawnx;
            LocationY = spawny;
            Speed =(decimal)2;
            WidthOfImage = 25;
            HeightOfImage = 23;
            RigidBody = new RigidBodyRec(spawnx, spawny, WidthOfImage, HeightOfImage);
            CoordsOfImage = new List<int> {16, 45, 64, 43, 112, 45, 64, 43, 13, 109, 61, 107,
                     109, 109, 61, 107, 16, 173, 64, 171, 112, 173,64, 171, 11, 237, 61, 235, 107, 237, 61, 235};

        }
        
    }
}
