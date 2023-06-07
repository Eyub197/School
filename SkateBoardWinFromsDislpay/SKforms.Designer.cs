namespace SkateBoardDisplay
{
    partial class SKforms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDbTitle = new System.Windows.Forms.Label();
            this.txt_Wheel_Id = new System.Windows.Forms.TextBox();
            this.txt_DeckId = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_WheelId = new System.Windows.Forms.Label();
            this.lbl_DeckId = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_Hardware = new System.Windows.Forms.Label();
            this.txt_Hardware = new System.Windows.Forms.TextBox();
            this.lbl_Bearing_Id = new System.Windows.Forms.Label();
            this.txt_BearingId = new System.Windows.Forms.TextBox();
            this.lbl_BrandId = new System.Windows.Forms.Label();
            this.txt_BrandId = new System.Windows.Forms.TextBox();
            this.lbl_date_of_production = new System.Windows.Forms.Label();
            this.dateTimePickerPRoduction = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Location = new System.Drawing.Point(411, 428);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(84, 46);
            this.btn_Save.TabIndex = 50;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(242, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(433, 278);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblDbTitle
            // 
            this.lblDbTitle.AutoSize = true;
            this.lblDbTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDbTitle.Location = new System.Drawing.Point(411, 6);
            this.lblDbTitle.Name = "lblDbTitle";
            this.lblDbTitle.Size = new System.Drawing.Size(131, 25);
            this.lblDbTitle.TabIndex = 48;
            this.lblDbTitle.Text = "SkateboardDb";
            this.lblDbTitle.Click += new System.EventHandler(this.lblDbTitle_Click);
            // 
            // txt_Wheel_Id
            // 
            this.txt_Wheel_Id.Location = new System.Drawing.Point(71, 105);
            this.txt_Wheel_Id.Name = "txt_Wheel_Id";
            this.txt_Wheel_Id.Size = new System.Drawing.Size(100, 23);
            this.txt_Wheel_Id.TabIndex = 47;
            // 
            // txt_DeckId
            // 
            this.txt_DeckId.Location = new System.Drawing.Point(71, 69);
            this.txt_DeckId.Name = "txt_DeckId";
            this.txt_DeckId.Size = new System.Drawing.Size(100, 23);
            this.txt_DeckId.TabIndex = 46;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(71, 33);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(100, 23);
            this.txt_Price.TabIndex = 45;
            // 
            // txt_WheelId
            // 
            this.txt_WheelId.AutoSize = true;
            this.txt_WheelId.Location = new System.Drawing.Point(7, 108);
            this.txt_WheelId.Name = "txt_WheelId";
            this.txt_WheelId.Size = new System.Drawing.Size(50, 15);
            this.txt_WheelId.TabIndex = 44;
            this.txt_WheelId.Text = "WheelId";
            // 
            // lbl_DeckId
            // 
            this.lbl_DeckId.AutoSize = true;
            this.lbl_DeckId.Location = new System.Drawing.Point(7, 69);
            this.lbl_DeckId.Name = "lbl_DeckId";
            this.lbl_DeckId.Size = new System.Drawing.Size(43, 15);
            this.lbl_DeckId.TabIndex = 43;
            this.lbl_DeckId.Text = "DeckId";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(7, 33);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(33, 15);
            this.lbl_Price.TabIndex = 42;
            this.lbl_Price.Text = "Price";
            this.lbl_Price.Click += new System.EventHandler(this.lbl_Price_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(242, 347);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(84, 46);
            this.btn_Add.TabIndex = 41;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(411, 347);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(84, 46);
            this.btn_Delete.TabIndex = 40;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Location = new System.Drawing.Point(591, 347);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(84, 46);
            this.btn_Update.TabIndex = 39;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_Hardware
            // 
            this.lbl_Hardware.AutoSize = true;
            this.lbl_Hardware.Location = new System.Drawing.Point(7, 140);
            this.lbl_Hardware.Name = "lbl_Hardware";
            this.lbl_Hardware.Size = new System.Drawing.Size(58, 15);
            this.lbl_Hardware.TabIndex = 51;
            this.lbl_Hardware.Text = "Hardware";
            this.lbl_Hardware.Click += new System.EventHandler(this.lbl_Hardware_Click);
            // 
            // txt_Hardware
            // 
            this.txt_Hardware.Location = new System.Drawing.Point(71, 140);
            this.txt_Hardware.Name = "txt_Hardware";
            this.txt_Hardware.Size = new System.Drawing.Size(100, 23);
            this.txt_Hardware.TabIndex = 52;
            this.txt_Hardware.TextChanged += new System.EventHandler(this.txt_Hardware_TextChanged);
            // 
            // lbl_Bearing_Id
            // 
            this.lbl_Bearing_Id.AutoSize = true;
            this.lbl_Bearing_Id.Location = new System.Drawing.Point(7, 183);
            this.lbl_Bearing_Id.Name = "lbl_Bearing_Id";
            this.lbl_Bearing_Id.Size = new System.Drawing.Size(57, 15);
            this.lbl_Bearing_Id.TabIndex = 53;
            this.lbl_Bearing_Id.Text = "BearingId";
            // 
            // txt_BearingId
            // 
            this.txt_BearingId.Location = new System.Drawing.Point(71, 175);
            this.txt_BearingId.Name = "txt_BearingId";
            this.txt_BearingId.Size = new System.Drawing.Size(100, 23);
            this.txt_BearingId.TabIndex = 54;
            // 
            // lbl_BrandId
            // 
            this.lbl_BrandId.AutoSize = true;
            this.lbl_BrandId.Location = new System.Drawing.Point(12, 224);
            this.lbl_BrandId.Name = "lbl_BrandId";
            this.lbl_BrandId.Size = new System.Drawing.Size(48, 15);
            this.lbl_BrandId.TabIndex = 55;
            this.lbl_BrandId.Text = "BrandId";
            // 
            // txt_BrandId
            // 
            this.txt_BrandId.Location = new System.Drawing.Point(71, 216);
            this.txt_BrandId.Name = "txt_BrandId";
            this.txt_BrandId.Size = new System.Drawing.Size(100, 23);
            this.txt_BrandId.TabIndex = 56;
            // 
            // lbl_date_of_production
            // 
            this.lbl_date_of_production.AutoSize = true;
            this.lbl_date_of_production.Location = new System.Drawing.Point(7, 262);
            this.lbl_date_of_production.Name = "lbl_date_of_production";
            this.lbl_date_of_production.Size = new System.Drawing.Size(110, 15);
            this.lbl_date_of_production.TabIndex = 57;
            this.lbl_date_of_production.Text = "date_of_production";
            // 
            // dateTimePickerPRoduction
            // 
            this.dateTimePickerPRoduction.Location = new System.Drawing.Point(7, 280);
            this.dateTimePickerPRoduction.Name = "dateTimePickerPRoduction";
            this.dateTimePickerPRoduction.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerPRoduction.TabIndex = 59;
            // 
            // SKforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 528);
            this.Controls.Add(this.dateTimePickerPRoduction);
            this.Controls.Add(this.lbl_date_of_production);
            this.Controls.Add(this.txt_BrandId);
            this.Controls.Add(this.lbl_BrandId);
            this.Controls.Add(this.txt_BearingId);
            this.Controls.Add(this.lbl_Bearing_Id);
            this.Controls.Add(this.txt_Hardware);
            this.Controls.Add(this.lbl_Hardware);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDbTitle);
            this.Controls.Add(this.txt_Wheel_Id);
            this.Controls.Add(this.txt_DeckId);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_WheelId);
            this.Controls.Add(this.lbl_DeckId);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Name = "SKforms";
            this.Text = "SKforms";
            this.Load += new System.EventHandler(this.SKforms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDbTitle;
        private System.Windows.Forms.TextBox txt_Wheel_Id;
        private System.Windows.Forms.TextBox txt_DeckId;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label txt_WheelId;
        private System.Windows.Forms.Label lbl_DeckId;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_Hardware;
        private System.Windows.Forms.TextBox txt_Hardware;
        private System.Windows.Forms.Label lbl_Bearing_Id;
        private System.Windows.Forms.TextBox txt_BearingId;
        private System.Windows.Forms.Label lbl_BrandId;
        private System.Windows.Forms.TextBox txt_BrandId;
        private System.Windows.Forms.Label lbl_date_of_production;
        private System.Windows.Forms.DateTimePicker dateTimePickerPRoduction;
    }
}