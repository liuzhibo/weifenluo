using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace weifenluodemo
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            dockPanel1.AllowEndUserDocking = false;

            Form_Bottom form_Bottom = new Form_Bottom();
            Form_Left form_Left = new Form_Left();
            Form_Right form_Right = new Form_Right();
            Form_Center form_Center = new Form_Center();
            Form_Top form_Top = new Form_Top();

            form_Bottom.CloseButtonVisible = false;
            form_Left.CloseButtonVisible = false;
            form_Right.CloseButtonVisible = false;
            form_Center.CloseButtonVisible = false;
            form_Top.CloseButtonVisible = false;

            form_Bottom.Show(this.dockPanel1, DockState.DockBottom);
            form_Left.Show(this.dockPanel1, DockState.DockLeft);
            form_Right.Show(this.dockPanel1, DockState.DockRight);
            form_Top.Show(this.dockPanel1,DockState.DockTop);
            form_Center.Show(this.dockPanel1);
        }

    }
}
