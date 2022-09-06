using CrazyMouse.@class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyMouse
{
    public partial class CrazyMouseUI : Form
    {
        public CrazyMouseUI()
        {
            InitializeComponent();
            this.clicker = new @class.Clicker();
            this.jiggler = new @class.Jiggler();
        }

        #region Jiggler

        private void TbxJigglerFrequency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnJigglerStart_Click(object sender, EventArgs e)
        {
            BtnJigglerStart.Text = BtnJigglerStart.Text == "Start" ? "Stop" : "Start";
            TbxJigglerFrequency.Enabled = !TbxJigglerFrequency.Enabled;
            int frequencyInterval = Convert.ToInt32(TbxJigglerFrequency.Text);
            this.jiggler.Toggle(frequencyInterval);
        }
        private void TbxJigglerFrequency_TextChanged(object sender, EventArgs e)
        {
            BtnJigglerStart.Enabled = TbxJigglerFrequency.Text != "" ? true : false;
        }

        #endregion

        #region Clicker
        private void BtnClickerStart_Click(object sender, EventArgs e)
        {
            BtnClickerStart.Text = BtnClickerStart.Text == "Start" ? "Stop" : "Start";
            TbxClickerKey.Enabled = !TbxClickerKey.Enabled;
            Char toggleKey = Convert.ToChar(TbxClickerKey.Text);
            this.clicker.Toggle(toggleKey);
        }

        private void TbxClickerKey_TextChanged(object sender, EventArgs e)
        {
            BtnClickerStart.Enabled = BtnClickerStart.Text != "" ? true : false;
        }

        #endregion

        private @class.Clicker clicker;
        private @class.Jiggler jiggler;
    }
}
