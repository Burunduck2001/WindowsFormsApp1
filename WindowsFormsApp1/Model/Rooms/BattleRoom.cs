using CastleBetaForm.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleBetaForm.Model.Rooms
{
    class BattleRoom:AbstractRoom
    {
        int Difficulty { get; set; }
       

        public BattleRoom (int difficulty) 
        {
            Difficulty = difficulty;
            
        }

        public BattleRoom()
        {
            this.Background = Resources.BattleRoom;
        }

        public override void SetDoors()
        {
            if (ToNorth != null)
            {
                ToNorth.RigidBody = new RigidBodyRec(299, 0, 64, 50);
            }
            if (ToEast != null)
            {
                ToEast.RigidBody = new RigidBodyRec(750, 260, 40, 25);
            }
            if (ToSouth != null)
            {
                ToSouth.RigidBody = new RigidBodyRec(370, 426, 64, 40);
            }
            if (ToWest != null)
            {
                ToWest.RigidBody = new RigidBodyRec(1, 260, 69, 25);
            }
        }


    }
}
