using Battlemetrics_Check_Server.Property;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Battlemetrics_Check_Server.Control
{
    class Control_Main
    {
        public Server_Info Get_Server_Info(string SV_ID)
        {
            string URL_API = "https://api.battlemetrics.com/servers/" + SV_ID;

            try
            {
                HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(URL_API));

                WebReq.Method = "GET";

                HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

                Console.WriteLine(WebResp.StatusCode);
                Console.WriteLine(WebResp.Server);

                string jsonString;
                using (Stream stream = WebResp.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
                {
                    StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                    jsonString = reader.ReadToEnd();
                }
                dynamic data_json = JObject.Parse(jsonString);
                Server_Info server_Info = new Server_Info()
                {
                    ID = data_json["data"]["attributes"]["id"].ToString(),
                    Name = data_json["data"]["attributes"]["name"].ToString(),
                    IP_Address = data_json["data"]["attributes"]["ip"].ToString(),
                    Port = data_json["data"]["attributes"]["port"].ToString(),
                    Player = data_json["data"]["attributes"]["players"].ToString(),
                    MaxPlayer = data_json["data"]["attributes"]["maxPlayers"].ToString(),
                    Time = data_json["data"]["attributes"]["details"]["time"].ToString(),
                    Status = data_json["data"]["attributes"]["status"].ToString()
                };
                return server_Info;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public void Check_Ping_BW(BackgroundWorker bw, string ip)
        {
            Ping p = new Ping();
            PingReply r;
            r = p.Send(ip);

            if (r.Status == IPStatus.Success)
            {
                bw.ReportProgress(1, new Report_BackgroundWorker
                {
                    Message = "Success",
                    Event = "Ping",
                    IP_Address = r.Address.ToString(),
                    Value = r.RoundtripTime.ToString()
                });
                //TB_Status_CMD.Text = "Ping to " + command.ToString() + "[" + r.Address.ToString() + "]" + " Successful" + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n";
            }
            else
            {
                bw.ReportProgress(1, new Report_BackgroundWorker
                {
                    Message = "Fail",
                    Event = "Ping",
                    IP_Address = r.Address.ToString(),
                    Value = ""
                });
            }
            p.Dispose();
        }
        public string Check_Ping(string ip)
        {
            string PINGGGGG = "";
            Ping p = new Ping();
            PingReply r;
            r = p.Send(ip);

            if (r.Status == IPStatus.Success)
            {
                //bw.ReportProgress(1, new Report_BackgroundWorker
                //{
                //    Message = "Success",
                //    Event = "Ping",
                //    IP_Address = r.Address.ToString(),
                //    Value = r.RoundtripTime.ToString()
                //});
                PINGGGGG = r.RoundtripTime.ToString();
                //TB_Status_CMD.Text = "Ping to " + command.ToString() + "[" + r.Address.ToString() + "]" + " Successful" + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n";
            }
            else
            {
                //bw.ReportProgress(1, new Report_BackgroundWorker
                //{
                //    Message = "Fail",
                //    Event = "Ping",
                //    IP_Address = r.Address.ToString(),
                //    Value = ""
                //});
                PINGGGGG = "";
            }
            p.Dispose();
            return PINGGGGG;
        }
        public void Save_ServerID(string ServerID)
        {
            Properties.Settings.Default.ServerID = ServerID;
            Properties.Settings.Default.Save();
        }
        public void Save_Size(string Size)
        {
            Properties.Settings.Default.Size_Text = Size;
            Properties.Settings.Default.Save();
        }
        public List<WindowHandles> GetWindowHandles()
        {
            List<WindowHandles> windowHandles = new List<WindowHandles>();

            foreach (Process window in Process.GetProcesses())
            {
                window.Refresh();

                if (window.MainWindowHandle != IntPtr.Zero && window.MainModule.ModuleName != "")
                {
                    windowHandles.Add(new WindowHandles()
                    {
                        Name = window.MainModule.ModuleName,
                        Int_Ptr = window.MainWindowHandle
                    });
                }
            }
            return windowHandles;
        }
    }
}
