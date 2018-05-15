using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrayRabbit.MMS.WindowsForm
{
    public partial class welcome :DevExpress.XtraEditors.XtraForm
    {
        public welcome()
        {
            InitializeComponent();
            this.alertControl1.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.BottomRight;
            this.alertControl1.AutoFormDelay = 7000;
            //出现的效果方式
            this.alertControl1.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.FadeIn;
            //弹出的速度
            this.alertControl1.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Fast;
            alertControl1.Show(this,"提示","您有一条消息1");
        }

        private void 测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
