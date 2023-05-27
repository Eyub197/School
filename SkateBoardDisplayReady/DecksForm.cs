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
    public partial class DecksForm : Form
    {
        private List<Deck> dataList = new List<Deck>();

        public DecksForm()
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

        private void DecksForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out string wood_type, out string deck_shape, out string deck_concave))
            {
                var newItem = new Deck()
                {
                    Id = dataList.Count + 1,
                    Wood_type = wood_type,
                    Deck_shape = deck_shape,
                    Deck_concave = deck_concave
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
                    message += $"ID: {item.Id}, Wood Type: {item.Wood_type}, Deck Shape: {item.Deck_shape}, Deck Concave: {item.Deck_concave}\n";
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

                if (ValidateInput(out string wood_type, out string deck_shape, out string deck_concave))
                {
                    dataList[selectedIndex].Wood_type = wood_type;
                    dataList[selectedIndex].Deck_shape = deck_shape;
                    dataList[selectedIndex].Deck_concave = deck_concave;
                    RefreshDataGridView();
                    ClearInputFields();
                }
            }
        }

        private bool ValidateInput(out string wood_type, out string deck_shape, out string deck_concave)
        {
            wood_type = txt_Wood_type.Text;
            deck_shape = txt_DeckShape.Text;
            deck_concave = txt_DeckConcave.Text;

            if (string.IsNullOrEmpty(wood_type))
            {
                MessageBox.Show("Please enter a wood type.");
                txt_Wood_type.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(deck_shape))
            {
                MessageBox.Show("Please enter a deck shape.");
                txt_DeckShape.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(deck_concave))
            {
                MessageBox.Show("Please enter a deck concave.");
                txt_DeckConcave.Focus();
                return false;
            }

            return true;
        }

        private void ClearInputFields()
        {
            txt_Wood_type.Clear();
            txt_DeckShape.Clear();
            txt_DeckConcave.Clear();
            txt_Wood_type.Focus();
        }

        

        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataList;
        }

        
    }
}
