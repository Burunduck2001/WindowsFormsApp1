using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleBetaForm.Model.Rooms
{
    class BossRoom:AbstractRoom
    {
        int Difficulty { get; set; }
        public BossRoom(int difficulty) 
        {
            Difficulty = difficulty;
        }
        public BossRoom()
        {
            
        }
    }
}
