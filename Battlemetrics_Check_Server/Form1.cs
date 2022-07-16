using Battlemetrics_Check_Server.Control;
using Battlemetrics_Check_Server.Property;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battlemetrics_Check_Server
{
    public partial class Form1 : Form
    {
        Control_Main control_Main = new Control_Main();
        List<WindowHandles> lwindowHandles;
        public Form1()
        {
            InitializeComponent();
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            Text = Text + " " + version.Major + "." + version.Minor + "." + version.Build; //change form title
        }
   
        


        private void backgroundWorker_Main_DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                Server_Info server_Info = new Server_Info();
                server_Info = control_Main.Get_Server_Info(TB_ServerID.Text);
                BackgroundWorker report = sender as BackgroundWorker;
                report.ReportProgress(1, new Report_BackgroundWorker
                {
                    Event="Updata_Info",
                    server_Info= server_Info
                });


                if (server_Info!=null)
                {
                    control_Main.Check_Ping_BW(sender as BackgroundWorker, server_Info.IP_Address);
                }
                int milliseconds = 1000;
                Thread.Sleep(milliseconds);
                if (backgroundWorker_Main.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }

            }
            while (true) ;
        }
        private void backgroundWorker_Main_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UpdataState(e);
        }
        private void backgroundWorker_Main_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        private void UpdataState(ProgressChangedEventArgs e)
        {
            Report_BackgroundWorker state = e.UserState as Report_BackgroundWorker;
            switch (e.ProgressPercentage)
            {
                case 1:
                    {
                        if (state.Event == "Ping")
                        {
                            switch (state.Message)
                            {
                                case "Success":
                                    {
                                        LB_Ping.Text = state.Value.ToString() ;
                                    }
                                    break;
                                case "Fail":
                                    {
                                        LB_Ping.Text = "";
                                    }
                                    break;
                            }
                        }
                        if (state.Event == "Updata_Info")
                        {
                            try
                            {

                                Server_Info server_Info = new Server_Info();
                                server_Info = state.server_Info;
                                LB_Server_Name.Text = server_Info.Name;
                                LB_IP_Address.Text = server_Info.IP_Address+":"+ server_Info.Port;
                                LB_Player.Text = server_Info.Player + "/" + server_Info.MaxPlayer;
                            }
                            catch(Exception ex)
                            { }
                        }

                    }
                    break;
            }
        }





        private void BT_Start_Click(object sender, EventArgs e)
        {
            if (TB_ServerID.Text.All(c => char.IsDigit(c)))
            {
                BT_Start.Enabled = false;
                TB_ServerID.Enabled = false;
                
                BT_Stop.Enabled = true;

         

                backgroundWorker_Main.RunWorkerAsync();
            }
            else
            {

                MessageBox.Show("Only number");
                
            }
        }
        private void BT_Stop_Click(object sender, EventArgs e)
        {
            BT_Start.Enabled = true;
            BT_Stop.Enabled = false;
            TB_ServerID.Enabled = true;
     

            


            backgroundWorker_Main.CancelAsync();
        }

        private void BT_Show_Click(object sender, EventArgs e)
        {
            //if (Application.OpenForms.OfType<Overlay>().Any())
            //{
            //    Application.OpenForms.OfType<Overlay>().First().Close();
            //    backgroundWorker_Main.RunWorkerAsync();
            //    BT_Stop.Enabled = true;
            //    TB_SizeOverlay.Enabled = true;

            //}
            //else
            //{
            //    backgroundWorker_Main.CancelAsync();

            //    //Form_Ontop form_Ontop = new Form_Ontop();
            //    //form_Ontop.ServerID = TB_ServerID.Text;
            //    //form_Ontop.Show();
            //    Overlay overlay = new Overlay(TB_ServerID.Text,TB_SizeOverlay.Text);
            //    overlay.Show();
            //    BT_Stop.Enabled = false;
            //    TB_SizeOverlay.Enabled = false;
            //}

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = "https://www.battlemetrics.com/servers/scum";
            process.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            control_Main.Save_ServerID(TB_ServerID.Text);
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TB_ServerID.Text=Properties.Settings.Default.ServerID;
          
        }

        private void BT_Hook_Click(object sender, EventArgs e)
        {
         
        }
    }

}
