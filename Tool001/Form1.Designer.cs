namespace Tool001
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rTB1 = new System.Windows.Forms.RichTextBox();
            this.rTB2 = new System.Windows.Forms.RichTextBox();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Field 1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Field 2";
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.Control;
            this.b1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(29, 414);
            this.b1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(110, 29);
            this.b1.TabIndex = 4;
            this.b1.Text = "Check";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Visible = false;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(651, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "This tool check differences between Field 1 and Field 2.";
            // 
            // rTB1
            // 
            this.rTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTB1.Location = new System.Drawing.Point(29, 54);
            this.rTB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rTB1.Name = "rTB1";
            this.rTB1.Size = new System.Drawing.Size(1418, 159);
            this.rTB1.TabIndex = 7;
            this.rTB1.Text = "";
            this.rTB1.Click += new System.EventHandler(this.rTB1_Click);
            this.rTB1.SizeChanged += new System.EventHandler(this.rTB1_TextChanged);
            this.rTB1.TextChanged += new System.EventHandler(this.rTB1_TextChanged);
            this.rTB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rTB1_KeyPress);
            // 
            // rTB2
            // 
            this.rTB2.BackColor = System.Drawing.Color.DimGray;
            this.rTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTB2.Location = new System.Drawing.Point(29, 251);
            this.rTB2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rTB2.Name = "rTB2";
            this.rTB2.Size = new System.Drawing.Size(1418, 159);
            this.rTB2.TabIndex = 8;
            this.rTB2.Text = "";
            this.rTB2.Click += new System.EventHandler(this.rTB2_Click);
            this.rTB2.SizeChanged += new System.EventHandler(this.rTB2_TextChanged);
            this.rTB2.TextChanged += new System.EventHandler(this.rTB2_TextChanged);
            this.rTB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rTB2_KeyPress);
            // 
            // b2
            // 
            this.b2.AutoSize = true;
            this.b2.BackColor = System.Drawing.SystemColors.Control;
            this.b2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(562, 424);
            this.b2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(141, 34);
            this.b2.TabIndex = 9;
            this.b2.Text = "Clear Field1";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Visible = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.AutoSize = true;
            this.b3.BackColor = System.Drawing.SystemColors.Control;
            this.b3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(727, 424);
            this.b3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(141, 34);
            this.b3.TabIndex = 10;
            this.b3.Text = "Clear Field2";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Visible = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(279, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "SOFtware GRowing And more";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(136, 561);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(640, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "(708)770-9895                                           sofgra2011@gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 732);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.rTB2);
            this.Controls.Add(this.rTB1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "T00l001 Check two fields";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rTB1;
        private System.Windows.Forms.RichTextBox rTB2;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

    }
}

