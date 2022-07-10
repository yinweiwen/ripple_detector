using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RippleDetector
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var ZedGraphCtr = zed;
            ZedGraphCtr.IsEnableHPan = false; // 禁止水平移动
            //ZedGraphCtr.IsEnableHZoom = false;              // 禁止水平放缩
            ZedGraphCtr.IsEnableVPan = false; // 禁止垂直移动
            ZedGraphCtr.IsEnableVZoom = false; // 禁止垂直放缩
            ZedGraphCtr.IsEnableWheelZoom = false; // 禁止滚轮放缩 
            ZedGraphCtr.IsShowContextMenu = false; // 不显示上下文菜单
            ZedGraphCtr.IsShowCopyMessage = false; // 不显示复制信息
            ZedGraphCtr.IsShowHScrollBar = false; // 不显示水平滚动条
            ZedGraphCtr.IsShowPointValues = false; // 默认-不显示数据值
            ZedGraphCtr.IsShowVScrollBar = false; // 不显示垂直滚动条
            ZedGraphCtr.IsSynchronizeXAxes = false; // 不强制X轴同步
            ZedGraphCtr.IsSynchronizeYAxes = false; // 不强制Y轴同步
            if (ZedGraphCtr.MasterPane != null)
            {
                ZedGraphCtr.MasterPane.PaneList.Clear();
            }
            ZedGraphCtr.MouseClick += control_MouseClick;
            ZedGraphCtr.MouseDoubleClick += ZedGraphCtr_MouseDoubleClick;
            ZedGraphCtr.KeyDown += ZedGraphCtr_KeyDown;
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {

        }
    }
}
