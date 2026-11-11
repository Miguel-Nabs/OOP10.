namespace Artorius
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
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            Column = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnSubmit = new Button();
            txtWishlistName = new TextBox();
            txtItem1 = new TextBox();
            txtItem2 = new TextBox();
            txtAmount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(48, 41);
            label1.Name = "label1";
            label1.Size = new Size(123, 23);
            label1.TabIndex = 0;
            label1.Text = "Wishlist Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(48, 106);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 1;
            label2.Text = "Item 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(48, 174);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 2;
            label3.Text = "Item 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(48, 242);
            label4.Name = "label4";
            label4.Size = new Size(129, 23);
            label4.TabIndex = 3;
            label4.Text = "Amount Range:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column, Column1, Column2, Column3 });
            dataGridView1.Location = new Point(460, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(556, 407);
            dataGridView1.TabIndex = 4;
            // 
            // Column
            // 
            Column.HeaderText = "Name";
            Column.MinimumWidth = 6;
            Column.Name = "Column";
            Column.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Item 1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Item 2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Amount";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 10F);
            btnSubmit.Location = new Point(186, 306);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(235, 33);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtWishlistName
            // 
            txtWishlistName.Location = new Point(186, 40);
            txtWishlistName.Name = "txtWishlistName";
            txtWishlistName.Size = new Size(235, 27);
            txtWishlistName.TabIndex = 6;
            // 
            // txtItem1
            // 
            txtItem1.Location = new Point(186, 105);
            txtItem1.Name = "txtItem1";
            txtItem1.Size = new Size(235, 27);
            txtItem1.TabIndex = 7;
            // 
            // txtItem2
            // 
            txtItem2.Location = new Point(186, 173);
            txtItem2.Name = "txtItem2";
            txtItem2.Size = new Size(235, 27);
            txtItem2.TabIndex = 8;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(186, 242);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(235, 27);
            txtAmount.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 450);
            Controls.Add(txtAmount);
            Controls.Add(txtItem2);
            Controls.Add(txtItem1);
            Controls.Add(txtWishlistName);
            Controls.Add(btnSubmit);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btnSubmit;
        private TextBox txtWishlistName;
        private TextBox txtItem1;
        private TextBox txtItem2;
        private TextBox txtAmount;
    }
}
