namespace Hotel_Management_System
{
    partial class FinalizePayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.paymentTypecomboBox = new System.Windows.Forms.ComboBox();
            this.buttoninsert = new System.Windows.Forms.Button();
            this.mainpagebutton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxfoodbill = new System.Windows.Forms.TextBox();
            this.textBoxtax = new System.Windows.Forms.TextBox();
            this.textBoxreservationBill = new System.Windows.Forms.TextBox();
            this.textBoxtotal = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Food Bill";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tax";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Reservation Bill";
            // 
            // paymentTypecomboBox
            // 
            this.paymentTypecomboBox.FormattingEnabled = true;
            this.paymentTypecomboBox.Location = new System.Drawing.Point(41, 145);
            this.paymentTypecomboBox.Name = "paymentTypecomboBox";
            this.paymentTypecomboBox.Size = new System.Drawing.Size(121, 25);
            this.paymentTypecomboBox.TabIndex = 4;
            this.paymentTypecomboBox.Text = "Payment Type";
            // 
            // buttoninsert
            // 
            this.buttoninsert.Location = new System.Drawing.Point(96, 250);
            this.buttoninsert.Name = "buttoninsert";
            this.buttoninsert.Size = new System.Drawing.Size(75, 23);
            this.buttoninsert.TabIndex = 5;
            this.buttoninsert.Text = "Insert";
            this.buttoninsert.UseVisualStyleBackColor = true;
            this.buttoninsert.Click += new System.EventHandler(this.buttoninsert_Click);
            // 
            // mainpagebutton
            // 
            this.mainpagebutton.Location = new System.Drawing.Point(266, 243);
            this.mainpagebutton.Name = "mainpagebutton";
            this.mainpagebutton.Size = new System.Drawing.Size(106, 37);
            this.mainpagebutton.TabIndex = 6;
            this.mainpagebutton.Text = "Main Page";
            this.mainpagebutton.UseVisualStyleBackColor = true;
            this.mainpagebutton.Click += new System.EventHandler(this.mainpagebutton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(419, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Price";
            // 
            // textBoxfoodbill
            // 
            this.textBoxfoodbill.Location = new System.Drawing.Point(391, 33);
            this.textBoxfoodbill.Name = "textBoxfoodbill";
            this.textBoxfoodbill.Size = new System.Drawing.Size(100, 23);
            this.textBoxfoodbill.TabIndex = 8;
            this.textBoxfoodbill.TextChanged += new System.EventHandler(this.textBoxfoodbill_TextChanged);
            // 
            // textBoxtax
            // 
            this.textBoxtax.Location = new System.Drawing.Point(391, 68);
            this.textBoxtax.Name = "textBoxtax";
            this.textBoxtax.Size = new System.Drawing.Size(100, 23);
            this.textBoxtax.TabIndex = 9;
            // 
            // textBoxreservationBill
            // 
            this.textBoxreservationBill.Location = new System.Drawing.Point(391, 104);
            this.textBoxreservationBill.Name = "textBoxreservationBill";
            this.textBoxreservationBill.Size = new System.Drawing.Size(100, 23);
            this.textBoxreservationBill.TabIndex = 10;
            // 
            // textBoxtotal
            // 
            this.textBoxtotal.Location = new System.Drawing.Point(391, 145);
            this.textBoxtotal.Name = "textBoxtotal";
            this.textBoxtotal.Size = new System.Drawing.Size(100, 23);
            this.textBoxtotal.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FinalizePayment
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(503, 332);
            this.Controls.Add(this.textBoxtotal);
            this.Controls.Add(this.textBoxreservationBill);
            this.Controls.Add(this.textBoxtax);
            this.Controls.Add(this.textBoxfoodbill);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.mainpagebutton);
            this.Controls.Add(this.buttoninsert);
            this.Controls.Add(this.paymentTypecomboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FinalizePayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label foodBillAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label taxAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label totalAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxPaymentType;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox foodBilltextbox;
        private System.Windows.Forms.TextBox taxtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resBilltextbox;
        private System.Windows.Forms.TextBox totaltextBox;
        private System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox paymentTypecomboBox;
        private System.Windows.Forms.Button buttoninsert;
        private System.Windows.Forms.Button mainpagebutton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxfoodbill;
        private System.Windows.Forms.TextBox textBoxtax;
        private System.Windows.Forms.TextBox textBoxreservationBill;
        private System.Windows.Forms.TextBox textBoxtotal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}