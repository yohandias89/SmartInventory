namespace SmartInventory
{
    partial class Dashboard
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            panel7 = new Panel();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 673);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(303, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(1279, 125);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(303, 144);
            panel3.Name = "panel3";
            panel3.Size = new Size(490, 541);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Location = new Point(799, 147);
            panel4.Name = "panel4";
            panel4.Size = new Size(515, 538);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Location = new Point(1320, 147);
            panel5.Name = "panel5";
            panel5.Size = new Size(262, 538);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Controls.Add(label1);
            panel6.Location = new Point(10, 13);
            panel6.Name = "panel6";
            panel6.Size = new Size(285, 57);
            panel6.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 36);
            label1.TabIndex = 0;
            label1.Text = "Smart Inventroy";
            // 
            // panel7
            // 
            panel7.Location = new Point(10, 76);
            panel7.Name = "panel7";
            panel7.Size = new Size(287, 51);
            panel7.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1594, 697);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label1;
        private Panel panel7;
    }
}