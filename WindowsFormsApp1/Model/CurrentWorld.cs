using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CastleBetaForm.Model.Mobs;
using CastleBetaForm.Model.Rooms;
using CastleBetaForm.Properties;

namespace CastleBetaForm.Model
{
    public class CurrentWorld
    {

        public Castle castle { get; set; }
        public Player player { get; set; }


        public CurrentWorld()
        {
            castle = new Castle();
            castle.addRoom(new BattleRoom(Resources.BattleRoomLeftUp));
            castle.addRoom(new BattleRoom(Resources.BattleRoomDown));
            castle.addRoom(new BattleRoom(Resources.BattleRoomRight));
            castle.addRoom(new ShopRoom());
            castle.addRoom(new SpawnRoom());
            //Set Connections
            //Spawn - Shop 
            castle.Rooms[4].ToNorth = new Door(castle.Rooms[4], castle.Rooms[3]);
            castle.Rooms[3].ToNorth = new Door(castle.Rooms[3], castle.Rooms[4]);

            //Spawn - Battle[0] 
            castle.Rooms[4].ToEast = new Door(castle.Rooms[4], castle.Rooms[0]);
            castle.Rooms[0].ToWest = new Door(castle.Rooms[0], castle.Rooms[4]);

            // Battle[0] - Battle[1] 
            castle.Rooms[0].ToNorth = new Door(castle.Rooms[0], castle.Rooms[1]);
            castle.Rooms[1].ToSouth = new Door(castle.Rooms[1], castle.Rooms[0]);

            //Spawn - Battle[2] 
            castle.Rooms[4].ToWest = new Door(castle.Rooms[4], castle.Rooms[2]);
            castle.Rooms[2].ToEast = new Door(castle.Rooms[2], castle.Rooms[4]);


            ((SpawnRoom)(castle.Rooms[4])).SetDoors();
            ((ShopRoom)(castle.Rooms[3])).SetDoors();
            ((BattleRoom)(castle.Rooms[0])).SetDoors();
            ((BattleRoom)(castle.Rooms[1])).SetDoors(); 
            ((BattleRoom)(castle.Rooms[2])).SetDoors();

            player = new Player(castle.Rooms[4],350,150);
        }

    }
}
