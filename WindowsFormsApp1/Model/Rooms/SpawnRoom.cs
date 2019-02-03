using CastleBetaForm.Model.Mobs;
using CastleBetaForm.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleBetaForm.Model.Rooms
{
    class SpawnRoom:AbstractRoom
    {
        

        public SpawnRoom (AbstractRoom n, AbstractRoom w, AbstractRoom e, AbstractRoom s):base(n,w,e,s)
        {
            addNPC(new  NPC("The Master of game", 30, 30, Resources.Paladin));
            Background = Resources.SpawnRoom;
            addMob(new Hen(30,30));
            addMob(new Hen(100, 200));
            addMob(new Hen(400, 400));
            ToNorth.LocationX =300;
            ToNorth.LocationY = 1;
            ToNorth.Size=new RigidBodyRec(ToNorth.LocationX,ToNorth.LocationY,30,30);

        }

        
    }
}
