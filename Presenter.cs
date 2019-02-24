using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace SnakeNVP
{
    class Presenter
    {

        Viev viev = null;
        public int maxXpos { get; set; }
           
        public int maxYpos { get; set; }
            
        public Presenter(Viev viev)
        {
            this.viev = viev;
            this.viev.myEvent += new EventHandler<PaintEventArgs>(viev_myEvent);
            this.viev.update += new EventHandler(viev_update);
            this.viev.keyUpEvent += new EventHandler<KeyEventArgs>(viev_keyUpEvent);
            this.viev.keyDownEvent += new EventHandler<KeyEventArgs>(viev_keyDownEvent);
            this.viev.start += new EventHandler(viev_start);
        }

        void viev_keyUpEvent(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, false);
  
        }

        void viev_keyDownEvent(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, true);
        }

        void viev_myEvent(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (Settings.GameOver == false)
            { 
                for (int i = 0; i < Snake.getList().Count; i++)
                {
                    Brush snakeColour = Settings.defineColour(i);
                    canvas.FillEllipse(snakeColour, new Rectangle(Snake.getList()[i].X * Settings.Width, Snake.getList()[i].Y * Settings.Height, Settings.Width, Settings.Height));
                    canvas.FillEllipse(Brushes.Yellow, new Rectangle(Game.food.X * Settings.Width, Game.food.Y * Settings.Height, Settings.Width, Settings.Height));
                }
            }
            else
            {
                string gameOver = "Game Over \n" + "Final score is " + Settings.Scors + "\n Click to restart \n";
                this.viev.label3.Text = gameOver;
                this.viev.label3.Visible = true;
            }
        }

        void viev_update(object sender, EventArgs e)
        {
            maxYpos = viev.pbCanvas.Size.Height / Settings.Height;
            maxXpos = viev.pbCanvas.Size.Width / Settings.Width;

            if (Settings.GameOver == false)
            {
                Input.defineDirection();
                Game.movePlayer(maxXpos, maxYpos);
            }
            this.viev.label2.Text = Settings.Scors.ToString();
            this.viev.pbCanvas.Invalidate();
        }


        void viev_start(object sender, EventArgs e)
        {
            Game.start();
            this.viev.label3.Visible = false;
            this.viev.label2.Text = Settings.Scors.ToString();
            this.viev.gameTimer.Interval = 200;
            this.viev.gameTimer.Tick += viev_update;
            this.viev.gameTimer.Start();
        }
    }
}
