using Bibo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo.Forms.Personal
{
    public partial class LeihstatusPersonal : UI_Helper
    {
        public LeihstatusPersonal()
        {
            InitializeComponent();
        }

        private void buttonHomeLeihstatus_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<HomePersonal>(this);
        }
    }
}
