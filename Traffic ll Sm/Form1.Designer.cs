
namespace Traffic_ll_Sm
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
            this.Yellowlight = new System.Windows.Forms.Panel();
            this.GreenLight = new System.Windows.Forms.Panel();
            this.RedLight = new System.Windows.Forms.Panel();
            this.btnpress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Yellowlight
            // 
            this.Yellowlight.Location = new System.Drawing.Point(283, 154);
            this.Yellowlight.Name = "Yellowlight";
            this.Yellowlight.Size = new System.Drawing.Size(92, 70);
            this.Yellowlight.TabIndex = 0;
            this.Yellowlight.Paint += new System.Windows.Forms.PaintEventHandler(this.Yellowlight_Paint);
            // 
            // GreenLight
            // 
            this.GreenLight.Location = new System.Drawing.Point(283, 268);
            this.GreenLight.Name = "GreenLight";
            this.GreenLight.Size = new System.Drawing.Size(92, 70);
            this.GreenLight.TabIndex = 0;
            this.GreenLight.Paint += new System.Windows.Forms.PaintEventHandler(this.GreenLight_Paint);
            // 
            // RedLight
            // 
            this.RedLight.Location = new System.Drawing.Point(283, 54);
            this.RedLight.Name = "RedLight";
            this.RedLight.Size = new System.Drawing.Size(92, 70);
            this.RedLight.TabIndex = 0;
            this.RedLight.Paint += new System.Windows.Forms.PaintEventHandler(this.RedLight_Paint);
            // 
            // btnpress
            // 
            this.btnpress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpress.Location = new System.Drawing.Point(283, 350);
            this.btnpress.Name = "btnpress";
            this.btnpress.Size = new System.Drawing.Size(92, 61);
            this.btnpress.TabIndex = 1;
            this.btnpress.Text = "Press The Button";
            this.btnpress.UseVisualStyleBackColor = true;
            this.btnpress.Click += new System.EventHandler(this.btnpress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 480);
            this.Controls.Add(this.btnpress);
            this.Controls.Add(this.RedLight);
            this.Controls.Add(this.GreenLight);
            this.Controls.Add(this.Yellowlight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Yellowlight;
        private System.Windows.Forms.Panel GreenLight;
        private System.Windows.Forms.Panel RedLight;
        private System.Windows.Forms.Button btnpress;
    }
}

