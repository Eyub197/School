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
    public partial class BearingForm : Form
    {
        private List<Bearing> dataList = new List<Bearing>();

        public BearingForm()
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

       

        private void BearingForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

      
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out string name, out int abec_rating, out string bearing_material))
            {
                var newItem = new Bearing()
                {
                    Id = dataList.Count + 1,
                    Name = name,
                    Abec_ratiang = abec_rating,
                    Bearing_material = bearing_material
                };

                dataList.Add(newItem);
                RefreshDataGridView();
                ClearInputFields();
            }
        }


        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
                dataList.RemoveAt(selectedIndex);
                RefreshDataGridView();
                ClearInputFields();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (dataList.Count > 0)
            {
                string message = "Current data:\n";

                foreach (var item in dataList)
                {
                    message += $"ID: {item.Id}, Name: {item.Name}, ABEC Rating: {item.Abec_ratiang}, Bearing Material: {item.Bearing_material}\n";
                }

                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("No data to save.");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;

                if (ValidateInput(out string name, out int abec_rating, out string bearing_material))
                {
                    dataList[selectedIndex].Name = name;
                    dataList[selectedIndex].Abec_ratiang = abec_rating;
                    dataList[selectedIndex].Bearing_material = bearing_material;

                    RefreshDataGridView();
                    ClearInputFields();
                }
            }
        }

        private bool ValidateInput(out string name, out int abec_rating, out string bearing_material)
        {
            name = txt_Name.Text;
            bearing_material = txt_Bearing_Matrieal.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.");
                txt_Name.Focus();
                abec_rating = 0; // Default value for int
                return false;
            }

            if (!int.TryParse(txt_Abec_ratiang.Text, out abec_rating))
            {
                MessageBox.Show("Please enter a valid ABEC rating (integer value).");
                txt_Abec_ratiang.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(bearing_material))
            {
                MessageBox.Show("Please enter a bearing material.");
                txt_Bearing_Matrieal.Focus();
                return false;
            }

            return true;
        }


        private void ClearInputFields()
        {
            txt_Name.Clear();
            txt_Abec_ratiang.Clear();
            txt_Bearing_Matrieal.Clear();
            txt_Name.Focus();
        }

        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataList;
        }















        //Не глеадай надолу!!!!!!!!!!!!!!!!!!!!!!
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Country_Click(object sender, EventArgs e)
        {

        }

        private void txt_Coutry_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
