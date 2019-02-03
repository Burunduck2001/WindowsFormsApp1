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
        

        public SpawnRoom (AbstractRoom n, AbstractRoom e, AbstractRoom s, AbstractRoom w):base(n,e,s,w)
        {
            addNPC(new  NPC("The Master of game", 30, 30, Resources.Paladin));
            Background = Resources.SpawnRoom;
            addMob(new Hen(30,30));
            addMob(new Hen(100, 200));
            addMob(new Hen(400, 400));
            ToNorth.LocationX = 270;
            ToNorth.LocationY = 1;
            ToNorth.RigidBody=new RigidBodyRec(ToNorth.LocationX,ToNorth.LocationY,50,50);
            ToEast.LocationX = 0;
            ToEast.LocationY = 430;
            ToEast.RigidBody= new RigidBodyRec(ToEast.LocationX, ToEast.LocationY, 50, 50);
            ToWest.LocationX = 750;
            ToWest.LocationY = 430;
            ToWest.RigidBody= new RigidBodyRec(ToWest.LocationX, ToWest.LocationY, 50, 50);

        }

        
    }
}
