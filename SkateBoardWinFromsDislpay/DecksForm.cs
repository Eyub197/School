using Business;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace SkateBoardDisplay
{
    public partial class DecksForm : Form
    {
        DeckController deckController = new DeckController();
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
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = deckController.GetAll();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out string wood_type, out string deck_shape, out string deck_concave))
            {
                var newItem = new Deck()
                {
                    Wood_type = wood_type,
                    Deck_shape = deck_shape,
                    Deck_concave = deck_concave
                };

                deckController.Add(newItem);
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
                deckController.Delete(id);
                LoadData();
                ClearInputFields();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            List<Deck> decks = deckController.GetAll();

            if (decks.Count > 0)
            {
                string message = "Current data:\n";

                foreach (var deck in decks)
                {
                    message += $"ID: {deck.Id}, Wood Type: {deck.Wood_type}, Deck Shape: {deck.Deck_shape}, Deck Concave: {deck.Deck_concave}\n";
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
                    int id = (int)dataGridView1.Rows[selectedIndex].Cells["Id"].Value;
                    var updatedDeck = new Deck()
                    {
                        Id = id,
                        Wood_type = wood_type,
                        Deck_shape = deck_shape,
                        Deck_concave = deck_concave
                    };

                    deckController.Update(updatedDeck);
                    LoadData();
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
            dataGridView1.DataSource = deckController.GetAll();
        }


    }
}
