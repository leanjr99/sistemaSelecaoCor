
namespace Lab_02
{
    partial class lab02Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vermelhoLabel = new System.Windows.Forms.Label();
            this.verdeLabel = new System.Windows.Forms.Label();
            this.azulLabel = new System.Windows.Forms.Label();
            this.corLabel = new System.Windows.Forms.Label();
            this.vermelhoHScrollBar = new System.Windows.Forms.HScrollBar();
            this.verdeHScrollBar = new System.Windows.Forms.HScrollBar();
            this.azulHScrollBar = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(28, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(28, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 6;
            // 
            // vermelhoLabel
            // 
            this.vermelhoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vermelhoLabel.Location = new System.Drawing.Point(138, 9);
            this.vermelhoLabel.Name = "vermelhoLabel";
            this.vermelhoLabel.Size = new System.Drawing.Size(89, 16);
            this.vermelhoLabel.TabIndex = 1;
            // 
            // verdeLabel
            // 
            this.verdeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verdeLabel.Location = new System.Drawing.Point(138, 46);
            this.verdeLabel.Name = "verdeLabel";
            this.verdeLabel.Size = new System.Drawing.Size(89, 16);
            this.verdeLabel.TabIndex = 4;
            // 
            // azulLabel
            // 
            this.azulLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.azulLabel.Location = new System.Drawing.Point(138, 83);
            this.azulLabel.Name = "azulLabel";
            this.azulLabel.Size = new System.Drawing.Size(89, 16);
            this.azulLabel.TabIndex = 7;
            // 
            // corLabel
            // 
            this.corLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.corLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.corLabel.Location = new System.Drawing.Point(28, 127);
            this.corLabel.Name = "corLabel";
            this.corLabel.Size = new System.Drawing.Size(413, 133);
            this.corLabel.TabIndex = 9;
            this.corLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vermelhoHScrollBar
            // 
            this.vermelhoHScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vermelhoHScrollBar.LargeChange = 1;
            this.vermelhoHScrollBar.Location = new System.Drawing.Point(241, 9);
            this.vermelhoHScrollBar.Maximum = 255;
            this.vermelhoHScrollBar.Name = "vermelhoHScrollBar";
            this.vermelhoHScrollBar.Size = new System.Drawing.Size(200, 18);
            this.vermelhoHScrollBar.TabIndex = 2;
            this.vermelhoHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vermelhoHScrollBar_Scroll);
            // 
            // verdeHScrollBar
            // 
            this.verdeHScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verdeHScrollBar.LargeChange = 1;
            this.verdeHScrollBar.Location = new System.Drawing.Point(241, 46);
            this.verdeHScrollBar.Maximum = 255;
            this.verdeHScrollBar.Name = "verdeHScrollBar";
            this.verdeHScrollBar.Size = new System.Drawing.Size(200, 18);
            this.verdeHScrollBar.TabIndex = 5;
            this.verdeHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.verdeHScrollBar_Scroll);
            // 
            // azulHScrollBar
            // 
            this.azulHScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.azulHScrollBar.LargeChange = 1;
            this.azulHScrollBar.Location = new System.Drawing.Point(241, 83);
            this.azulHScrollBar.Maximum = 255;
            this.azulHScrollBar.Name = "azulHScrollBar";
            this.azulHScrollBar.Size = new System.Drawing.Size(200, 18);
            this.azulHScrollBar.TabIndex = 8;
            this.azulHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.azulHScrollBar_Scroll);
            // 
            // lab02Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 319);
            this.Controls.Add(this.azulHScrollBar);
            this.Controls.Add(this.verdeHScrollBar);
            this.Controls.Add(this.vermelhoHScrollBar);
            this.Controls.Add(this.corLabel);
            this.Controls.Add(this.azulLabel);
            this.Controls.Add(this.verdeLabel);
            this.Controls.Add(this.vermelhoLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "lab02Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratório";
            this.Load += new System.EventHandler(this.lab02Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label vermelhoLabel;
        private System.Windows.Forms.Label verdeLabel;
        private System.Windows.Forms.Label azulLabel;
        private System.Windows.Forms.Label corLabel;
        private System.Windows.Forms.HScrollBar vermelhoHScrollBar;
        private System.Windows.Forms.HScrollBar verdeHScrollBar;
        private System.Windows.Forms.HScrollBar azulHScrollBar;
    }
}

