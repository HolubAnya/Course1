using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exam
{
    public class Presenter
    {
        MainForm viev = null;


        public Presenter(MainForm viev)
        {
            this.viev = viev;
            this.viev.find += new EventHandler(viev_find);
            this.viev.add += new EventHandler(viev_add);
            this.viev.chosenDec += new EventHandler(viev_chosenDec);
            this.viev.chosenMed += new EventHandler(viev_chosenMed);
            this.viev.chosenCare += new EventHandler(viev_chosenCare);

        }

        public MainForm MainForm
        {
            get => default(MainForm);
            set
            {
            }
        }

        private void viev_chosenCare(object sender, EventArgs e)
        {
            this.viev.listBoxCategories.Items.Clear();

            foreach (Cosmetics item in CCare.getList())
            {
                this.viev.listBoxCategories.Items.Add(item.show());
            }
        }

        private void viev_chosenMed(object sender, EventArgs e)
        {
            this.viev.listBoxCategories.Items.Clear();

            foreach (Cosmetics item in CMedical.getList())
            {
                this.viev.listBoxCategories.Items.Add(item.show());
            }
        }

        private void viev_chosenDec(object sender, EventArgs e)
        {
            this.viev.listBoxCategories.Items.Clear();

            foreach (Cosmetics item in CDecorative.getList())
            {
                this.viev.listBoxCategories.Items.Add(item.show());
            }
        }

        void viev_find(object sender, EventArgs e)
        {
            this.viev.listBoxDate.Items.Clear();
            CCare care = new CCare();
            CDecorative decorative = new CDecorative();
            CMedical medical = new CMedical();
            care.findNecessary(CCare.getList(), care.Term, care.WaitNum, care.ExNum);
            decorative.findNecessary(CDecorative.getList(), decorative.Term, decorative.WaitNum, decorative.ExNum);
            medical.findNecessary(CMedical.getList(), medical.Term, medical.WaitNum, medical.ExNum);
            
            foreach (Cosmetics item in Cosmetics.getExCosmetics())
            {
                this.viev.listBoxDate.Items.Add(item.show());
            }

        }

        void viev_add(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.viev.textBPrice.Text) >= 0 || Convert.ToInt32(this.viev.numericUpDownQ.Value) >= 0 || Convert.ToInt32(this.viev.textBExD.Text) >= 0 || Convert.ToInt32(this.viev.textBDelivery.Text) >= 0)
            {
                if (this.viev.textBCat.Text == "care" || this.viev.textBCat.Text == "Care")
                {
                    if (Cosmetics.ifExist(CCare.getList(), this.viev.textBCat.Text)) { return; }

                    Cosmetics care = new CCare(this.viev.textBName.Text, Convert.ToInt32(this.viev.textBPrice.Text), Convert.ToInt32(this.viev.numericUpDownQ.Value), Convert.ToInt32(this.viev.textBDelivery.Text), Convert.ToInt32(this.viev.textBExD.Text));
                    care.addNew(care);
                }
                else if (this.viev.textBCat.Text == "decorative" || this.viev.textBCat.Text == "Decorative")
                {
                    if (Cosmetics.ifExist(CDecorative.getList(), this.viev.textBCat.Text)) { return; }

                    Cosmetics decorative = new CDecorative(this.viev.textBName.Text, Convert.ToInt32(this.viev.textBPrice.Text), Convert.ToInt32(this.viev.numericUpDownQ.Value), Convert.ToInt32(this.viev.textBExD.Text), Convert.ToInt32(this.viev.textBExD.Text));
                    decorative.addNew(decorative);
                }
                else if (this.viev.textBCat.Text == "medical" || this.viev.textBCat.Text == "Medical")
                {
                    if (Cosmetics.ifExist(CMedical.getList(), this.viev.textBCat.Text)) { return; }

                    Cosmetics medical = new CMedical(this.viev.textBName.Text, Convert.ToInt32(this.viev.textBPrice.Text), Convert.ToInt32(this.viev.numericUpDownQ.Value), Convert.ToInt32(this.viev.textBExD.Text), Convert.ToInt32(this.viev.textBExD.Text));
                    medical.addNew(medical);
                }
                else
                {
                    MessageBox.Show("Try to fill category field correctly");
                }

            }
            else
            {
                MessageBox.Show("Try to fill all fields correctly");
            }

        }
    }
}