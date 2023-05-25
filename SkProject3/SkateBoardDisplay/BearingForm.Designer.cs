namespace SkateBoardDisplay
{
    partial class BearingForm
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
            this.txt_Coutry = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Country = new System.Windows.Forms.Label();
            this.lbl_Abec_ratiang = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txt_Abec_ratiang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Location = new System.Drawing.Point(428, 424);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(84, 46);
            this.btn_Save.TabIndex = 38;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(263, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(433, 278);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblDbTitle
            // 
            this.lblDbTitle.AutoSize = true;
            this.lblDbTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDbTitle.Location = new System.Drawing.Point(411, 9);
            this.lblDbTitle.Name = "lblDbTitle";
            this.lblDbTitle.Size = new System.Drawing.Size(101, 25);
            this.lblDbTitle.TabIndex = 36;
            this.lblDbTitle.Text = "BearingDb";
            // 
            // txt_Coutry
            // 
            this.txt_Coutry.Location = new System.Drawing.Point(91, 129);
            this.txt_Coutry.Name = "txt_Coutry";
            this.txt_Coutry.Size = new System.Drawing.Size(100, 23);
            this.txt_Coutry.TabIndex = 35;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(91, 34);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 23);
            this.txt_Name.TabIndex = 33;
            // 
            // txt_Country
            // 
            this.txt_Country.AutoSize = true;
            this.txt_Country.Location = new System.Drawing.Point(12, 132);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(50, 15);
            this.txt_Country.TabIndex = 32;
            this.txt_Country.Text = "Country";
            this.txt_Country.Click += new System.EventHandler(this.txt_Country_Click);
            // 
            // lbl_Abec_ratiang
            // 
            this.lbl_Abec_ratiang.AutoSize = true;
            this.lbl_Abec_ratiang.Location = new System.Drawing.Point(9, 89);
            this.lbl_Abec_ratiang.Name = "lbl_Abec_ratiang";
            this.lbl_Abec_ratiang.Size = new System.Drawing.Size(76, 15);
            this.lbl_Abec_ratiang.TabIndex = 31;
            this.lbl_Abec_ratiang.Text = "Abec_ratiang";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(23, 42);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(39, 15);
            this.lbl_Name.TabIndex = 30;
            this.lbl_Name.Text = "Name";
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(263, 347);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(84, 46);
            this.btn_Add.TabIndex = 29;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(428, 347);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(84, 46);
            this.btn_Delete.TabIndex = 28;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Location = new System.Drawing.Point(612, 347);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(84, 46);
            this.btn_Update.TabIndex = 27;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // txt_Abec_ratiang
            // 
            this.txt_Abec_ratiang.Location = new System.Drawing.Point(91, 81);
            this.txt_Abec_ratiang.Name = "txt_Abec_ratiang";
            this.txt_Abec_ratiang.Size = new System.Drawing.Size(100, 23);
            this.txt_Abec_ratiang.TabIndex = 39;
            // 
            // BearingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 631);
            this.Controls.Add(this.txt_Abec_ratiang);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDbTitle);
            this.Controls.Add(this.txt_Coutry);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.lbl_Abec_ratiang);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Name = "BearingForm";
            this.Text = "BearingForm";
            this.Load += new System.EventHandler(this.BearingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDbTitle;
        private System.Windows.Forms.TextBox txt_Coutry;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label txt_Country;
        private System.Windows.Forms.Label lbl_Abec_ratiang;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txt_Abec_ratiang;
    }
}