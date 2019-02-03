using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleBetaForm.Model
{
    public abstract class AbstractRoom:Connection
    {
        public List<AbstractMob> Mobs = new List<AbstractMob> { };
        public Bitmap Background { get; set; }
        public List<NPC> NPCs = new List<NPC>();
        public Door ToNorth { get; set; }
        public Door ToEast { get; set; }
        public Door ToSouth { get; set; }
        public Door ToWest { get; set; }

        //TODO Make random generation of room
        //TODO List of furnitures (mebel)

        int MEBELX = 3;
        int MEBELY = 3;

        
        public AbstractRoom()
        {

        }

        public void addNPC(NPC npc)
        {
            NPCs.Add(npc);
        }

        public void addMob(AbstractMob mob)
        {
            Mobs.Add(mob);
        }

        public virtual void SetDoors()
        {
           
        }
    }
}
