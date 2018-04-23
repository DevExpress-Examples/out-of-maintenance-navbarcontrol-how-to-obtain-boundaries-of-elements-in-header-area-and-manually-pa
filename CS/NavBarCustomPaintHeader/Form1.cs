using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraNavBar.ViewInfo;

namespace NavBarCustomPaintHeader {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
            navBarControl1.CustomDrawGroupCaption += NavBarControl1_CustomDrawGroupCaption;
        }

        private void NavBarControl1_CustomDrawGroupCaption(object sender, DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventArgs e) {
            Console.WriteLine(DateTime.Now.Ticks);
            var info = e.ObjectInfo as NavGroupInfoArgs;
            var vInfo = info.ClientInfo.NavBar.GetViewInfo() as SkinNavigationPaneViewInfo;
            if (vInfo == null) return;
            //custom paint
            Rectangle rect = vInfo.HeaderBounds;
            rect.Width -= 1;
            e.Graphics.DrawRectangle(Pens.Red, rect);
            e.Graphics.DrawRectangle(Pens.Green, vInfo.HeaderInfo.CaptionBounds);
            e.Graphics.DrawRectangle(Pens.Black, vInfo.HeaderInfo.ButtonBounds);
        }
    }
}
