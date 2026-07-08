namespace windosformATM
{
    partial class ShowHistory
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.SourceAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DestinitionAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dest_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeofOperation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbdateTime = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbFullName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SourceAccount,
            this.DestinitionAccount,
            this.Dest_Name,
            this.Amount,
            this.dateTime,
            this.TypeofOperation});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 100);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(802, 338);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_2);
            // 
            // SourceAccount
            // 
            this.SourceAccount.Text = "Source_Account";
            this.SourceAccount.Width = 133;
            // 
            // DestinitionAccount
            // 
            this.DestinitionAccount.Text = "Dest_Account";
            this.DestinitionAccount.Width = 138;
            // 
            // Dest_Name
            // 
            this.Dest_Name.Text = "Dest_Name";
            this.Dest_Name.Width = 124;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 117;
            // 
            // dateTime
            // 
            this.dateTime.DisplayIndex = 5;
            this.dateTime.Text = "Date Time Of Operation";
            this.dateTime.Width = 242;
            // 
            // TypeofOperation
            // 
            this.TypeofOperation.DisplayIndex = 4;
            this.TypeofOperation.Text = "Operation_Type";
            this.TypeofOperation.Width = 116;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::windosformATM.Properties.Resources._11285820;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(664, 65);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(53, 29);
            this.panel6.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::windosformATM.Properties.Resources._15445793;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(554, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(53, 29);
            this.panel5.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::windosformATM.Properties.Resources.pngtree_money_3d_illustrations_modern_icon_png_image_12920733;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(429, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(53, 29);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::windosformATM.Properties.Resources.bust_in_silhouette_1f464;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(310, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(53, 29);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::windosformATM.Properties.Resources.location_icon_free_vector;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(172, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(53, 29);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::windosformATM.Properties.Resources.account_number_22;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(30, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 29);
            this.panel1.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::windosformATM.Properties.Resources._11285820;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(30, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(53, 36);
            this.panel7.TabIndex = 7;
            // 
            // lbdateTime
            // 
            this.lbdateTime.AutoSize = true;
            this.lbdateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbdateTime.Location = new System.Drawing.Point(89, 21);
            this.lbdateTime.Name = "lbdateTime";
            this.lbdateTime.Size = new System.Drawing.Size(31, 16);
            this.lbdateTime.TabIndex = 8;
            this.lbdateTime.Text = "        ";
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::windosformATM.Properties.Resources.account_number_22;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Location = new System.Drawing.Point(310, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(53, 36);
            this.panel8.TabIndex = 9;
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbFullName.Location = new System.Drawing.Point(374, 21);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(31, 16);
            this.lbFullName.TabIndex = 10;
            this.lbFullName.Text = "        ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::windosformATM.Properties.Resources._137625;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(554, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 36);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::windosformATM.Properties.Resources._9471855;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(664, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 36);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ShowHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.lbdateTime);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "ShowHistory";
            this.Text = "ListView";
            this.Load += new System.EventHandler(this.ShowHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader SourceAccount;
        private System.Windows.Forms.ColumnHeader DestinitionAccount;
        private System.Windows.Forms.ColumnHeader Dest_Name;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader dateTime;
        private System.Windows.Forms.ColumnHeader TypeofOperation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbdateTime;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}