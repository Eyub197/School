﻿using Business;
using Model.Data;
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

namespace SkateBoardDisplay
{
    public partial class SKforms : Form
    {
        private SkateBoardController skateBoardController = new SkateBoardController();

        public SKforms()
        {
            InitializeComponent();
        }


        private List<Skateboard> dataList = new List<Skateboard>();

        private void SKforms_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadData();
        }

        private void LoadData()
        {
            List<Skateboard> skateboards = skateBoardController.GetAll();
            dataGridView1.DataSource = skateboards;
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;

                if (ValidateInput(out decimal price, out int deckId, out int wheelId, out string hardware, out int bearingId, out int brandId, out DateTime productionDate))
                {
                    int id = (int)dataGridView1.Rows[selectedIndex].Cells["Id"].Value;

                    var updatedSkateboard = new Skateboard()
                    {
                        Id = id,
                        Price = price,
                        DeckId = deckId,
                        WheelId = wheelId,
                        Hardware = hardware,
                        BearingId = bearingId,
                        BrandId = brandId,
                        Date_of_production = productionDate
                    };

                    skateBoardController.Update(updatedSkateboard);
                    LoadData();
                    ClearInputFields();
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out decimal price, out int deckId, out int wheelId, out string hardware, out int bearingId, out int brandId, out DateTime productionDate))
            {
                var newItem = new Skateboard()
                {
                    Price = price,
                    DeckId = deckId,
                    WheelId = wheelId,
                    Hardware = hardware,
                    BearingId = bearingId,
                    BrandId = brandId,
                    Date_of_production = productionDate
                };

                skateBoardController.Add(newItem);
                LoadData();
                ClearInputFields();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
                int id = (int)dataGridView1.Rows[selectedIndex].Cells["Id"].Value;
                skateBoardController.Delete(id);
                LoadData();
                ClearInputFields();
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            List<Skateboard> skateboards = skateBoardController.GetAll();

            if (skateboards.Count > 0)
            {
                string message = "Current data:\n";

                foreach (var skateboard in skateboards)
                {
                    message += $"ID: {skateboard.Id}, Price: {skateboard.Price}, DeckID: {skateboard.DeckId}, WheelID: {skateboard.WheelId}, Hardware: {skateboard.Hardware}, BearingID: {skateboard.BearingId}, BrandID: {skateboard.BrandId}, ProductionDate: {skateboard.Date_of_production}\n";
                }

                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("No data to save.");
            }
        }


        private bool ValidateInput(out decimal price, out int deckId, out int wheelId, out string hardware, out int bearingId, out int brandId, out DateTime productionDate)
        {
            if (!decimal.TryParse(txt_Price.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                txt_Price.Focus();
                deckId = 0;
                wheelId = 0;
                hardware = string.Empty;
                bearingId = 0;
                brandId = 0;
                productionDate = DateTime.MinValue;
                return false;
            }

            if (!int.TryParse(txt_DeckId.Text, out deckId))
            {
                MessageBox.Show("Please enter a valid deck ID.");
                txt_DeckId.Focus();
                wheelId = 0;
                hardware = string.Empty;
                bearingId = 0;
                brandId = 0;
                productionDate = DateTime.MinValue;
                return false;
            }

            if (!int.TryParse(txt_Wheel_Id.Text, out wheelId))
            {
                MessageBox.Show("Please enter a valid wheel ID.");
                txt_Wheel_Id.Focus();
                hardware = string.Empty;
                bearingId = 0;
                brandId = 0;
                productionDate = DateTime.MinValue;
                return false;
            }

            hardware = txt_Hardware.Text;

            if (!int.TryParse(txt_BearingId.Text, out bearingId))
            {
                MessageBox.Show("Please enter a valid bearing ID.");
                txt_BearingId.Focus();
                brandId = 0;
                productionDate = DateTime.MinValue;
                return false;
            }

            if (!int.TryParse(txt_BrandId.Text, out brandId))
            {
                MessageBox.Show("Please enter a valid brand ID.");
                txt_BrandId.Focus();
                productionDate = DateTime.MinValue;
                return false;
            }

            productionDate = dateTimePickerPRoduction.Value.Date.Date;

            return true;
        }


        private void ClearInputFields()
        {
            txt_Price.Clear();
            txt_DeckId.Clear();
            txt_Wheel_Id.Clear();
            txt_Hardware.Clear();
            txt_BearingId.Clear();
            txt_BrandId.Clear();
            dateTimePickerPRoduction = null;
            txt_Price.Focus();
        }

        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = skateBoardController.GetAll();
        }



























        //Не глефай надолу !!!!!!!!!!!!!!!!!!!!!









        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblDbTitle_Click(object sender, EventArgs e)
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
