namespace Opdracht_1.views
{
    partial class ControlPanel
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
            this.btnVolgendStation = new System.Windows.Forms.Button();
            this.Nieuw_Display = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolgendStation
            // 
            this.btnVolgendStation.Location = new System.Drawing.Point(51, 60);
            this.btnVolgendStation.Name = "btnVolgendStation";
            this.btnVolgendStation.Size = new System.Drawing.Size(177, 66);
            this.btnVolgendStation.TabIndex = 0;
            this.btnVolgendStation.Text = "Volgend Station";
            this.btnVolgendStation.UseVisualStyleBackColor = true;
            this.btnVolgendStation.Click += new System.EventHandler(this.btnVolgendStation_Click);
            // 
            // Nieuw_Display
            // 
            this.Nieuw_Display.Location = new System.Drawing.Point(13, 226);
            this.Nieuw_Display.Name = "Nieuw_Display";
            this.Nieuw_Display.Size = new System.Drawing.Size(136, 23);
            this.Nieuw_Display.TabIndex = 1;
            this.Nieuw_Display.Text = "Nieuw display";
            this.Nieuw_Display.UseVisualStyleBackColor = true;
            this.Nieuw_Display.Click += new System.EventHandler(this.Nieuw_Display_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Nieuw_Display);
            this.Controls.Add(this.btnVolgendStation);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolgendStation;
        private System.Windows.Forms.Button Nieuw_Display;
    }
}