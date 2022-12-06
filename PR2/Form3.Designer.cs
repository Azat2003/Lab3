namespace PR2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnDraw = new System.Windows.Forms.Button();
            this.y_3 = new System.Windows.Forms.TextBox();
            this.x_3 = new System.Windows.Forms.TextBox();
            this.y_2 = new System.Windows.Forms.TextBox();
            this.x_2 = new System.Windows.Forms.TextBox();
            this.y_1 = new System.Windows.Forms.TextBox();
            this.x_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.Navy;
            this.btnDraw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDraw.BackgroundImage")));
            this.btnDraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraw.Location = new System.Drawing.Point(101, 104);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(2);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(62, 63);
            this.btnDraw.TabIndex = 19;
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // y_3
            // 
            this.y_3.Location = new System.Drawing.Point(209, 79);
            this.y_3.Margin = new System.Windows.Forms.Padding(2);
            this.y_3.Name = "y_3";
            this.y_3.Size = new System.Drawing.Size(38, 20);
            this.y_3.TabIndex = 18;
            // 
            // x_3
            // 
            this.x_3.Location = new System.Drawing.Point(209, 49);
            this.x_3.Margin = new System.Windows.Forms.Padding(2);
            this.x_3.Name = "x_3";
            this.x_3.Size = new System.Drawing.Size(38, 20);
            this.x_3.TabIndex = 17;
            // 
            // y_2
            // 
            this.y_2.Location = new System.Drawing.Point(125, 78);
            this.y_2.Margin = new System.Windows.Forms.Padding(2);
            this.y_2.Name = "y_2";
            this.y_2.Size = new System.Drawing.Size(38, 20);
            this.y_2.TabIndex = 16;
            // 
            // x_2
            // 
            this.x_2.Location = new System.Drawing.Point(125, 49);
            this.x_2.Margin = new System.Windows.Forms.Padding(2);
            this.x_2.Name = "x_2";
            this.x_2.Size = new System.Drawing.Size(38, 20);
            this.x_2.TabIndex = 15;
            // 
            // y_1
            // 
            this.y_1.Location = new System.Drawing.Point(43, 79);
            this.y_1.Margin = new System.Windows.Forms.Padding(2);
            this.y_1.Name = "y_1";
            this.y_1.Size = new System.Drawing.Size(38, 20);
            this.y_1.TabIndex = 14;
            // 
            // x_1
            // 
            this.x_1.Location = new System.Drawing.Point(43, 49);
            this.x_1.Margin = new System.Windows.Forms.Padding(2);
            this.x_1.Name = "x_1";
            this.x_1.Size = new System.Drawing.Size(38, 20);
            this.x_1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите координаты трех точек";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 178);
            this.panel1.TabIndex = 20;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 178);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.y_3);
            this.Controls.Add(this.x_3);
            this.Controls.Add(this.y_2);
            this.Controls.Add(this.x_2);
            this.Controls.Add(this.y_1);
            this.Controls.Add(this.x_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox y_3;
        private System.Windows.Forms.TextBox x_3;
        private System.Windows.Forms.TextBox y_2;
        private System.Windows.Forms.TextBox x_2;
        private System.Windows.Forms.TextBox y_1;
        private System.Windows.Forms.TextBox x_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}