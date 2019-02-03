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
            castle.addRoom(new BattleRoom(null,null,null,null));
            castle.addRoom(new BattleRoom(null, null, null, null));
            castle.addRoom(new BattleRoom(null, null, null, null));
            castle.addRoom(new ShopRoom(null, null, null, null));
            castle.addRoom(new SpawnRoom(castle.Rooms[3], castle.Rooms[1], null, castle.Rooms[2]));
            
            player = new Player(castle.Rooms[4],350,150);
        }

    }
}
