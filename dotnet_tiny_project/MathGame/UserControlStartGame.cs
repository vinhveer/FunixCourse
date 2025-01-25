using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class UserControlStartGame : UserControl
    {
        public UserControlStartGame()
        {
            InitializeComponent();

            comboBoxChooseLevel.SelectedIndex = 0;
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            if (ParentForm is MathGame mathGame)
            {
                if (comboBoxChooseLevel.SelectedIndex == 0)
                {
                    mathGame.StartGame("easy");
                }
                else if (comboBoxChooseLevel.SelectedIndex == 1)
                {
                    mathGame.StartGame("medium");
                }
                else if (comboBoxChooseLevel.SelectedIndex == 2)              
                {
                    mathGame.StartGame("hard");
                }
            }
        }
    }
}
