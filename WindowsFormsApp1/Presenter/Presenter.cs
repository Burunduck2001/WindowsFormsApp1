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

        protected  void paint(object sender, PaintEventArgs e)
        {

            Graphics dc = e.Graphics;
         
         
            int xhelper=0;
            int yhelper=0;
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
                    View.paintMob(this, dc,(int)mob.LocationX, (int)mob.LocationY, mob.WidthOfImage,
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


            //Проверка, есть ли рядом нпс
            foreach (NPC nPC in World.player.CurrentRoom.NPCs)
            {
                //Меняем цвет отрисовки нпс, если игрок рядом
                if ((Math.Abs(nPC.LocationX-World.player.LocationX)<20) && (Math.Abs(nPC.LocationY - World.player.LocationY) < 20))
                {
                    nPC.Talk();
                    
                   
                }
                

            }   
        }




#if Debug
        public void MouseMoved(object sender, MouseEventArgs e)
        {
            View.label1.Text = e.X.ToString() + "   " + e.Y.ToString(); ;


        }

        public void Timer_tick(object sender, EventArgs e)
        {
            //View.label1.Text = ((int)World.player.LocationX).ToString() + "   " + ((int)World.player.LocationY).ToString();
            
            if (!f)
            {
                if ((World.player.RigidBody.LocationX == World.player.CurrentRoom.ToNorth.LocationX))
                {
                    World.player.CurrentRoom = World.player.CurrentRoom.ToNorth.To;
                    f = true;
                       
                }
                
            }
        }
#endif

        
    }
}