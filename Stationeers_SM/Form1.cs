using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Web;
using System.Net;
using System.IO;
using System.Xml.Serialization;

namespace Stationeers_SM
{
    public partial class Form1 : Form
    {        
        private string SavePath;
        private CookieContainer ClientCookie;
        private iniSettings iniSet;
        public Form1()
        {
            InitializeComponent();
        }
        public class iniSettings // имя выбрано просто для читаемости кода впоследствии
        {
            public int X_pos; // это собственно для хранения X верхнего левого угла окна
            public int Y_pos; // ну а это, соответственно Y
            public string SrvPath = "C:\\";
            public string RCONPass = "1234";
            public bool batchmode = false;
            public bool nographics = true;
            public bool autostart = true;
            public int autosaveinterval = 300;
            public int clearallinterval = 300;
            public Int64 creator = 0;
            public string worldname = "MyWorld";
            public string worldtype = "Mars";
            public bool loadworld = false;
            public int gameport = 27500;
            public int updateport = 27015;
            public string servername = "stationeers";
            public string basedirectory = "C:\\";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            iniSet = new iniSettings();
            if (File.Exists(path + "\\program.xml"))
            {
                try
                {                    
                    // загружаем данные из файла program.xml 
                    using (Stream stream = new FileStream("program.xml", FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(iniSettings));

                        // в тут же созданную копию класса iniSettings под именем iniSet
                        iniSet = (iniSettings)serializer.Deserialize(stream);

                        // и устанавливаем прочитанные координаты окну
                        this.Location = new Point(iniSet.X_pos, iniSet.Y_pos);
                        

                    }

                }
                catch { }
               

            }
            txtSrv_dir.Text = iniSet.SrvPath;
            if (txtSrv_dir.Text == string.Empty)
                btnStartSrv.Enabled = false;
            txtbasedirectory.Text = iniSet.basedirectory;
            txtRconPas.Text = iniSet.RCONPass;
            chbbatchmode.Checked = iniSet.batchmode;
            chbnographics.Checked = iniSet.nographics;
            chbautostart.Checked = iniSet.autostart;
            chkLoadworld.Checked = iniSet.loadworld;

            txtAutosaveinterval.Text = iniSet.autosaveinterval.ToString();
            txtClearallinterval.Text = iniSet.clearallinterval.ToString();
            if (iniSet.loadworld)
                txtWorldname.Text = iniSet.worldname;

            cmbWorldtype.Text = iniSet.worldtype;
            txtGameport.Text = iniSet.gameport.ToString();
            txtUpdateport.Text = iniSet.updateport.ToString();
            txtServername.Text = iniSet.servername;

            ClientCookie = new CookieContainer();
            lblRunCommand.Text = txtSrv_dir.Text + "\\rocketstation_DedicatedServer.exe -nograpics -autostart -autosaveinterval=300 -clearallinterval=604800 -worldtype=Mars -loadworld=Mars1 -worldname=Mars1 -basedirectory=\"C:\\Game\\stationeers_srv\\srv\\save\\\"";

            btnStartSrv.Enabled = true;
        }
        private void SelectSrvDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.Description = "Custom Description"; //not mandatory

            if (fbd.ShowDialog() == DialogResult.OK)
                iniSet.SrvPath = fbd.SelectedPath;
            else
                iniSet.SrvPath = string.Empty;
            txtSrv_dir.Text = iniSet.SrvPath;

        }

        private void SelectSaveDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.Description = "Custom Description"; //not mandatory

            if (fbd.ShowDialog() == DialogResult.OK)
                iniSet.basedirectory = fbd.SelectedPath;
            else
                iniSet.basedirectory = string.Empty;
            txtbasedirectory.Text = iniSet.basedirectory;
        }


        private string GetCommandLine() 
        {
            string result = "";
            
            //result = lblSrv_dir.Text + "\\rocketstation_DedicatedServer.exe -nograpics -autostart -autosaveinterval=300 -clearallinterval=604800 -worldtype=Mars -loadworld=Mars1 -worldname=Mars1 -basedirectory=\"C:\\Game\\stationeers_srv\\srv\\save\\\"";
            result = txtSrv_dir.Text + "\\rocketstation_DedicatedServer.exe";
            if (iniSet.batchmode)
                result = result + " -batchmode";
            if (iniSet.nographics)
                result = result + " -nographics";
            if (iniSet.autostart)
                result = result + " -autostart";
            if(iniSet.autosaveinterval>0)
                result = result + " -autosaveinterval=" + iniSet.autosaveinterval.ToString();
            if (iniSet.clearallinterval > 0)
                result = result + " -clearallinterval=" + iniSet.clearallinterval.ToString();
            result = result + " -worldtype=" + iniSet.worldtype;
            if (iniSet.loadworld)
            {
                result = result + " -" + iniSet.worldname + " -loadworld=" + iniSet.worldname;
            }
            if(iniSet.basedirectory != string.Empty)
                result = result + " -basedirectory=" + iniSet.basedirectory;
            lblRunCommand.Text = result;
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            GetCommandLine();
        }
        private void RunSrv() 
        {
            GetCommandLine();
            ProcessStartInfo processInfo = new ProcessStartInfo();
            //processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.FileName = "cmd.exe";
            //processInfo.WorkingDirectory = Path.GetDirectoryName(YourApplicationPath);
            processInfo.Arguments = "/c START " + lblRunCommand.Text;
            richTextBox1.Clear();
            richTextBox1.AppendText(processInfo.Arguments + "\n");
            Process.Start(processInfo);
        }

        private void btnStartSrv_Click(object sender, EventArgs e)
        {

            RunSrv();
            btnStartSrv.Enabled = false;
            btnStopSrv.Enabled = true;
        }

        

        

       
        private void RconCommand(string Command)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:27500/"+Command);
            request.CookieContainer = ClientCookie;
            request.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/66.0.3359.139 Safari/537.36";


            request.KeepAlive = true;
            request.Accept = "*/*";
            request.Headers.Add("X-Requested-With: XMLHttpRequest");
            request.Headers.Add("Accept-Language: ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7,de;q=0.6");


            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

            
            richTextBox1.AppendText(readStream.ReadToEnd()+"\n");
            response.Close();
            readStream.Close();
        }
        private void StopServer()
        {
            RconCommand("console/run?command=login%2520"+ iniSet.RCONPass);
            RconCommand("console/run?command=save%2520"+ iniSet.worldname);
            RconCommand("console/run?command=shutdown");
        }
        private void btnStopSrv_Click(object sender, EventArgs e)
        {
            StopServer();

            btnStartSrv.Enabled = true;
            btnStopSrv.Enabled = false;
        }
        private void saveConfig() 
        {
            iniSet.SrvPath = txtSrv_dir.Text;
            if (txtSrv_dir.Text == string.Empty)
                btnStartSrv.Enabled = false;
            else
                btnStartSrv.Enabled = true;
            iniSet.basedirectory = txtbasedirectory.Text;
            iniSet.RCONPass = txtRconPas.Text;
            iniSet.X_pos = Location.X;
            iniSet.Y_pos = Location.Y;
            iniSet.batchmode = chbbatchmode.Checked;
            iniSet.nographics = chbnographics.Checked;
            iniSet.autostart = chbautostart.Checked;
            iniSet.autosaveinterval = Convert.ToInt32(txtAutosaveinterval.Text);
            iniSet.clearallinterval = Convert.ToInt32(txtClearallinterval.Text);
            iniSet.worldname = txtWorldname.Text;
            iniSet.worldtype = cmbWorldtype.Text;
            iniSet.loadworld = chkLoadworld.Checked;
            iniSet.gameport = Convert.ToInt32(txtGameport.Text);
            iniSet.updateport = Convert.ToInt32(txtUpdateport.Text);
            iniSet.servername = txtServername.Text;

            // выкидываем класс iniSet целиком в файл program.xml
            using (Stream writer = new FileStream("program.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(iniSettings));
                serializer.Serialize(writer, iniSet);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveConfig();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveConfig();
            richTextBox1.AppendText("Config saved \n");

        }


    }
}
