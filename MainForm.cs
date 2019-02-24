using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOPcourseWork
{
    public partial class MainForm : Form
    {
        
        Settings _settings = null;
        //Kredit kredit = new Kredit();
        //Deposit deposit = new Deposit();

        
        internal static List<Offer> kredits = new List<Offer>();
        internal static List<Offer> deposits = new List<Offer>();

        public MainForm()
        {
            InitializeComponent();

            _settings = Settings.GetSettings();


            _initControlls();
        }
        private void _initControlls()
        {
            textBoxName.Text = _settings.Name;
            textBoxSecondname.Text = _settings.Secondname;
            textBoxPassword.Text = _settings.Password;

           
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _settings.Name = textBoxName.Text;
            _settings.Secondname = textBoxSecondname.Text;
            _settings.Password = textBoxPassword.Text;

            _settings.Save();
            Account account = new Account(textBoxName.Text, textBoxSecondname.Text, textBoxPassword.Text);
            _settings = Settings.GetSettings();

            if(!account.DoesExist())
                account.AddAccount(account);

            textBoxAmountDp.Text = _settings.amountDp;
            textBoxPercentDp.Text = _settings.percentDp;
            textBoxCurrencyDp.Text = _settings.currencyDp;

            textBoxAmountKr.Text = _settings.amountKr;
            textBoxPercentKr.Text = _settings.percentKr;
            textBoxCurrencyKr.Text = _settings.currencyKr;

            label4.Visible = label5.Visible = label6.Visible = label7.Visible = label8.Visible = label9.Visible = label11.Visible = label12.Visible = listBoxDp.Visible = listBoxKr.Visible = textBoxAmountKr.Visible = textBoxAmountDp.Visible = textBoxCurrencyDp.Visible = textBoxCurrencyKr.Visible = textBoxPercentDp.Visible = textBoxPercentKr.Visible = buttonAddKr.Visible = buttonAddDp.Visible = label14.Visible = label15.Visible = label16.Visible = label13.Visible = textBoxAmountCh.Visible = textBoxCurrencyTo.Visible = textBoxCurrencyFrom.Visible = Change.Visible = true;
        }

        private void buttonAddKr_Click(object sender, EventArgs e)
        {
            Account account = new Account(textBoxName.Text, textBoxSecondname.Text, textBoxPassword.Text);
            
            if (Convert.ToInt32(textBoxAmountKr.Text) > 1 && Convert.ToInt32(textBoxPercentKr.Text) > 0)
            {
                Kredit kredit = new Kredit(Convert.ToInt32(textBoxAmountKr.Text), Convert.ToInt32(textBoxPercentKr.Text), textBoxCurrencyKr.Text);
                account.AddKredit(kredit);
                foreach (Offer kr in account.GetKredits())
                {
                    listBoxKr.Items.Add(kr.Show());

                }
                

                _settings.amountKr = textBoxAmountKr.Text;
                _settings.currencyKr = textBoxCurrencyKr.Text;
                _settings.percentKr = textBoxPercentKr.Text;

                _settings.Save();
                
            }
            else
            {
                MessageBox.Show("Try to fill all fields correctly");
            }
        }

        private void buttonAddDp_Click(object sender, EventArgs e)
        {
            Account account = new Account(textBoxName.Text, textBoxSecondname.Text, textBoxPassword.Text);
            if (Convert.ToInt32(textBoxAmountDp.Text) > 1 && Convert.ToInt32(textBoxPercentDp.Text) > 0)
            {
                Deposit deposit = new Deposit(Convert.ToInt32(textBoxAmountDp.Text), Convert.ToInt32(textBoxPercentDp.Text), textBoxCurrencyDp.Text);
                account.AddDeposit(deposit);
                foreach (Offer dp in account.GetDeposits())
                {
                    listBoxDp.Items.Add(dp.Show());

                }
                _settings.amountDp = textBoxAmountDp.Text;
                _settings.currencyDp = textBoxCurrencyDp.Text;
                _settings.percentDp = textBoxPercentDp.Text;

                _settings.Save();

            }
            else
            {
                MessageBox.Show("Try to fill all fields correctly");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label11.BackColor = Color.Transparent;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Change_Click(object sender, EventArgs e)
        {

            if (textBoxAmountCh.Text != "" || textBoxCurrencyFrom.Text != "" || textBoxCurrencyTo.Text != "")
            {
                result.Text = Changer.change(Convert.ToDouble(textBoxAmountCh.Text), Changer.choose(textBoxCurrencyFrom.Text), Changer.choose(textBoxCurrencyTo.Text)).ToString();
                result.Visible = true;
            }
            else
            {
                MessageBox.Show("Try to fill all fields correctly");
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            Changer.num(Changer.grivna);
            Changer.num(Changer.dollar);
            Changer.num(Changer.euro);
            Changer.num(Changer.rubl);

        }
    }
}
