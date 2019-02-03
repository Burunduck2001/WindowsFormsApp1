using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CastleBetaForm.Model.Rooms;

namespace CastleBetaForm.Model
{
    public  class Castle 
    {

        public List<AbstractRoom> Rooms = new List<AbstractRoom>(); //Rooms that u get in yuor castle
        int Size { get; set; }  // Set the numbers of monsters and rooms
        int Difficulty { get; set; } // Set the difficulty of castle

        public void addRoom(AbstractRoom room)
        {
            Rooms.Add(room);
        }

        

    }
}
