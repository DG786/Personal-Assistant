namespace WindowsFormsApplication1
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
            this.hh = new System.Windows.Forms.RichTextBox();
            this.mm = new System.Windows.Forms.RichTextBox();
            this.tt = new System.Windows.Forms.RichTextBox();
            this.Set = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hh
            // 
            this.hh.Location = new System.Drawing.Point(140, 13);
            this.hh.Name = "hh";
            this.hh.Size = new System.Drawing.Size(34, 30);
            this.hh.TabIndex = 1;
            this.hh.Text = "";
            this.hh.TextChanged += new System.EventHandler(this.hh_TextChanged);
            // 
            // mm
            // 
            this.mm.Location = new System.Drawing.Point(181, 13);
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(31, 30);
            this.mm.TabIndex = 2;
            this.mm.Text = "";
            this.mm.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // tt
            // 
            this.tt.Location = new System.Drawing.Point(219, 13);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(31, 30);
            this.tt.TabIndex = 3;
            this.tt.Text = "";
            // 
            // Set
            // 
            this.Set.Location = new System.Drawing.Point(140, 64);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(72, 36);
            this.Set.TabIndex = 4;
            this.Set.Text = "Set Alarm";
            this.Set.UseVisualStyleBackColor = true;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(219, 106);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(44, 22);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alarm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 152);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Set);
            this.Controls.Add(this.tt);
            this.Controls.Add(this.mm);
            this.Controls.Add(this.hh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox hh;
        private System.Windows.Forms.RichTextBox mm;
        private System.Windows.Forms.RichTextBox tt;
        private System.Windows.Forms.Button Set;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
    }
}

