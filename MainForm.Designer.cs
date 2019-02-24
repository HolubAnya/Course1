namespace Exam
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioBDec = new System.Windows.Forms.RadioButton();
            this.radioBMed = new System.Windows.Forms.RadioButton();
            this.radioBCare = new System.Windows.Forms.RadioButton();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.textBName = new System.Windows.Forms.TextBox();
            this.textBPrice = new System.Windows.Forms.TextBox();
            this.textBExD = new System.Windows.Forms.TextBox();
            this.textBDelivery = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxDate = new System.Windows.Forms.ListBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.numericUpDownQ = new System.Windows.Forms.NumericUpDown();
            this.textBCat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQ)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(60, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accounting of cosmetic means";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(61, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(309, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Add new product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(530, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Necessary to order";
            // 
            // radioBDec
            // 
            this.radioBDec.AutoSize = true;
            this.radioBDec.Location = new System.Drawing.Point(56, 155);
            this.radioBDec.Name = "radioBDec";
            this.radioBDec.Size = new System.Drawing.Size(77, 17);
            this.radioBDec.TabIndex = 4;
            this.radioBDec.TabStop = true;
            this.radioBDec.Text = "Decorative";
            this.radioBDec.UseVisualStyleBackColor = true;
            this.radioBDec.CheckedChanged += new System.EventHandler(this.radioBDec_CheckedChanged);
            // 
            // radioBMed
            // 
            this.radioBMed.AutoSize = true;
            this.radioBMed.Location = new System.Drawing.Point(56, 178);
            this.radioBMed.Name = "radioBMed";
            this.radioBMed.Size = new System.Drawing.Size(62, 17);
            this.radioBMed.TabIndex = 5;
            this.radioBMed.TabStop = true;
            this.radioBMed.Text = "Medical";
            this.radioBMed.UseVisualStyleBackColor = true;
            this.radioBMed.CheckedChanged += new System.EventHandler(this.radioBMed_CheckedChanged);
            // 
            // radioBCare
            // 
            this.radioBCare.AutoSize = true;
            this.radioBCare.Location = new System.Drawing.Point(56, 201);
            this.radioBCare.Name = "radioBCare";
            this.radioBCare.Size = new System.Drawing.Size(47, 17);
            this.radioBCare.TabIndex = 6;
            this.radioBCare.TabStop = true;
            this.radioBCare.Text = "Care";
            this.radioBCare.UseVisualStyleBackColor = true;
            this.radioBCare.CheckedChanged += new System.EventHandler(this.radioBCare_CheckedChanged);
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.Location = new System.Drawing.Point(157, 155);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(94, 121);
            this.listBoxCategories.TabIndex = 7;
            // 
            // textBName
            // 
            this.textBName.Location = new System.Drawing.Point(333, 157);
            this.textBName.Name = "textBName";
            this.textBName.Size = new System.Drawing.Size(132, 20);
            this.textBName.TabIndex = 8;
            this.textBName.Text = "Name";
            // 
            // textBPrice
            // 
            this.textBPrice.Location = new System.Drawing.Point(333, 183);
            this.textBPrice.Name = "textBPrice";
            this.textBPrice.Size = new System.Drawing.Size(132, 20);
            this.textBPrice.TabIndex = 9;
            this.textBPrice.Text = "Price";
            // 
            // textBExD
            // 
            this.textBExD.Location = new System.Drawing.Point(333, 209);
            this.textBExD.Name = "textBExD";
            this.textBExD.Size = new System.Drawing.Size(132, 20);
            this.textBExD.TabIndex = 10;
            this.textBExD.Text = "Expiration term";
            // 
            // textBDelivery
            // 
            this.textBDelivery.Location = new System.Drawing.Point(333, 235);
            this.textBDelivery.Name = "textBDelivery";
            this.textBDelivery.Size = new System.Drawing.Size(132, 20);
            this.textBDelivery.TabIndex = 11;
            this.textBDelivery.Text = "Delivery time";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(333, 313);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(132, 34);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxDate
            // 
            this.listBoxDate.FormattingEnabled = true;
            this.listBoxDate.Location = new System.Drawing.Point(582, 155);
            this.listBoxDate.Name = "listBoxDate";
            this.listBoxDate.Size = new System.Drawing.Size(107, 134);
            this.listBoxDate.TabIndex = 13;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(583, 313);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(106, 34);
            this.buttonFind.TabIndex = 14;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // numericUpDownQ
            // 
            this.numericUpDownQ.Location = new System.Drawing.Point(333, 261);
            this.numericUpDownQ.Name = "numericUpDownQ";
            this.numericUpDownQ.Size = new System.Drawing.Size(132, 20);
            this.numericUpDownQ.TabIndex = 15;
            // 
            // textBCat
            // 
            this.textBCat.Location = new System.Drawing.Point(333, 287);
            this.textBCat.Name = "textBCat";
            this.textBCat.Size = new System.Drawing.Size(132, 20);
            this.textBCat.TabIndex = 16;
            this.textBCat.Text = "Category";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Exam.Properties.Resources.THUMBNAIL_Fotolia_124863579_Subscription_Monthly_M;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.textBCat);
            this.Controls.Add(this.numericUpDownQ);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.listBoxDate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBDelivery);
            this.Controls.Add(this.textBExD);
            this.Controls.Add(this.textBPrice);
            this.Controls.Add(this.textBName);
            this.Controls.Add(this.listBoxCategories);
            this.Controls.Add(this.radioBCare);
            this.Controls.Add(this.radioBMed);
            this.Controls.Add(this.radioBDec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Beauty salon";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RadioButton radioBDec;
        public System.Windows.Forms.RadioButton radioBMed;
        public System.Windows.Forms.RadioButton radioBCare;
        public System.Windows.Forms.ListBox listBoxCategories;
        public System.Windows.Forms.TextBox textBName;
        public System.Windows.Forms.TextBox textBPrice;
        public System.Windows.Forms.TextBox textBExD;
        public System.Windows.Forms.TextBox textBDelivery;
        public System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.ListBox listBoxDate;
        public System.Windows.Forms.Button buttonFind;
        public System.Windows.Forms.NumericUpDown numericUpDownQ;
        public System.Windows.Forms.TextBox textBCat;
    }
}

