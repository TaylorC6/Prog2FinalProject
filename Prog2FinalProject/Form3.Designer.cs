namespace Prog2FinalProject {
    partial class Form3 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.savingsbalance = new System.Windows.Forms.Label();
            this.investmentsbalance = new System.Windows.Forms.Label();
            this.checkingsbalance = new System.Windows.Forms.Label();
            this.L1 = new System.Windows.Forms.ListBox();
            this.L2 = new System.Windows.Forms.ListBox();
            this.L3 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.plotView2 = new OxyPlot.WindowsForms.PlotView();
            this.plotView3 = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // savingsbalance
            // 
            this.savingsbalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.savingsbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsbalance.Location = new System.Drawing.Point(12, 58);
            this.savingsbalance.Name = "savingsbalance";
            this.savingsbalance.Size = new System.Drawing.Size(239, 62);
            this.savingsbalance.TabIndex = 1;
            this.savingsbalance.Text = "Savings Account Balance: $0";
            this.savingsbalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.savingsbalance.Click += new System.EventHandler(this.savingsbalance_Click);
            // 
            // investmentsbalance
            // 
            this.investmentsbalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.investmentsbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investmentsbalance.Location = new System.Drawing.Point(498, 58);
            this.investmentsbalance.Name = "investmentsbalance";
            this.investmentsbalance.Size = new System.Drawing.Size(248, 62);
            this.investmentsbalance.TabIndex = 2;
            this.investmentsbalance.Text = "Investment Account Balance: $0";
            this.investmentsbalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkingsbalance
            // 
            this.checkingsbalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.checkingsbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkingsbalance.Location = new System.Drawing.Point(257, 58);
            this.checkingsbalance.Name = "checkingsbalance";
            this.checkingsbalance.Size = new System.Drawing.Size(235, 62);
            this.checkingsbalance.TabIndex = 3;
            this.checkingsbalance.Text = "Checking Account Balance: $0";
            this.checkingsbalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L1
            // 
            this.L1.BackColor = System.Drawing.Color.IndianRed;
            this.L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.FormattingEnabled = true;
            this.L1.ItemHeight = 20;
            this.L1.Items.AddRange(new object[] {
            "Latest 5 transactions:",
            ""});
            this.L1.Location = new System.Drawing.Point(12, 124);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(239, 324);
            this.L1.TabIndex = 4;
            // 
            // L2
            // 
            this.L2.BackColor = System.Drawing.Color.IndianRed;
            this.L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2.FormattingEnabled = true;
            this.L2.ItemHeight = 20;
            this.L2.Items.AddRange(new object[] {
            "Latest 5 transactions:",
            ""});
            this.L2.Location = new System.Drawing.Point(257, 123);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(235, 324);
            this.L2.TabIndex = 5;
            // 
            // L3
            // 
            this.L3.BackColor = System.Drawing.Color.IndianRed;
            this.L3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L3.FormattingEnabled = true;
            this.L3.ItemHeight = 20;
            this.L3.Items.AddRange(new object[] {
            "Latest 5 transactions:",
            ""});
            this.L3.Location = new System.Drawing.Point(498, 123);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(248, 324);
            this.L3.TabIndex = 6;
            this.L3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 36);
            this.button1.TabIndex = 32;
            this.button1.Text = "Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(36, 157);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(193, 280);
            this.plotView1.TabIndex = 33;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotView2
            // 
            this.plotView2.Location = new System.Drawing.Point(273, 157);
            this.plotView2.Name = "plotView2";
            this.plotView2.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView2.Size = new System.Drawing.Size(204, 280);
            this.plotView2.TabIndex = 34;
            this.plotView2.Text = "plotView2";
            this.plotView2.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView2.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView2.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotView3
            // 
            this.plotView3.Location = new System.Drawing.Point(519, 157);
            this.plotView3.Name = "plotView3";
            this.plotView3.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView3.Size = new System.Drawing.Size(207, 280);
            this.plotView3.TabIndex = 35;
            this.plotView3.Text = "plotView3";
            this.plotView3.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView3.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView3.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(749, 476);
            this.Controls.Add(this.plotView3);
            this.Controls.Add(this.plotView2);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.checkingsbalance);
            this.Controls.Add(this.investmentsbalance);
            this.Controls.Add(this.savingsbalance);
            this.Name = "Form3";
            this.Text = "Form3";
            this.VisibleChanged += new System.EventHandler(this.Form3_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label savingsbalance;
        private System.Windows.Forms.Label investmentsbalance;
        private System.Windows.Forms.Label checkingsbalance;
        private System.Windows.Forms.ListBox L1;
        private System.Windows.Forms.ListBox L2;
        private System.Windows.Forms.ListBox L3;
        private System.Windows.Forms.Button button1;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private OxyPlot.WindowsForms.PlotView plotView3;
    }
}