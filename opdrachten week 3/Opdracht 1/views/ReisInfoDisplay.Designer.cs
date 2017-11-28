using Opdracht_1.interfaces;

namespace Opdracht_1.views
{
    partial class ReisInfoDisplay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSpoor = new System.Windows.Forms.Label();
            this.labelStation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huidig station:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Spoor:";
            // 
            // labelSpoor
            // 
            this.labelSpoor.AutoSize = true;
            this.labelSpoor.Location = new System.Drawing.Point(94, 46);
            this.labelSpoor.Name = "labelSpoor";
            this.labelSpoor.Size = new System.Drawing.Size(19, 13);
            this.labelSpoor.TabIndex = 2;
            this.labelSpoor.Text = "----";
            // 
            // labelStation
            // 
            this.labelStation.AutoSize = true;
            this.labelStation.Location = new System.Drawing.Point(94, 13);
            this.labelStation.Name = "labelStation";
            this.labelStation.Size = new System.Drawing.Size(19, 13);
            this.labelStation.TabIndex = 3;
            this.labelStation.Text = "----";
            // 
            // ReisInfoDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 84);
            this.Controls.Add(this.labelStation);
            this.Controls.Add(this.labelSpoor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReisInfoDisplay";
            this.Text = "ReisInfoDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSpoor;
        private System.Windows.Forms.Label labelStation;
    }
}