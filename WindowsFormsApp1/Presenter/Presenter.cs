#define Debug

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CastleBetaForm.Model;
using CastleBetaForm.Properties;

namespace CastleBetaForm.Presenter
{
    public class MyPresenter
    {

        CurrentWorld World { get; set; }
        WorldView View { get; set; }
        bool GameStarted = false;
        bool f = false;

        SolidBrush s = new SolidBrush(Color.Black);


        public MyPresenter(CurrentWorld world, WorldView view)
        {
            World = world;
            View = view;
            ConnectAllEvents();
        }

        public void ConnectAllEvents()
        {
            View.buttonStart.Click += buttonStart_Click;
            View.Paint += paint;
            View.MouseClick += MouseClicked;

#if Debug

            View.timerGameStarted.Tick += Timer_tick;
            View.MouseMove += MouseMoved;
#endif


        }

        public void Run()
        {
            Application.Run(View);
        }


        public void buttonStart_Click(object sender, EventArgs e)
        {
            View.buttonStart.Visible = false;
            GameStarted = true;
            View.timerGameStarted.Start();
            View.Refresh();


        }

        protected void paint(object sender, PaintEventArgs e)
        {

            Graphics dc = e.Graphics;


            int xhelper = 0;
            int yhelper = 0;
            int xhelperMob = 0;
            int yhelperMob = 0;
            World.player.CheckedDest(ref xhelper, ref yhelper);
            if (GameStarted)
            {


                if (World.player.ISMoving)
                {

                    View.paintPlayerMoove(this, dc, World.player.CurrentRoom.Background, (int)World.player.LocationX,
                                    (int)World.player.LocationY, xhelper, yhelper);


                }

                else
                {
                    View.paintPlayerStay(this, dc, World.player.CurrentRoom.Background, (int)World.player.LocationX,
                                    (int)World.player.LocationY);
                }

                foreach (AbstractMob mob in World.player.CurrentRoom.Mobs)
                {
                    mob.CheckedDest(ref xhelperMob, ref yhelperMob);
                    View.paintMob(this, dc, (int)mob.LocationX, (int)mob.LocationY, mob.WidthOfImage,
                    mob.HeightOfImage, xhelperMob, yhelperMob, mob.Skin);
                    if (!mob.IsMoving)
                    {
                        Task.Run(() => mob.MoveTo(mob.RandomX(0, View.Width - mob.WidthOfImage), mob.RandomY
                        (0, View.Height - mob.HeightOfImage), View.Width, View.Height));

                    }


                }


            }
            else
            {
                View.paintMainBackGround(this, dc);
            }

        }

        //MoovingofPlayer
        public async void MouseClicked(object sender, MouseEventArgs e)
        {
            int ClickX = e.X;
            int ClickY = e.Y;
            //MoovingofPlayer
            if (!World.player.ISMoving)
            {
                await Task.Run(() => World.player.MoveTo(ClickX, ClickY, World.player.ISMoving));
                World.player.ISMoving = false;
            }
        }



#if Debug
        public void MouseMoved(object sender, MouseEventArgs e)
        {
            View.label1.Text = e.X.ToString() + "   " + e.Y.ToString(); ;


        }

        public void Timer_tick(object sender, EventArgs e)
        {
            CheckDoorsRB();
            CheckMobsRB();
#endif      

            

        }

        public void CheckDoorsRB()
        {

            if (World.player.CurrentRoom.ToNorth != null)
            {
                if (RigidBodyRec.Check(World.player.RigidBody, World.player.CurrentRoom.ToNorth.RigidBody))
                {
                    World.player.CurrentRoom = World.player.CurrentRoom.ToNorth.To;

                }
            }
            if (World.player.CurrentRoom.ToEast != null)
            {
                if (RigidBodyRec.Check(World.player.RigidBody, World.player.CurrentRoom.ToEast.RigidBody))
                {
                    World.player.CurrentRoom = World.player.CurrentRoom.ToEast.To;

                }
            }

            if (World.player.CurrentRoom.ToSouth != null)
            {
                if (RigidBodyRec.Check(World.player.RigidBody, World.player.CurrentRoom.ToSouth.RigidBody))
                {
                    World.player.CurrentRoom = World.player.CurrentRoom.ToSouth.To;

                }
            }
            if (World.player.CurrentRoom.ToWest != null)
            {
                if (RigidBodyRec.Check(World.player.RigidBody, World.player.CurrentRoom.ToWest.RigidBody))
                {
                    World.player.CurrentRoom = World.player.CurrentRoom.ToWest.To;

                }
            }



        }
            
        public void CheckMobsRB()
        {
            foreach (AbstractMob mob in World.player.CurrentRoom.Mobs)
            {
                Task task = new Task(() =>
                {
                    if (RigidBodyRec.Check(World.player.RigidBody, mob.RigidBody))
                    {

                        MessageBox.Show("Ауч");

                        //Started Fight

                    }


                });
                task.Start();
               

            };
        }
    }
}