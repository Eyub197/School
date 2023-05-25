using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkateBoardDisplay
{
    public partial class BrandForms : Form
    {
        public BrandForms()
        {
            InitializeComponent();
            
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



        private void BrandForms_Load(object sender, EventArgs e)
        {
            LoadTheme();

        }

        private void lbl_Producer_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Name_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
