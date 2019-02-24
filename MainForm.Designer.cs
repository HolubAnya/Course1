namespace OOPcourseWork
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSecondname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAmountKr = new System.Windows.Forms.TextBox();
            this.textBoxCurrencyKr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPercentKr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPercentDp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCurrencyDp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAmountDp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxKr = new System.Windows.Forms.ListBox();
            this.listBoxDp = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonAddKr = new System.Windows.Forms.Button();
            this.buttonAddDp = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Button();
            this.textBoxAmountCh = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.textBoxCurrencyFrom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxCurrencyTo = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(49, 282);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(132, 46);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Sign in";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(49, 246);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(132, 20);
            this.textBoxPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname";
            // 
            // textBoxSecondname
            // 
            this.textBoxSecondname.Location = new System.Drawing.Point(49, 188);
            this.textBoxSecondname.Name = "textBoxSecondname";
            this.textBoxSecondname.Size = new System.Drawing.Size(132, 20);
            this.textBoxSecondname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(49, 127);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(132, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount";
            this.label4.Visible = false;
            // 
            // textBoxAmountKr
            // 
            this.textBoxAmountKr.Location = new System.Drawing.Point(425, 64);
            this.textBoxAmountKr.Name = "textBoxAmountKr";
            this.textBoxAmountKr.Size = new System.Drawing.Size(144, 20);
            this.textBoxAmountKr.TabIndex = 8;
            this.textBoxAmountKr.Visible = false;
            // 
            // textBoxCurrencyKr
            // 
            this.textBoxCurrencyKr.Location = new System.Drawing.Point(425, 105);
            this.textBoxCurrencyKr.Name = "textBoxCurrencyKr";
            this.textBoxCurrencyKr.Size = new System.Drawing.Size(144, 20);
            this.textBoxCurrencyKr.TabIndex = 10;
            this.textBoxCurrencyKr.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Currency";
            this.label5.Visible = false;
            // 
            // textBoxPercentKr
            // 
            this.textBoxPercentKr.Location = new System.Drawing.Point(425, 146);
            this.textBoxPercentKr.Name = "textBoxPercentKr";
            this.textBoxPercentKr.Size = new System.Drawing.Size(144, 20);
            this.textBoxPercentKr.TabIndex = 12;
            this.textBoxPercentKr.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Percent";
            this.label6.Visible = false;
            // 
            // textBoxPercentDp
            // 
            this.textBoxPercentDp.Location = new System.Drawing.Point(425, 355);
            this.textBoxPercentDp.Name = "textBoxPercentDp";
            this.textBoxPercentDp.Size = new System.Drawing.Size(144, 20);
            this.textBoxPercentDp.TabIndex = 18;
            this.textBoxPercentDp.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Percent";
            this.label7.Visible = false;
            // 
            // textBoxCurrencyDp
            // 
            this.textBoxCurrencyDp.Location = new System.Drawing.Point(425, 314);
            this.textBoxCurrencyDp.Name = "textBoxCurrencyDp";
            this.textBoxCurrencyDp.Size = new System.Drawing.Size(144, 20);
            this.textBoxCurrencyDp.TabIndex = 16;
            this.textBoxCurrencyDp.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Currency";
            this.label8.Visible = false;
            // 
            // textBoxAmountDp
            // 
            this.textBoxAmountDp.Location = new System.Drawing.Point(425, 273);
            this.textBoxAmountDp.Name = "textBoxAmountDp";
            this.textBoxAmountDp.Size = new System.Drawing.Size(144, 20);
            this.textBoxAmountDp.TabIndex = 14;
            this.textBoxAmountDp.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Amount";
            this.label9.Visible = false;
            // 
            // listBoxKr
            // 
            this.listBoxKr.FormattingEnabled = true;
            this.listBoxKr.Location = new System.Drawing.Point(602, 35);
            this.listBoxKr.Name = "listBoxKr";
            this.listBoxKr.Size = new System.Drawing.Size(92, 173);
            this.listBoxKr.TabIndex = 19;
            this.listBoxKr.Visible = false;
            // 
            // listBoxDp
            // 
            this.listBoxDp.FormattingEnabled = true;
            this.listBoxDp.Location = new System.Drawing.Point(602, 256);
            this.listBoxDp.Name = "listBoxDp";
            this.listBoxDp.Size = new System.Drawing.Size(92, 160);
            this.listBoxDp.TabIndex = 20;
            this.listBoxDp.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(48, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 42);
            this.label10.TabIndex = 21;
            this.label10.Text = "Bank";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(370, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 28);
            this.label11.TabIndex = 22;
            this.label11.Text = "Kredit";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(370, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 28);
            this.label12.TabIndex = 23;
            this.label12.Text = "Deposit";
            this.label12.Visible = false;
            // 
            // buttonAddKr
            // 
            this.buttonAddKr.Location = new System.Drawing.Point(375, 182);
            this.buttonAddKr.Name = "buttonAddKr";
            this.buttonAddKr.Size = new System.Drawing.Size(194, 26);
            this.buttonAddKr.TabIndex = 24;
            this.buttonAddKr.Text = "Add";
            this.buttonAddKr.UseVisualStyleBackColor = true;
            this.buttonAddKr.Visible = false;
            this.buttonAddKr.Click += new System.EventHandler(this.buttonAddKr_Click);
            // 
            // buttonAddDp
            // 
            this.buttonAddDp.Location = new System.Drawing.Point(375, 390);
            this.buttonAddDp.Name = "buttonAddDp";
            this.buttonAddDp.Size = new System.Drawing.Size(194, 26);
            this.buttonAddDp.TabIndex = 25;
            this.buttonAddDp.Text = "Add";
            this.buttonAddDp.UseVisualStyleBackColor = true;
            this.buttonAddDp.Visible = false;
            this.buttonAddDp.Click += new System.EventHandler(this.buttonAddDp_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(777, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 29);
            this.label13.TabIndex = 26;
            this.label13.Text = "Change money";
            this.label13.Visible = false;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(878, 201);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(69, 29);
            this.Change.TabIndex = 27;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Visible = false;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // textBoxAmountCh
            // 
            this.textBoxAmountCh.Location = new System.Drawing.Point(745, 168);
            this.textBoxAmountCh.Name = "textBoxAmountCh";
            this.textBoxAmountCh.Size = new System.Drawing.Size(72, 20);
            this.textBoxAmountCh.TabIndex = 28;
            this.textBoxAmountCh.Visible = false;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(811, 209);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(41, 13);
            this.result.TabIndex = 29;
            this.result.Text = "label14";
            this.result.Visible = false;
            // 
            // textBoxCurrencyFrom
            // 
            this.textBoxCurrencyFrom.Location = new System.Drawing.Point(830, 168);
            this.textBoxCurrencyFrom.Name = "textBoxCurrencyFrom";
            this.textBoxCurrencyFrom.Size = new System.Drawing.Size(69, 20);
            this.textBoxCurrencyFrom.TabIndex = 30;
            this.textBoxCurrencyFrom.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(759, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Amount";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(827, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Currency from";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(917, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "CurrencyTo";
            this.label16.Visible = false;
            // 
            // textBoxCurrencyTo
            // 
            this.textBoxCurrencyTo.Location = new System.Drawing.Point(910, 168);
            this.textBoxCurrencyTo.Name = "textBoxCurrencyTo";
            this.textBoxCurrencyTo.Size = new System.Drawing.Size(69, 20);
            this.textBoxCurrencyTo.TabIndex = 33;
            this.textBoxCurrencyTo.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(991, 25);
            this.toolStrip1.TabIndex = 35;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::OOP6_7.Properties.Resources.thumbnail_nv_20180516152919_51631;
            this.ClientSize = new System.Drawing.Size(991, 426);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxCurrencyTo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxCurrencyFrom);
            this.Controls.Add(this.result);
            this.Controls.Add(this.textBoxAmountCh);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonAddDp);
            this.Controls.Add(this.buttonAddKr);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBoxDp);
            this.Controls.Add(this.listBoxKr);
            this.Controls.Add(this.textBoxPercentDp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCurrencyDp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxAmountDp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPercentKr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCurrencyKr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAmountKr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSecondname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonSave);
            this.Name = "MainForm";
            this.Text = "Bank";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSecondname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAmountKr;
        private System.Windows.Forms.TextBox textBoxCurrencyKr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPercentKr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPercentDp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCurrencyDp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAmountDp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxKr;
        private System.Windows.Forms.ListBox listBoxDp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonAddKr;
        private System.Windows.Forms.Button buttonAddDp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.TextBox textBoxAmountCh;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox textBoxCurrencyFrom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxCurrencyTo;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

