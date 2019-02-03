using CastleBetaForm.Model.Mobs;
using CastleBetaForm.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleBetaForm.Model.Rooms
{
    class ShopRoom : AbstractRoom
    {
        public ShopRoom()
        {
            this.Background = Resources.ShopRoom;
            addMob(new Zombie(100, 100));
            addMob(new Skeleton(200, 200));
        }

        public override void SetDoors()
        {
            ToSouth.RigidBody = new RigidBodyRec(390, 1, 50, 50);
        }

    }
}
