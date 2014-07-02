using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMCares.BMS.FDI.BLL;
using XMCares.BMS.FDI.Common;
using XMCares.BMS.FDI.Model;
using XMCares.RabbitMQ.Client.Events;
using XMCares.RabbitMQ.Client.Events;
using XMCares.RabbitMQ.Client.Services;

namespace XMCares.BMS.FDI.Shell
{
    public partial class MainForm : Form
    {
        private Log log = Log.GetLogger(typeof(MainForm));

        private IRabbitMQService rmqService = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmiStart_Click(object sender, EventArgs e)
        {
            try
            {
                TestDBConn();
                InitRabbitMQ();
                SetMenuStrip(true);
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
        }

        private void tsmiStop_Click(object sender, EventArgs e)
        {
            DisposeRabbitMQ();
            SetStatusStrip(tsslDb, false);
            SetMenuStrip(false);
        }

        private void tsmiCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitRabbitMQ()
        {
            rmqService = new RabbitMQService();
            rmqService.CreateBus(ConfigHelper.RmqServiceUrl);
            int count = 0;
            while (!rmqService.IsRabbitMQConnected())
            {
                count++;
                Thread.Sleep(10);
                if (count == 100)
                {
                    rmqService.LogoutBus();
                    rmqService = null;
                    MessageBox.Show("Rabbit MQ服务端连接失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            rmqService.OnRabbitMQConnected += new RabbitMQConnected(RMQService_OnRabbitMQConnected);
            rmqService.OnRabbitMQMessage += new RabbitMQMessage(RMQService_OnRabbitMQMessage);
            rmqService.Subscribe(ConfigHelper.SubQueue);
            SetStatusStrip(tsslSource, true);
        }

        private void DisposeRabbitMQ()
        {
            rmqService.OnRabbitMQConnected -= new RabbitMQConnected(RMQService_OnRabbitMQConnected);
            rmqService.OnRabbitMQMessage -= new RabbitMQMessage(RMQService_OnRabbitMQMessage);
            rmqService.LogoutBus();
            SetStatusStrip(tsslSource, false);
        }

        private void RMQService_OnRabbitMQConnected(bool isConnected)
        {
            try
            {
                this.Invoke(new SetStatusStripHandle(SetStatusStrip), tsslSource, isConnected);
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
        }

        private void RMQService_OnRabbitMQMessage(MessageEventArgs e)
        {
            string MessageID = e.Messagepoperties.MessageId;
            string AppID = e.Messagepoperties.AppId;
            string ContentType = e.Messagepoperties.ContentType;
            string Type = e.Messagepoperties.Type;
            string TimeStamp = new DateTime(e.Messagepoperties.Timestamp).ToString("yyyy-MM-dd HH:mm:ss fff");
            string SystemTime = DateTime.Now.ToString();
            string MessageBody = Encoding.UTF8.GetString(e.Bytemessage);
            AIISBASE o = XmlSerializeHelper.Deserialize<AIISBASE>(MessageBody);
        }

        private void TestDBConn()
        {
            Public pub = new Public();
            bool connStatus = pub.TestDbConn();
            SetStatusStrip(tsslDb, connStatus);
        }

        private void SetMenuStrip(bool started)
        {
            tsmiStart.Enabled = !started;
            tsmiStop.Enabled = started;
        }

        private delegate void SetStatusStripHandle(ToolStripStatusLabel control, bool status);

        private void SetStatusStrip(ToolStripStatusLabel control, bool status)
        {
            if (status)
            {
                control.BackColor = Color.Green;
                control.Text = control.Tag + "：已连接"; 
            }
            else
            {
                control.BackColor = Color.Red;
                control.Text = control.Tag + "：未连接";
            }
        }

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DisposeRabbitMQ();
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
        }
    }
}
