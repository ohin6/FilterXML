
namespace FilterData
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Open = new System.Windows.Forms.Button();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.btn_Export = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(688, 43);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(84, 29);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 43);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 15);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Search :";
            // 
            // Txt_Search
            // 
            this.Txt_Search.Location = new System.Drawing.Point(66, 46);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(614, 23);
            this.Txt_Search.TabIndex = 2;
            this.Txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Search_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(745, 328);
            this.dataGridView1.TabIndex = 3;
            // 
            // Btn_Open
            // 
            this.Btn_Open.Location = new System.Drawing.Point(688, 8);
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.Size = new System.Drawing.Size(84, 29);
            this.Btn_Open.TabIndex = 4;
            this.Btn_Open.Text = "Open";
            this.Btn_Open.UseVisualStyleBackColor = true;
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Location = new System.Drawing.Point(22, 426);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(80, 15);
            this.Lbl_Total.TabIndex = 6;
            this.Lbl_Total.Text = "Total Records:";
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(688, 426);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(84, 29);
            this.btn_Export.TabIndex = 7;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.Lbl_Total);
            this.Controls.Add(this.Btn_Open);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btn_Search);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Open;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

