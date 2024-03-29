﻿namespace SkateBoardDisplay
{
    partial class WheelForm
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
            this.txtWheelShape = new System.Windows.Forms.TextBox();
            this.txt_Hardness = new System.Windows.Forms.TextBox();
            this.txt_Wheels_size = new System.Windows.Forms.TextBox();
            this.txt_Wheels_shape = new System.Windows.Forms.Label();
            this.lbl_Hardness = new System.Windows.Forms.Label();
            this.lbl_Wheels_size = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Location = new System.Drawing.Point(505, 431);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(84, 46);
            this.btn_Save.TabIndex = 26;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(433, 278);
            this.dataGridView1.TabIndex = 25;
            // 
            // lblDbTitle
            // 
            this.lblDbTitle.AutoSize = true;
            this.lblDbTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDbTitle.Location = new System.Drawing.Point(487, 20);
            this.lblDbTitle.Name = "lblDbTitle";
            this.lblDbTitle.Size = new System.Drawing.Size(98, 25);
            this.lblDbTitle.TabIndex = 24;
            this.lblDbTitle.Text = "WheelsDb";
            this.lblDbTitle.Click += new System.EventHandler(this.lblDbTitle_Click);
            // 
            // txtWheelShape
            // 
            this.txtWheelShape.Location = new System.Drawing.Point(120, 125);
            this.txtWheelShape.Name = "txtWheelShape";
            this.txtWheelShape.Size = new System.Drawing.Size(100, 23);
            this.txtWheelShape.TabIndex = 23;
            this.txtWheelShape.TextChanged += new System.EventHandler(this.txtWheelShape_TextChanged);
            // 
            // txt_Hardness
            // 
            this.txt_Hardness.Location = new System.Drawing.Point(120, 71);
            this.txt_Hardness.Name = "txt_Hardness";
            this.txt_Hardness.Size = new System.Drawing.Size(100, 23);
            this.txt_Hardness.TabIndex = 22;
            // 
            // txt_Wheels_size
            // 
            this.txt_Wheels_size.Location = new System.Drawing.Point(120, 30);
            this.txt_Wheels_size.Name = "txt_Wheels_size";
            this.txt_Wheels_size.Size = new System.Drawing.Size(100, 23);
            this.txt_Wheels_size.TabIndex = 21;
            // 
            // txt_Wheels_shape
            // 
            this.txt_Wheels_shape.AutoSize = true;
            this.txt_Wheels_shape.Location = new System.Drawing.Point(27, 125);
            this.txt_Wheels_shape.Name = "txt_Wheels_shape";
            this.txt_Wheels_shape.Size = new System.Drawing.Size(79, 15);
            this.txt_Wheels_shape.TabIndex = 20;
            this.txt_Wheels_shape.Text = "Wheels shape";
            // 
            // lbl_Hardness
            // 
            this.lbl_Hardness.AutoSize = true;
            this.lbl_Hardness.Location = new System.Drawing.Point(27, 79);
            this.lbl_Hardness.Name = "lbl_Hardness";
            this.lbl_Hardness.Size = new System.Drawing.Size(56, 15);
            this.lbl_Hardness.TabIndex = 19;
            this.lbl_Hardness.Text = "Hardness";
            // 
            // lbl_Wheels_size
            // 
            this.lbl_Wheels_size.AutoSize = true;
            this.lbl_Wheels_size.Location = new System.Drawing.Point(27, 30);
            this.lbl_Wheels_size.Name = "lbl_Wheels_size";
            this.lbl_Wheels_size.Size = new System.Drawing.Size(67, 15);
            this.lbl_Wheels_size.TabIndex = 18;
            this.lbl_Wheels_size.Text = "Wheels size";
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(328, 359);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(84, 46);
            this.btn_Add.TabIndex = 17;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(505, 359);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(84, 46);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Location = new System.Drawing.Point(677, 359);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(84, 46);
            this.btn_Update.TabIndex = 15;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // WheelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 614);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDbTitle);
            this.Controls.Add(this.txtWheelShape);
            this.Controls.Add(this.txt_Hardness);
            this.Controls.Add(this.txt_Wheels_size);
            this.Controls.Add(this.txt_Wheels_shape);
            this.Controls.Add(this.lbl_Hardness);
            this.Controls.Add(this.lbl_Wheels_size);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Name = "WheelForm";
            this.Text = "WheelForm";
            this.Load += new System.EventHandler(this.WheelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDbTitle;
        private System.Windows.Forms.TextBox txtWheelShape;
        private System.Windows.Forms.TextBox txt_Hardness;
        private System.Windows.Forms.TextBox txt_Wheels_size;
        private System.Windows.Forms.Label txt_Wheels_shape;
        private System.Windows.Forms.Label lbl_Hardness;
        private System.Windows.Forms.Label lbl_Wheels_size;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
    }
}