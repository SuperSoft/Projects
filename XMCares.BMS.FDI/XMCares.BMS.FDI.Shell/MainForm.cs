using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMCares.BMS.FDI.BLL;
using XMCares.BMS.FDI.Common;
using XMCares.RabbitMQ.Client.Events;
using XMCares.RabbitMQ.Client.Services;

namespace XMCares.BMS.FDI.Shell
{
    public partial class MainForm : Form
    {
        private Log log = Log.GetLogger(typeof(MainForm));

        private RabbitMQService rmqService = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmiStart_Click(object sender, EventArgs e)
        {
            TestDBConn();
            InitRabbitMQ();
            SetMenuStrip(true);
        }

        private void tsmiStop_Click(object sender, EventArgs e)
        {
            tsmiStart.Enabled = true;
            SetMenuStrip(false);
        }

        private void tsmiCancel_Click(object sender, EventArgs e)
        {

        }

        private void SetMenuStrip(bool started)
        {
            tsmiStart.Enabled = !started;
            tsmiStop.Enabled = started;
        }

        private void InitRabbitMQ()
        {
            try
            {
                rmqService = new RabbitMQService();
                rmqService.CreateBus(ConfigHelper.RmqServiceUrl);
                rmqService.OnRabbitMQConnected += new RabbitMQConnected(RMQService_OnRabbitMQConnected);
                rmqService.OnRabbitMQMessage += new RabbitMQMessage(RMQService_OnRabbitMQMessage);
            }
            catch (Exception ex)
            {
                string ret = ex.ToString();
            }
        }

        private void DisposeRabbitMQ()
        {
            rmqService.OnRabbitMQConnected -= new RabbitMQConnected(RMQService_OnRabbitMQConnected);
            rmqService.LogoutBus();
        }

        private void RMQService_OnRabbitMQConnected(bool isConnected)
        {
            try
            {
                if (isConnected)
                {
                    this.Invoke(new SetStatusStripHandle(SetStatusStrip), tsslSource, 1);
                }
                else
                {
                    this.Invoke(new SetStatusStripHandle(SetStatusStrip), tsslSource, 0);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
        }

        private void RMQService_OnRabbitMQMessage(MessageEventArgs e)
        {
 
        }

        private void TestDBConn()
        {
            DbOperate d = ObjectFactory.GetObject<DbOperate>("XMCares.BMS.FDI.BLL.DbOperate", "XMCares.BMS.FDI.BLL");
            d.TestDbConn();
        }

        private delegate void SetStatusStripHandle(ToolStripStatusLabel control, int status);

        private void SetStatusStrip(ToolStripStatusLabel control, int status)
        {
            try
            {
                switch (status)
                {
                    case 0: //未连接
                        control.BackColor = Color.Red;
                        control.Text = control.Tag + "：未连接";

                        break;
                    case 1: //已连接
                        control.BackColor = Color.Green;
                        control.Text = control.Tag + "：已连接";
                        break;
                    default:
                        control.BackColor = Color.Red;
                        control.Text = control.Tag + "：未连接";
                        break;
                }
                log.Info(control.Text);
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
        }

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeRabbitMQ();
        }
    }
}
