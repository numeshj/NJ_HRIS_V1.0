namespace Test_25_05_2024
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txt_name = new TextBox();
            txt_basicSal = new TextBox();
            btn_save = new Button();
            member = new DataGridView();
            btn_update = new Button();
            label3 = new Label();
            txt_id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)member).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 75);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 132);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Basic Salary";
            label2.Click += label2_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(181, 73);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(256, 27);
            txt_name.TabIndex = 2;
            // 
            // txt_basicSal
            // 
            txt_basicSal.Location = new Point(181, 129);
            txt_basicSal.Name = "txt_basicSal";
            txt_basicSal.Size = new Size(256, 27);
            txt_basicSal.TabIndex = 3;
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_save.Location = new Point(357, 213);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(119, 42);
            btn_save.TabIndex = 4;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // member
            // 
            member.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            member.Location = new Point(508, 75);
            member.Name = "member";
            member.RowHeadersWidth = 51;
            member.Size = new Size(541, 329);
            member.TabIndex = 5;
            member.CellContentClick += member_CellContentClick;
            member.CellContentDoubleClick += member_CellContentDoubleClick;
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_update.Location = new Point(357, 270);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(119, 42);
            btn_update.TabIndex = 6;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 29);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 7;
            label3.Text = "ID";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(181, 26);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(256, 27);
            txt_id.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 424);
            Controls.Add(txt_id);
            Controls.Add(label3);
            Controls.Add(btn_update);
            Controls.Add(member);
            Controls.Add(btn_save);
            Controls.Add(txt_basicSal);
            Controls.Add(txt_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)member).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_name;
        private TextBox txt_basicSal;
        private Button btn_save;
        private DataGridView member;
        private Button btn_update;
        private Label label3;
        private TextBox txt_id;
    }
}
