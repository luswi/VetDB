using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetDB
{
    public partial class VetDBmain : Form
    {
        public VetDBmain()
        {
            InitializeComponent();
        }

        private bool m_firstClick = false;
        private Point m_firstClickLoc;

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if(m_firstClick == false)
                {
                    m_firstClick = true;
                    m_firstClickLoc = new Point(e.X, e.Y);
                }

                this.Location = new Point(
                    this.Location.X + e.X - m_firstClickLoc.X,
                    this.Location.Y + e.Y - m_firstClickLoc.Y
                    );
            }
            else
            {
                m_firstClick = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
