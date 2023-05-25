namespace SkateBoardDisplay
{
    partial class DecksForm
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
            this.txt_DeckConcave = new System.Windows.Forms.TextBox();
            this.txt_DeckShape = new System.Windows.Forms.TextBox();
            this.txt_Wood_type = new System.Windows.Forms.TextBox();
            this.txt_Deck_concave = new System.Windows.Forms.Label();
            this.lbl_Deck_shape = new System.Windows.Forms.Label();
            this.lbl_Wood_type = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Location = new System.Drawing.Point(475, 410);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(84, 46);
            this.btn_Save.TabIndex = 35;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(299, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(433, 278);
            this.dataGridView1.TabIndex = 34;
            // 
            // lblDbTitle
            // 
            this.lblDbTitle.AutoSize = true;
            this.lblDbTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDbTitle.Location = new System.Drawing.Point(475, 9);
            this.lblDbTitle.Name = "lblDbTitle";
            this.lblDbTitle.Size = new System.Drawing.Size(77, 25);
            this.lblDbTitle.TabIndex = 33;
            this.lblDbTitle.Text = "DeckDb";
            // 
            // txt_DeckConcave
            // 
            this.txt_DeckConcave.Location = new System.Drawing.Point(106, 130);
            this.txt_DeckConcave.Name = "txt_DeckConcave";
            this.txt_DeckConcave.Size = new System.Drawing.Size(100, 23);
            this.txt_DeckConcave.TabIndex = 32;
            // 
            // txt_DeckShape
            // 
            this.txt_DeckShape.Location = new System.Drawing.Point(106, 84);
            this.txt_DeckShape.Name = "txt_DeckShape";
            this.txt_DeckShape.Size = new System.Drawing.Size(100, 23);
            this.txt_DeckShape.TabIndex = 31;
            // 
            // txt_Wood_type
            // 
            this.txt_Wood_type.Location = new System.Drawing.Point(106, 39);
            this.txt_Wood_type.Name = "txt_Wood_type";
            this.txt_Wood_type.Size = new System.Drawing.Size(100, 23);
            this.txt_Wood_type.TabIndex = 30;
            // 
            // txt_Deck_concave
            // 
            this.txt_Deck_concave.AutoSize = true;
            this.txt_Deck_concave.Location = new System.Drawing.Point(18, 133);
            this.txt_Deck_concave.Name = "txt_Deck_concave";
            this.txt_Deck_concave.Size = new System.Drawing.Size(82, 15);
            this.txt_Deck_concave.TabIndex = 29;
            this.txt_Deck_concave.Text = "Deck Concave";
            // 
            // lbl_Deck_shape
            // 
            this.lbl_Deck_shape.AutoSize = true;
            this.lbl_Deck_shape.Location = new System.Drawing.Point(26, 87);
            this.lbl_Deck_shape.Name = "lbl_Deck_shape";
            this.lbl_Deck_shape.Size = new System.Drawing.Size(68, 15);
            this.lbl_Deck_shape.TabIndex = 28;
            this.lbl_Deck_shape.Text = "Deck Shape";
            // 
            // lbl_Wood_type
            // 
            this.lbl_Wood_type.AutoSize = true;
            this.lbl_Wood_type.Location = new System.Drawing.Point(28, 42);
            this.lbl_Wood_type.Name = "lbl_Wood_type";
            this.lbl_Wood_type.Size = new System.Drawing.Size(66, 15);
            this.lbl_Wood_type.TabIndex = 27;
            this.lbl_Wood_type.Text = "Wood Type";
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(299, 345);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(84, 46);
            this.btn_Add.TabIndex = 26;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(475, 345);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(84, 46);
            this.btn_Delete.TabIndex = 25;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Location = new System.Drawing.Point(648, 345);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(84, 46);
            this.btn_Update.TabIndex = 24;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // DecksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 575);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDbTitle);
            this.Controls.Add(this.txt_DeckConcave);
            this.Controls.Add(this.txt_DeckShape);
            this.Controls.Add(this.txt_Wood_type);
            this.Controls.Add(this.txt_Deck_concave);
            this.Controls.Add(this.lbl_Deck_shape);
            this.Controls.Add(this.lbl_Wood_type);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Name = "DecksForm";
            this.Text = "DecksForm";
            this.Load += new System.EventHandler(this.DecksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDbTitle;
        private System.Windows.Forms.TextBox txt_DeckConcave;
        private System.Windows.Forms.TextBox txt_DeckShape;
        private System.Windows.Forms.TextBox txt_Wood_type;
        private System.Windows.Forms.Label txt_Deck_concave;
        private System.Windows.Forms.Label lbl_Deck_shape;
        private System.Windows.Forms.Label lbl_Wood_type;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
    }
}