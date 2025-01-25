using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            comboBoxLevel.SelectedIndex = 0;
        }

        private void buttonPlayGame_Click(object sender, EventArgs e)
        {
            if (ParentForm is MathGame mathGame)
            {
                mathGame.StartGame(comboBoxLevel.Text);
            }
            else
            {
                MessageBox.Show("ParentForm không hợp lệ hoặc không phải là MathGame!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
