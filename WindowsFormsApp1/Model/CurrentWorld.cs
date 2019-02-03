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
            castle.addRoom(new BattleRoom());
            castle.addRoom(new ShopRoom());
            castle.addRoom(new SpawnRoom());
            //Set Connections
            castle.Rooms[4].ToNorth = new Door(castle.Rooms[4], castle.Rooms[3]);
            ((SpawnRoom)(castle.Rooms[4])).SetDoors();

            castle.Rooms[3].ToNorth= new Door(castle.Rooms[3], castle.Rooms[4]);
            ((ShopRoom)(castle.Rooms[3])).SetDoors();

            player = new Player(castle.Rooms[4],350,150);
        }

    }
}
