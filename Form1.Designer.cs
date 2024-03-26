namespace ConfirmTaskOpen
{
    partial class ConfirmTaskOpen
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
            this.openBtn = new System.Windows.Forms.Button();
            this.pathTextbox = new System.Windows.Forms.TextBox();
            this.pathLable = new System.Windows.Forms.Label();
            this.shortcutBtn = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(442, 22);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 2;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // pathTextbox
            // 
            this.pathTextbox.Location = new System.Drawing.Point(12, 25);
            this.pathTextbox.Name = "pathTextbox";
            this.pathTextbox.Size = new System.Drawing.Size(209, 20);
            this.pathTextbox.TabIndex = 0;
            this.pathTextbox.TextChanged += new System.EventHandler(this.pathTextbox_TextChanged);
            // 
            // pathLable
            // 
            this.pathLable.AutoSize = true;
            this.pathLable.Location = new System.Drawing.Point(42, 9);
            this.pathLable.Name = "pathLable";
            this.pathLable.Size = new System.Drawing.Size(29, 13);
            this.pathLable.TabIndex = 3;
            this.pathLable.Text = "Path";
            // 
            // shortcutBtn
            // 
            this.shortcutBtn.Location = new System.Drawing.Point(523, 22);
            this.shortcutBtn.Name = "shortcutBtn";
            this.shortcutBtn.Size = new System.Drawing.Size(95, 23);
            this.shortcutBtn.TabIndex = 3;
            this.shortcutBtn.Text = "Create Shortcut";
            this.shortcutBtn.UseVisualStyleBackColor = true;
            this.shortcutBtn.Click += new System.EventHandler(this.shortcutBtn_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(257, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(227, 25);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(209, 20);
            this.nameTextbox.TabIndex = 1;
            // 
            // ConfirmTaskOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 62);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.shortcutBtn);
            this.Controls.Add(this.pathLable);
            this.Controls.Add(this.pathTextbox);
            this.Controls.Add(this.openBtn);
            this.KeyPreview = true;
            this.Name = "ConfirmTaskOpen";
            this.Text = "Confrim Task Open";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfirmTaskOpen_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.TextBox pathTextbox;
        private System.Windows.Forms.Label pathLable;
        private System.Windows.Forms.Button shortcutBtn;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox nameTextbox;
    }
}

