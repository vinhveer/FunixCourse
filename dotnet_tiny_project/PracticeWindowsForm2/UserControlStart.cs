﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWindowsForm2
{
    public partial class UserControlStart : UserControl
    {
        public UserControlStart()
        {
            InitializeComponent();
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            if (ParentForm is Practice practice)
            {
                practice.GotoUserControlEnd();
            }
        }
    }
}
