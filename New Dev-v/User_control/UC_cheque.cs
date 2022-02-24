using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Dev_v.User_control
{
    public partial class UC_cheque : UserControl
    {
        public UC_cheque()
        {
            InitializeComponent();
        }

        private void Btn_etap1_Click(object sender, EventArgs e)
        {
            panel_slide.Width = Btn_etap1.Width;
            panel_slide.Left = Btn_etap1.Left;
            uC_cheque_info1.BringToFront();
        }

        private void btn_etape2_Click(object sender, EventArgs e)
        {
            panel_slide.Width = btn_etape2.Width;
            panel_slide.Left = btn_etape2.Left;
            uC_imprimer1.BringToFront();
        }
    }
}
