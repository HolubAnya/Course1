using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeNVP
{
    public partial class Viev : Form
    {
        public Viev()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler<KeyEventArgs> keyUpEvent = null;

        public event EventHandler<KeyEventArgs> keyDownEvent = null;

        private void keydown(object sender, KeyEventArgs e)
        {
           keyDownEvent.Invoke(sender, e);
        }

        private void keyup(object sender, KeyEventArgs e)
        {
           keyUpEvent.Invoke(sender, e);
        }

        public event EventHandler<PaintEventArgs> myEvent = null;

        private void updateGraphics(object sender, PaintEventArgs e)
        {
            myEvent.Invoke(sender, e);   
        }

        public event EventHandler update = null;

        private void updateScreen(Object sender, KeyEventArgs e)
        {
            update.Invoke(sender, e);
        }

        public event EventHandler start = null;
        /*
        private void buttonStart_Click(object sender, EventArgs e)
        {
            start.Invoke(sender, e);
        }
        */
        private void StartClick(object sender, EventArgs e)
        {
            start.Invoke(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            start.Invoke(sender, e);
        }
    }
}
