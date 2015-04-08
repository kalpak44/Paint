using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Settings : Form
    {
        public int iWidth;
        public int iHeight;
        private Paint parrent;
        public Settings(Paint parrent)
        {
            InitializeComponent();
            this.parrent = parrent;

        }
        private void buttonChancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(textBoxHeight.Text, out iHeight))
            {
                MessageBox.Show("Incorect inputs.");
            }
            else if (!int.TryParse(textBoxWidth.Text, out iWidth))
            {
                MessageBox.Show("Incorect inputs.");
            }
            else
            {
                parrent.setImgSizes(iWidth, iHeight);
                this.Close();
            }
        }

        public void setSizes(int w, int h)
        {
            textBoxWidth.Text = w.ToString();
            textBoxHeight.Text = h.ToString();
        }
    }
}
