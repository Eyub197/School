using Business;
using Model.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkateBoardDisplay
{
    public partial class BearingForm : Form
    {
        private BearingController bearingController = new BearingController();
        int editedId = 0;
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

        private Bearing GetEditedBearing()
        {
           Bearing bearing = new Bearing();
            bearing.Id = editedId;

            var name = txt_Name.Text;
            int abec_rating = 0;
            int.TryParse(txt_Abec_ratiang.Text, out abec_rating);
            var bearing_materail = txt_Bearing_Matrieal.Text;

            bearing.Name = name;
            bearing.Abec_ratiang = abec_rating;
            bearing.Bearing_material = bearing_materail;

            return bearing;
        }

        private void ResetSesected()
        { 
            dataGridView1.ClearSelection();
            dataGridView1.Enabled = true;
        }
        private void UpdateGrid()
        {
            dataGridView1.DataSource = bearingController.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  
        }
        private void UpdateTextBoxses(int id)
        {
            Bearing update = bearingController.Get(id);
            txt_Name.Text = update.Name;
            txt_Abec_ratiang.Text = update.Bearing_material.ToString();
            txt_Bearing_Matrieal.Text = update.Bearing_material;
        }

      
        private void DisableSelect()
        { 
            dataGridView1.Enabled = false;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out string name, out int abec_rating, out string bearing_material))
            {
                var newBearing = new Bearing()
                {
                    Name = name,
                    Abec_ratiang = abec_rating,
                    Bearing_material = bearing_material
                };

                bearingController.Add(newBearing);
                UpdateGrid();
                ClearInputFields();
                
            }
        }

        
        private void btn_Delete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());

                bearingController.Delete(id);
                UpdateGrid();
                ResetSesected();
            }
        }
     

        private void btn_Save_Click(object sender, EventArgs e)
        {
           Bearing editedBeaering = GetEditedBearing();
            bearingController.Update(editedBeaering);
            UpdateGrid();
            ResetSesected();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
               var item = dataGridView1.SelectedRows[0].Cells;

                if (ValidateInput(out string name, out int abec_rating, out string bearing_material))
                {
                    int id = int.Parse(item[0].Value.ToString());
                    editedId = id;

                    UpdateTextBoxses(id);
                    DisableSelect();
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
                abec_rating = 0; 
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
