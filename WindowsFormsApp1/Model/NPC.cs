using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleBetaForm.Model
{
    public  class NPC
    {

        string Name { get; set; }
        int HP = 100; 
        List<Quest> Quests { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public Bitmap Skin { get; set; }
        public bool ForTest = false;
        

        public NPC  (string name, int x, int y, Bitmap skin)
        {
            LocationX = x;
            LocationY = y;
            Name = name;
            Skin = skin;
            
        }
        
        public void addQuest(Quest quest)
        {
            Quests.Add(quest);
        }

        public void Talk()
        {
            ForTest = true;
        }
        
    }
}
