using Business;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Model.Data;
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
    public partial class WheelForm : Form
    {
        private WheelController wheelController = new WheelController();
        public WheelForm()
        {
            InitializeComponent();
        }

        private void WheelForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = wheelController.GetAll();
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

        private void btn_Add_Click(object sender, EventArgs e)
        {

            if (ValidateInput(out decimal size, out int hardness, out string shape))
            {
                var newItem = new Wheel()
                {
                    Wheels_size = size,
                    Hardness = hardness,
                    Wheels_shape = shape
                };

                wheelController.Add(newItem);
                LoadData();
                ClearInputFields();
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;

                if (ValidateInput(out decimal size, out int hardness, out string shape))
                {
                    int id = (int)dataGridView1.Rows[selectedIndex].Cells["Id"].Value;
                    var updatedWheel = new Wheel()
                    {
                        Id = id,
                        Wheels_size = size,
                        Hardness = hardness,
                        Wheels_shape = shape
                    };

                    wheelController.Update(updatedWheel);
                    LoadData();
                    ClearInputFields();
                }
            }
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            List<Wheel> wheels = wheelController.GetAll();

            if (wheels.Count > 0)
            {
                string message = "Current data:\n";

                foreach (var wheel in wheels)
                {
                    message += $"ID: {wheel.Id}, Wheel Size: {wheel.Wheels_size}, Hardness: {wheel.Hardness}, Wheel Shape: {wheel.Wheels_shape}\n";
                }

                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("No data to save.");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
                int id = (int)dataGridView1.Rows[selectedIndex].Cells["Id"].Value;
                wheelController.Delete(id);
                LoadData();
                ClearInputFields();
            }
        }


        private bool ValidateInput(out decimal size, out int hardness, out string shape)
        {
            size = 0m;
            decimal.TryParse(txt_Wheels_size.Text, out size);
            hardness = 0;
            int.TryParse(txt_Hardness.Text, out hardness);
            shape = txtWheelShape.Text;

            if (size <= 0m)
            {
                MessageBox.Show("Please enter a valid wheel size.");
                txt_Wheels_size.Focus();
                return false;
            }

            if (hardness <= 0)
            {
                MessageBox.Show("Please enter a valid hardness value.");
                txt_Hardness.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(shape))
            {
                MessageBox.Show("Please enter a wheel shape.");
                txtWheelShape.Focus();
                return false;
            }

            return true;
        }


        private void ClearInputFields()
        {
            txt_Wheels_size.Clear();
            txt_Hardness.Clear();
            txtWheelShape.Clear();
            txt_Wheels_size.Focus();

        }

        



























        private void lblDbTitle_Click(object sender, EventArgs e)
        {

        }
       
        private void txtWheelShape_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
