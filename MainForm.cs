using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler chosenDec = null;

        private void radioBDec_CheckedChanged(object sender, EventArgs e)
        {
            chosenDec.Invoke(sender, e);
        }

        public event EventHandler chosenMed = null;

        private void radioBMed_CheckedChanged(object sender, EventArgs e)
        {
            chosenMed.Invoke(sender, e);
        }

        public event EventHandler chosenCare = null;

        private void radioBCare_CheckedChanged(object sender, EventArgs e)
        {
            chosenCare.Invoke(sender, e);
        }

        public event EventHandler add = null;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            add.Invoke(sender, e);
        }

        public event EventHandler find = null;

        private void buttonFind_Click(object sender, EventArgs e)
        {
            find.Invoke(sender, e);
        }

        public Presenter Presenter
        {
            get => default(Presenter);
            set
            {
            }
        }
    }
}
