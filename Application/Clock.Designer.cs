
namespace CycleClockSystem
{
    partial class Clock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock));
            this.cycleTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.info = new System.Windows.Forms.Button();
            this.notUpdatedLabel = new System.Windows.Forms.Label();
            this.notUpdatedButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cycleTime
            // 
            this.cycleTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cycleTime.AutoSize = true;
            this.cycleTime.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycleTime.Location = new System.Drawing.Point(82, 59);
            this.cycleTime.Name = "cycleTime";
            this.cycleTime.Size = new System.Drawing.Size(131, 34);
            this.cycleTime.TabIndex = 0;
            this.cycleTime.Text = "00:00:00";
            this.cycleTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.notUpdatedButton);
            this.panel1.Controls.Add(this.notUpdatedLabel);
            this.panel1.Controls.Add(this.info);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 28);
            this.panel1.TabIndex = 1;
            // 
            // info
            // 
            this.info.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.info.BackColor = System.Drawing.SystemColors.Highlight;
            this.info.Location = new System.Drawing.Point(245, 3);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(75, 23);
            this.info.TabIndex = 0;
            this.info.Text = "Info";
            this.info.UseVisualStyleBackColor = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // notUpdatedLabel
            // 
            this.notUpdatedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.notUpdatedLabel.AutoSize = true;
            this.notUpdatedLabel.Location = new System.Drawing.Point(84, 8);
            this.notUpdatedLabel.Name = "notUpdatedLabel";
            this.notUpdatedLabel.Size = new System.Drawing.Size(107, 13);
            this.notUpdatedLabel.TabIndex = 2;
            this.notUpdatedLabel.Text = "You are not updated!";
            // 
            // notUpdatedButton
            // 
            this.notUpdatedButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.notUpdatedButton.BackColor = System.Drawing.Color.DarkOrange;
            this.notUpdatedButton.Location = new System.Drawing.Point(3, 3);
            this.notUpdatedButton.Name = "notUpdatedButton";
            this.notUpdatedButton.Size = new System.Drawing.Size(75, 23);
            this.notUpdatedButton.TabIndex = 3;
            this.notUpdatedButton.Text = "Update";
            this.notUpdatedButton.UseVisualStyleBackColor = false;
            this.notUpdatedButton.Click += new System.EventHandler(this.notUpdatedButton_Click);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 118);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cycleTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(341, 157);
            this.Name = "Clock";
            this.Text = "Cycle Clock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cycleTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button notUpdatedButton;
        private System.Windows.Forms.Label notUpdatedLabel;
    }
}

