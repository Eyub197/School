using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Model.Data;
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
        private List<Brand> dataList = new List<Brand>();

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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out string name, out string producer, out string country))
            {
                var newItem = new Brand()
                {
                    Id = dataList.Count + 1,
                    Name = name,
                    Producer = producer,
                    Country = country
                };

                dataList.Add(newItem);
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
                    message += $"ID: {item.Id}, Name: {item.Name}, Producer: {item.Producer}, Country: {item.Country}\n";
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

                if (ValidateInput(out string name, out string producer, out string country))
                {
                    dataList[selectedIndex].Name = name;
                    dataList[selectedIndex].Producer = producer;
                    dataList[selectedIndex].Country = country;
                    RefreshDataGridView();
                    ClearInputFields();
                }
            }
        }
        


        private bool ValidateInput(out string name, out string producer, out string country)
        {
            name = txt_Name.Text;
            producer = txt_Producer.Text;
            country = txtCountry.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.");
                txt_Name.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(producer))
            {
                MessageBox.Show("Please enter a producer.");
                txtCountry.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(country))
            {
                MessageBox.Show("Please enter a country.");
                txt_Country.Focus();
                return false;
            }

            return true;
        }

        private void ClearInputFields()
        {
            txt_Name.Clear();
            txt_Producer.Clear();
            txtCountry.Clear();
            txt_Name.Focus();
           
        }

        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataList;
        }



        //Не гледайте надолу!!!!!!!!!!!!!!!!!!!!!!!!!!!
      





























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

