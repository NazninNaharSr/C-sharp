namespace Hotel_Management_System
{
    partial class Admin_Home
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
            this.buttonManageManager = new System.Windows.Forms.Button();
            this.buttonViewGuest = new System.Windows.Forms.Button();
            this.buttonAvailableRoom = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManageManager
            // 
            this.buttonManageManager.Location = new System.Drawing.Point(348, 44);
            this.buttonManageManager.Margin = new System.Windows.Forms.Padding(5);
            this.buttonManageManager.Name = "buttonManageManager";
            this.buttonManageManager.Size = new System.Drawing.Size(188, 39);
            this.buttonManageManager.TabIndex = 0;
            this.buttonManageManager.Text = "Manage Manager";
            this.buttonManageManager.UseVisualStyleBackColor = true;
            this.buttonManageManager.Click += new System.EventHandler(this.buttonManageManager_Click);
            // 
            // buttonViewGuest
            // 
            this.buttonViewGuest.Location = new System.Drawing.Point(348, 145);
            this.buttonViewGuest.Margin = new System.Windows.Forms.Padding(5);
            this.buttonViewGuest.Name = "buttonViewGuest";
            this.buttonViewGuest.Size = new System.Drawing.Size(188, 39);
            this.buttonViewGuest.TabIndex = 1;
            this.buttonViewGuest.Text = "View Guest";
            this.buttonViewGuest.UseVisualStyleBackColor = true;
            this.buttonViewGuest.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAvailableRoom
            // 
            this.buttonAvailableRoom.Location = new System.Drawing.Point(348, 244);
            this.buttonAvailableRoom.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAvailableRoom.Name = "buttonAvailableRoom";
            this.buttonAvailableRoom.Size = new System.Drawing.Size(188, 39);
            this.buttonAvailableRoom.TabIndex = 3;
            this.buttonAvailableRoom.Text = "Available Room";
            this.buttonAvailableRoom.UseVisualStyleBackColor = true;
            this.buttonAvailableRoom.Click += new System.EventHandler(this.buttonAvailableRoom_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(348, 340);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(188, 39);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // Admin_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(903, 494);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonAvailableRoom);
            this.Controls.Add(this.buttonViewGuest);
            this.Controls.Add(this.buttonManageManager);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Admin_Home";
            this.Text = "Admin_Home";
            this.Load += new System.EventHandler(this.Admin_Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManageManager;
        private System.Windows.Forms.Button buttonViewGuest;
        private System.Windows.Forms.Button buttonAvailableRoom;
        private System.Windows.Forms.Button buttonLogout;
    }
}