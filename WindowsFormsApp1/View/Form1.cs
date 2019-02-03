using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CastleBetaForm.Presenter;
using CastleBetaForm.Properties;

namespace CastleBetaForm
{
    public partial class WorldView : Form
    {
        public WorldView()
        {
            InitializeComponent();
            this.Icon = Resources.fortress__1_;//Иконка
        }

        private void timerGameStarted_Tick(object sender, EventArgs e)
        {
            this.Refresh();


        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WorldView_Load(object sender, EventArgs e)
        {

        }

        public void paintPlayerMoove(object sender, Graphics dc, Bitmap CurrentRoom,int x,int y,int xhelper, int yhelper)
        {

            Rectangle ModelOfPlayer;//Ищем нужную текстуру игрока для движения
            dc.DrawImage(CurrentRoom, new Rectangle(0, 0, this.Width, this.Height));
            ModelOfPlayer = new Rectangle(xhelper, yhelper, 30, 60);
            Rectangle PlayerRectangle = new Rectangle(x, y, ModelOfPlayer.Width, ModelOfPlayer.Height);
            dc.DrawImage(Skin, PlayerRectangle, ModelOfPlayer, GraphicsUnit.Pixel);       
                
        }

        public void paintMainBackGround(object sender, Graphics dc)
        {
            
            dc.DrawImage(Resources.MainBackGround, new Rectangle(0, 0, this.Width, this.Height));
        }

        public void paintPlayerStay(object sender, Graphics dc, Bitmap CurrentRoom, int x, int y)
        {
            dc.DrawImage(CurrentRoom, new Rectangle(0, 0, this.Width, this.Height));
            Rectangle ModelOfPlayer;//Ищем нужную текстуру игрока для движения           
            ModelOfPlayer = new Rectangle(56, 137, 30, 60);
            Rectangle PlayerRectangle = new Rectangle(x, y, ModelOfPlayer.Width, ModelOfPlayer.Height);
            dc.DrawImage(Skin, PlayerRectangle, ModelOfPlayer, GraphicsUnit.Pixel);

        }

        public void paintNPC(object sender, Graphics dc, int LocationX, int LocationY, Bitmap skin)
        {
            dc.DrawImage(skin, LocationX, LocationY);
         
        }

        public void paintMob(object sender, Graphics dc, int x, int y, int width, int height,
                               int xhelper, int yhelper, Bitmap SkinOfMob)
        {

            Rectangle ModelOfMob;//Ищем нужную текстуру игрока для МОБА           
            ModelOfMob = new Rectangle(xhelper, yhelper, width, height);
            Rectangle MobRectangle = new Rectangle(x, y, ModelOfMob.Width, ModelOfMob.Height);
            dc.DrawImage(SkinOfMob, MobRectangle, ModelOfMob, GraphicsUnit.Pixel);

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



    }
