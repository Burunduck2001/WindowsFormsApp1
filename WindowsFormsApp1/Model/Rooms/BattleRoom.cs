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
            ToWest.RigidBody = new RigidBodyRec(1, 250, 50, 50);
        }


    }
}
