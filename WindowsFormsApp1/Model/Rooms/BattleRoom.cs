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

        public BattleRoom(AbstractRoom n, AbstractRoom e, AbstractRoom s, AbstractRoom w) : base(n, e, s, w)
        {
            Background = Resources.BattleRoom;
            ToNorth.RigidBody = null;
            ToEast.RigidBody = null;
            ToWest.RigidBody = null;
            ToSouth.RigidBody = null;

        }




    }
}
