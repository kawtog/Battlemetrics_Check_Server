
namespace Battlemetrics_Check_Server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_Start = new System.Windows.Forms.Button();
            this.backgroundWorker_Main = new System.ComponentModel.BackgroundWorker();
            this.BT_Stop = new System.Windows.Forms.Button();
            this.LB_Ping = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_IP_Address = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_Server_Name = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LB_Player = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_ServerID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_Start
            // 
            this.BT_Start.Location = new System.Drawing.Point(525, 36);
            this.BT_Start.Name = "BT_Start";
            this.BT_Start.Size = new System.Drawing.Size(129, 43);
            this.BT_Start.TabIndex = 0;
            this.BT_Start.Text = "Start";
            this.BT_Start.UseVisualStyleBackColor = true;
            this.BT_Start.Click += new System.EventHandler(this.BT_Start_Click);
            // 
            // backgroundWorker_Main
            // 
            this.backgroundWorker_Main.WorkerReportsProgress = true;
            this.backgroundWorker_Main.WorkerSupportsCancellation = true;
            this.backgroundWorker_Main.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_Main_DoWork);
            this.backgroundWorker_Main.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_Main_ProgressChanged);
            this.backgroundWorker_Main.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_Main_RunWorkerCompleted);
            // 
            // BT_Stop
            // 
            this.BT_Stop.Location = new System.Drawing.Point(525, 85);
            this.BT_Stop.Name = "BT_Stop";
            this.BT_Stop.Size = new System.Drawing.Size(129, 43);
            this.BT_Stop.TabIndex = 2;
            this.BT_Stop.Text = "Stop";
            this.BT_Stop.UseVisualStyleBackColor = true;
            this.BT_Stop.Click += new System.EventHandler(this.BT_Stop_Click);
            // 
            // LB_Ping
            // 
            this.LB_Ping.AutoSize = true;
            this.LB_Ping.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_Ping.Location = new System.Drawing.Point(101, 92);
            this.LB_Ping.Name = "LB_Ping";
            this.LB_Ping.Size = new System.Drawing.Size(47, 37);
            this.LB_Ping.TabIndex = 0;
            this.LB_Ping.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ping :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(153, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "ms";
            // 
            // LB_IP_Address
            // 
            this.LB_IP_Address.AutoSize = true;
            this.LB_IP_Address.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_IP_Address.Location = new System.Drawing.Point(171, 55);
            this.LB_IP_Address.Name = "LB_IP_Address";
            this.LB_IP_Address.Size = new System.Drawing.Size(95, 37);
            this.LB_IP_Address.TabIndex = 6;
            this.LB_IP_Address.Text = "0.0.0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "IP Address :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LB_Server_Name);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.LB_Player);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.LB_IP_Address);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LB_Ping);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(10, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 208);
            this.panel1.TabIndex = 5;
            // 
            // LB_Server_Name
            // 
            this.LB_Server_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Server_Name.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_Server_Name.Location = new System.Drawing.Point(206, 24);
            this.LB_Server_Name.Name = "LB_Server_Name";
            this.LB_Server_Name.Size = new System.Drawing.Size(282, 31);
            this.LB_Server_Name.TabIndex = 8;
            this.LB_Server_Name.Text = "Null";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(11, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 37);
            this.label9.TabIndex = 8;
            this.label9.Text = "Server Name :";
            // 
            // LB_Player
            // 
            this.LB_Player.AutoSize = true;
            this.LB_Player.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_Player.Location = new System.Drawing.Point(119, 129);
            this.LB_Player.Name = "LB_Player";
            this.LB_Player.Size = new System.Drawing.Size(58, 37);
            this.LB_Player.TabIndex = 8;
            this.LB_Player.Text = "0/0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(11, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "Player :";
            // 
            // TB_ServerID
            // 
            this.TB_ServerID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TB_ServerID.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_ServerID.Location = new System.Drawing.Point(152, 36);
            this.TB_ServerID.Name = "TB_ServerID";
            this.TB_ServerID.Size = new System.Drawing.Size(367, 43);
            this.TB_ServerID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(10, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 37);
            this.label6.TabIndex = 7;
            this.label6.Text = "Server ID :";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(566, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(88, 15);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Search ServerID";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 305);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_ServerID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BT_Stop);
            this.Controls.Add(this.BT_Start);
            this.Name = "Form1";
            this.Text = "Check Server(Battlemetrics) by kk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Start;
        private System.Windows.Forms.TextBox Status_CMD_;
        private System.ComponentModel.BackgroundWorker backgroundWorke_Ping;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Main;
        private System.Windows.Forms.Button BT_Stop;
        private System.Windows.Forms.Label LB_Ping;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_IP_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_ServerID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LB_Server_Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LB_Player;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

