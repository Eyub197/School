using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkateBoardDisplay
{
    public partial class SKforms : Form
    {
        public SKforms()
        {
            InitializeComponent();
        }

       

        private void SKforms_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                lblDbTitle.ForeColor = ThemeColor.SecondaryColor;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblDbTitle_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Price_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Hardware_Click(object sender, EventArgs e)
        {

        }

        private void txt_Hardware_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
