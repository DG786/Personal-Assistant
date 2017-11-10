namespace Cortana
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            this.ExitApp = new System.Windows.Forms.Button();
            this.Duplicates = new System.Windows.Forms.CheckedListBox();
            this.Delete = new System.Windows.Forms.Button();
            this.selectall = new System.Windows.Forms.CheckBox();
            this.done = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(41, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(73, 22);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = " Welcome";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(41, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(124, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Enter path of directory";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(190, 42);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(366, 20);
            this.path.TabIndex = 2;
            this.path.TextChanged += new System.EventHandler(this.path_TextChanged);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(574, 42);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 4;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // ExitApp
            // 
            this.ExitApp.Location = new System.Drawing.Point(598, 327);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(75, 23);
            this.ExitApp.TabIndex = 5;
            this.ExitApp.Text = "Exit";
            this.ExitApp.UseVisualStyleBackColor = true;
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // Duplicates
            // 
            this.Duplicates.FormattingEnabled = true;
            this.Duplicates.Location = new System.Drawing.Point(41, 94);
            this.Duplicates.Name = "Duplicates";
            this.Duplicates.Size = new System.Drawing.Size(515, 274);
            this.Duplicates.TabIndex = 6;
            this.Duplicates.Visible = false;
            this.Duplicates.SelectedIndexChanged += new System.EventHandler(this.Duplicates_SelectedIndexChanged);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(574, 80);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Visible = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // selectall
            // 
            this.selectall.AutoSize = true;
            this.selectall.Location = new System.Drawing.Point(44, 77);
            this.selectall.Name = "selectall";
            this.selectall.Size = new System.Drawing.Size(70, 17);
            this.selectall.TabIndex = 8;
            this.selectall.Text = "Select All";
            this.selectall.UseVisualStyleBackColor = true;
            this.selectall.Visible = false;
            this.selectall.CheckedChanged += new System.EventHandler(this.selectall_CheckedChanged);
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(190, 169);
            this.done.Name = "done";
            this.done.ReadOnly = true;
            this.done.Size = new System.Drawing.Size(283, 20);
            this.done.TabIndex = 9;
            this.done.Visible = false;
            this.done.TextChanged += new System.EventHandler(this.done_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(719, 380);
            this.Controls.Add(this.done);
            this.Controls.Add(this.selectall);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Duplicates);
            this.Controls.Add(this.ExitApp);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.path);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Welcome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ListBox DuplicateFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button ExitApp;
        private System.Windows.Forms.CheckedListBox Duplicates;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.CheckBox selectall;
        private System.Windows.Forms.TextBox done;
    }
}

