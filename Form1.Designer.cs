namespace LC3IDE
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
            this.tabFlowPanel = new System.Windows.Forms.Button();
            this.mainEditPanel = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.fileBttn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFlowPanel
            // 
            this.tabFlowPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.tabFlowPanel.FlatAppearance.BorderSize = 0;
            this.tabFlowPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabFlowPanel.ForeColor = System.Drawing.Color.White;
            this.tabFlowPanel.Location = new System.Drawing.Point(3, 3);
            this.tabFlowPanel.Name = "tabFlowPanel";
            this.tabFlowPanel.Size = new System.Drawing.Size(144, 30);
            this.tabFlowPanel.TabIndex = 0;
            this.tabFlowPanel.Text = "repcode.asm";
            this.tabFlowPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabFlowPanel.UseVisualStyleBackColor = false;
            // 
            // mainEditPanel
            // 
            this.mainEditPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mainEditPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainEditPanel.Location = new System.Drawing.Point(3, 30);
            this.mainEditPanel.Name = "mainEditPanel";
            this.mainEditPanel.Size = new System.Drawing.Size(719, 402);
            this.mainEditPanel.TabIndex = 1;
            this.mainEditPanel.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tabFlowPanel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(694, 30);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(691, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // fileBttn
            // 
            this.fileBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fileBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileBttn.ForeColor = System.Drawing.Color.White;
            this.fileBttn.Location = new System.Drawing.Point(3, 438);
            this.fileBttn.Name = "fileBttn";
            this.fileBttn.Size = new System.Drawing.Size(108, 23);
            this.fileBttn.TabIndex = 1;
            this.fileBttn.Text = "File";
            this.fileBttn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(117, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Error List";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(231, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Assemble";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(721, 467);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.fileBttn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.mainEditPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tabFlowPanel;
        private System.Windows.Forms.RichTextBox mainEditPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button fileBttn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

