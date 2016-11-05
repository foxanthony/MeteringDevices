﻿namespace MeteringDevices
{
    partial class MainForm
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
            this.tb_Day = new System.Windows.Forms.TextBox();
            this.lb_Day = new System.Windows.Forms.Label();
            this.bt_Send = new System.Windows.Forms.Button();
            this.lb_Cold = new System.Windows.Forms.Label();
            this.tb_Night = new System.Windows.Forms.TextBox();
            this.lb_Night = new System.Windows.Forms.Label();
            this.tb_Hot = new System.Windows.Forms.TextBox();
            this.lb_Hot = new System.Windows.Forms.Label();
            this.tb_Cold = new System.Windows.Forms.TextBox();
            this.tb_Kitchen = new System.Windows.Forms.TextBox();
            this.lb_Kitchen = new System.Windows.Forms.Label();
            this.tb_Room = new System.Windows.Forms.TextBox();
            this.lb_Room = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Day
            // 
            this.tb_Day.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Day.Location = new System.Drawing.Point(223, 6);
            this.tb_Day.Name = "tb_Day";
            this.tb_Day.Size = new System.Drawing.Size(191, 22);
            this.tb_Day.TabIndex = 7;
            this.tb_Day.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lb_Day
            // 
            this.lb_Day.AutoSize = true;
            this.lb_Day.Location = new System.Drawing.Point(12, 9);
            this.lb_Day.Name = "lb_Day";
            this.lb_Day.Size = new System.Drawing.Size(205, 17);
            this.lb_Day.TabIndex = 1;
            this.lb_Day.Text = "Дневное энергопотребление:";
            // 
            // bt_Send
            // 
            this.bt_Send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Send.Location = new System.Drawing.Point(15, 181);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(399, 30);
            this.bt_Send.TabIndex = 13;
            this.bt_Send.Text = "Отправить!";
            this.bt_Send.UseVisualStyleBackColor = true;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click);
            // 
            // lb_Cold
            // 
            this.lb_Cold.AutoSize = true;
            this.lb_Cold.Location = new System.Drawing.Point(105, 65);
            this.lb_Cold.Name = "lb_Cold";
            this.lb_Cold.Size = new System.Drawing.Size(112, 17);
            this.lb_Cold.TabIndex = 3;
            this.lb_Cold.Text = "Холодная вода:";
            // 
            // tb_Night
            // 
            this.tb_Night.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Night.Location = new System.Drawing.Point(223, 34);
            this.tb_Night.Name = "tb_Night";
            this.tb_Night.Size = new System.Drawing.Size(191, 22);
            this.tb_Night.TabIndex = 8;
            this.tb_Night.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lb_Night
            // 
            this.lb_Night.AutoSize = true;
            this.lb_Night.Location = new System.Drawing.Point(20, 37);
            this.lb_Night.Name = "lb_Night";
            this.lb_Night.Size = new System.Drawing.Size(197, 17);
            this.lb_Night.TabIndex = 2;
            this.lb_Night.Text = "Ночное энергопотребление:";
            // 
            // tb_Hot
            // 
            this.tb_Hot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Hot.Location = new System.Drawing.Point(223, 90);
            this.tb_Hot.Name = "tb_Hot";
            this.tb_Hot.Size = new System.Drawing.Size(191, 22);
            this.tb_Hot.TabIndex = 10;
            this.tb_Hot.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lb_Hot
            // 
            this.lb_Hot.AutoSize = true;
            this.lb_Hot.Location = new System.Drawing.Point(114, 93);
            this.lb_Hot.Name = "lb_Hot";
            this.lb_Hot.Size = new System.Drawing.Size(103, 17);
            this.lb_Hot.TabIndex = 4;
            this.lb_Hot.Text = "Горячая вода:";
            // 
            // tb_Cold
            // 
            this.tb_Cold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Cold.Location = new System.Drawing.Point(223, 62);
            this.tb_Cold.Name = "tb_Cold";
            this.tb_Cold.Size = new System.Drawing.Size(191, 22);
            this.tb_Cold.TabIndex = 9;
            this.tb_Cold.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tb_Kitchen
            // 
            this.tb_Kitchen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Kitchen.Location = new System.Drawing.Point(223, 118);
            this.tb_Kitchen.Name = "tb_Kitchen";
            this.tb_Kitchen.Size = new System.Drawing.Size(191, 22);
            this.tb_Kitchen.TabIndex = 11;
            this.tb_Kitchen.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lb_Kitchen
            // 
            this.lb_Kitchen.AutoSize = true;
            this.lb_Kitchen.Location = new System.Drawing.Point(81, 121);
            this.lb_Kitchen.Name = "lb_Kitchen";
            this.lb_Kitchen.Size = new System.Drawing.Size(136, 17);
            this.lb_Kitchen.TabIndex = 5;
            this.lb_Kitchen.Text = "Отопление (кухня):";
            // 
            // tb_Room
            // 
            this.tb_Room.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Room.Location = new System.Drawing.Point(223, 146);
            this.tb_Room.Name = "tb_Room";
            this.tb_Room.Size = new System.Drawing.Size(191, 22);
            this.tb_Room.TabIndex = 12;
            this.tb_Room.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lb_Room
            // 
            this.lb_Room.AutoSize = true;
            this.lb_Room.Location = new System.Drawing.Point(62, 149);
            this.lb_Room.Name = "lb_Room";
            this.lb_Room.Size = new System.Drawing.Size(155, 17);
            this.lb_Room.TabIndex = 6;
            this.lb_Room.Text = "Отопление (комната):";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 223);
            this.Controls.Add(this.tb_Room);
            this.Controls.Add(this.lb_Room);
            this.Controls.Add(this.tb_Kitchen);
            this.Controls.Add(this.lb_Kitchen);
            this.Controls.Add(this.lb_Hot);
            this.Controls.Add(this.tb_Cold);
            this.Controls.Add(this.lb_Night);
            this.Controls.Add(this.tb_Hot);
            this.Controls.Add(this.lb_Cold);
            this.Controls.Add(this.tb_Night);
            this.Controls.Add(this.bt_Send);
            this.Controls.Add(this.lb_Day);
            this.Controls.Add(this.tb_Day);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Показания приборов учёта";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Day;
        private System.Windows.Forms.Label lb_Day;
        private System.Windows.Forms.Button bt_Send;
        private System.Windows.Forms.Label lb_Cold;
        private System.Windows.Forms.TextBox tb_Night;
        private System.Windows.Forms.Label lb_Night;
        private System.Windows.Forms.TextBox tb_Hot;
        private System.Windows.Forms.Label lb_Hot;
        private System.Windows.Forms.TextBox tb_Cold;
        private System.Windows.Forms.TextBox tb_Kitchen;
        private System.Windows.Forms.Label lb_Kitchen;
        private System.Windows.Forms.TextBox tb_Room;
        private System.Windows.Forms.Label lb_Room;
    }
}

