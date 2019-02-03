using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CastleBetaForm.Model.Rooms;

namespace CastleBetaForm.Model
{
    public class CurrentWorld
    {

        public Castle castle { get; set; }
        public Player player { get; set; }


        public CurrentWorld()
        {
            castle = new Castle();
            castle.addRoom(new BattleRoom());
            castle.addRoom(new BattleRoom());
            castle.addRoom(new SpawnRoom(castle.Rooms[1], castle.Rooms[0], castle.Rooms[0], castle.Rooms[0]));
            castle.addRoom(new BattleRoom());
            player = new Player(castle.Rooms[2],350,150);
        }

    }
}
