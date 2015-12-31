namespace TextCleaner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InputTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.CleanButton = new System.Windows.Forms.Button();
            this.Pastebutton = new System.Windows.Forms.Button();
            this.Copybutton = new System.Windows.Forms.Button();
            this.CRFix = new System.Windows.Forms.Button();
            this.SpaceRem = new System.Windows.Forms.Button();
            this.RemoveBox = new System.Windows.Forms.TextBox();
            this.ReplaceBox = new System.Windows.Forms.TextBox();
            this.Remove = new System.Windows.Forms.Button();
            this.Replace = new System.Windows.Forms.Button();
            this.RemBeforeButton = new System.Windows.Forms.Button();
            this.RemAfterButton = new System.Windows.Forms.Button();
            this.RemBeforeBox = new System.Windows.Forms.TextBox();
            this.RemAfterBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.ContextMenuStrip = this.contextMenuStrip1;
            this.InputTextBox.Location = new System.Drawing.Point(12, 93);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(780, 513);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCopy,
            this.cmsPaste});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // cmsCopy
            // 
            this.cmsCopy.Name = "cmsCopy";
            this.cmsCopy.Size = new System.Drawing.Size(101, 22);
            this.cmsCopy.Text = "Copy";
            // 
            // cmsPaste
            // 
            this.cmsPaste.Name = "cmsPaste";
            this.cmsPaste.Size = new System.Drawing.Size(101, 22);
            this.cmsPaste.Text = "Paste";
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(12, 64);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(75, 23);
            this.CleanButton.TabIndex = 0;
            this.CleanButton.Text = "Clean <>";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // Pastebutton
            // 
            this.Pastebutton.Location = new System.Drawing.Point(93, 64);
            this.Pastebutton.Name = "Pastebutton";
            this.Pastebutton.Size = new System.Drawing.Size(75, 23);
            this.Pastebutton.TabIndex = 1;
            this.Pastebutton.Text = "Paste";
            this.Pastebutton.UseVisualStyleBackColor = true;
            this.Pastebutton.Click += new System.EventHandler(this.Pastebutton_Click);
            // 
            // Copybutton
            // 
            this.Copybutton.Location = new System.Drawing.Point(175, 64);
            this.Copybutton.Name = "Copybutton";
            this.Copybutton.Size = new System.Drawing.Size(75, 23);
            this.Copybutton.TabIndex = 2;
            this.Copybutton.Text = "Copy";
            this.Copybutton.UseVisualStyleBackColor = true;
            this.Copybutton.Click += new System.EventHandler(this.Copybutton_Click);
            // 
            // CRFix
            // 
            this.CRFix.Location = new System.Drawing.Point(13, 35);
            this.CRFix.Name = "CRFix";
            this.CRFix.Size = new System.Drawing.Size(75, 23);
            this.CRFix.TabIndex = 3;
            this.CRFix.Text = "Fix CR";
            this.CRFix.UseVisualStyleBackColor = true;
            this.CRFix.Click += new System.EventHandler(this.CRFix_Click);
            // 
            // SpaceRem
            // 
            this.SpaceRem.Location = new System.Drawing.Point(93, 35);
            this.SpaceRem.Name = "SpaceRem";
            this.SpaceRem.Size = new System.Drawing.Size(157, 23);
            this.SpaceRem.TabIndex = 4;
            this.SpaceRem.Text = "Remove Extra Spaces";
            this.SpaceRem.UseVisualStyleBackColor = true;
            this.SpaceRem.Click += new System.EventHandler(this.SpaceRem_Click);
            // 
            // RemoveBox
            // 
            this.RemoveBox.Location = new System.Drawing.Point(549, 37);
            this.RemoveBox.Name = "RemoveBox";
            this.RemoveBox.Size = new System.Drawing.Size(243, 20);
            this.RemoveBox.TabIndex = 5;
            // 
            // ReplaceBox
            // 
            this.ReplaceBox.Location = new System.Drawing.Point(549, 64);
            this.ReplaceBox.Name = "ReplaceBox";
            this.ReplaceBox.Size = new System.Drawing.Size(243, 20);
            this.ReplaceBox.TabIndex = 6;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(468, 34);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 7;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Replace
            // 
            this.Replace.Location = new System.Drawing.Point(468, 64);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(75, 23);
            this.Replace.TabIndex = 8;
            this.Replace.Text = "Replace";
            this.Replace.UseVisualStyleBackColor = true;
            this.Replace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // RemBeforeButton
            // 
            this.RemBeforeButton.Location = new System.Drawing.Point(256, 35);
            this.RemBeforeButton.Name = "RemBeforeButton";
            this.RemBeforeButton.Size = new System.Drawing.Size(92, 23);
            this.RemBeforeButton.TabIndex = 9;
            this.RemBeforeButton.Text = "Remove before:";
            this.RemBeforeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemBeforeButton.UseVisualStyleBackColor = true;
            this.RemBeforeButton.Click += new System.EventHandler(this.RemBeforeButton_Click);
            // 
            // RemAfterButton
            // 
            this.RemAfterButton.Location = new System.Drawing.Point(256, 64);
            this.RemAfterButton.Name = "RemAfterButton";
            this.RemAfterButton.Size = new System.Drawing.Size(92, 23);
            this.RemAfterButton.TabIndex = 10;
            this.RemAfterButton.Text = "Remove After:";
            this.RemAfterButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemAfterButton.UseVisualStyleBackColor = true;
            this.RemAfterButton.Click += new System.EventHandler(this.RemAfterButton_Click);
            // 
            // RemBeforeBox
            // 
            this.RemBeforeBox.Location = new System.Drawing.Point(354, 37);
            this.RemBeforeBox.Name = "RemBeforeBox";
            this.RemBeforeBox.Size = new System.Drawing.Size(45, 20);
            this.RemBeforeBox.TabIndex = 11;
            this.RemBeforeBox.Text = "9";
            // 
            // RemAfterBox
            // 
            this.RemAfterBox.Location = new System.Drawing.Point(354, 64);
            this.RemAfterBox.Name = "RemAfterBox";
            this.RemAfterBox.Size = new System.Drawing.Size(45, 20);
            this.RemAfterBox.TabIndex = 12;
            this.RemAfterBox.Text = "40";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 618);
            this.Controls.Add(this.RemAfterBox);
            this.Controls.Add(this.RemBeforeBox);
            this.Controls.Add(this.RemAfterButton);
            this.Controls.Add(this.RemBeforeButton);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.ReplaceBox);
            this.Controls.Add(this.RemoveBox);
            this.Controls.Add(this.SpaceRem);
            this.Controls.Add(this.CRFix);
            this.Controls.Add(this.Copybutton);
            this.Controls.Add(this.Pastebutton);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.InputTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Jim\'s Cheesy Text Cleaner";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InputTextBox;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Button Pastebutton;
        private System.Windows.Forms.Button Copybutton;
        private System.Windows.Forms.Button CRFix;
        private System.Windows.Forms.Button SpaceRem;
        private System.Windows.Forms.TextBox RemoveBox;
        private System.Windows.Forms.TextBox ReplaceBox;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Replace;
        private System.Windows.Forms.Button RemBeforeButton;
        private System.Windows.Forms.Button RemAfterButton;
        private System.Windows.Forms.TextBox RemBeforeBox;
        private System.Windows.Forms.TextBox RemAfterBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsCopy;
        private System.Windows.Forms.ToolStripMenuItem cmsPaste;
    }
}

