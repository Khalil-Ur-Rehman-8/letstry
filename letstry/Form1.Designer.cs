namespace letstry
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
            this.Input_Reader = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input_Reader
            // 
            this.Input_Reader.AccessibleDescription = "";
            this.Input_Reader.AccessibleName = "Input_Reader";
            this.Input_Reader.Location = new System.Drawing.Point(30, 68);
            this.Input_Reader.Name = "Input_Reader";
            this.Input_Reader.Size = new System.Drawing.Size(419, 20);
            this.Input_Reader.TabIndex = 0;
            this.Input_Reader.Text = "Enter the number";
            this.Input_Reader.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_Reader_KeyDown);
            // 
            // Output
            // 
            this.Output.AccessibleName = "";
            this.Output.AutoSize = true;
            this.Output.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(54, 171);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(257, 21);
            this.Output.TabIndex = 2;
            this.Output.Tag = "";
            this.Output.Text = "The Result is shown here.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the Number one Million and Above Zero Please";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.label2.Location = new System.Drawing.Point(26, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(559, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "If a number is greater than 1 million it will only read lasts five digits of it";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input_Reader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Spelling Giver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_Reader;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

