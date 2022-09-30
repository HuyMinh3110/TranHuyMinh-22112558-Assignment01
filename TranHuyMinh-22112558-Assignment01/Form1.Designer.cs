namespace TranHuyMinh_22112558_Assignment01
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
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_red = new System.Windows.Forms.Panel();
            this.pnl_yellow = new System.Windows.Forms.Panel();
            this.pnl_green = new System.Windows.Forms.Panel();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.Black;
            this.pnl_top.Controls.Add(this.pnl_green);
            this.pnl_top.Controls.Add(this.pnl_yellow);
            this.pnl_top.Controls.Add(this.pnl_red);
            this.pnl_top.Location = new System.Drawing.Point(13, 13);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(239, 482);
            this.pnl_top.TabIndex = 0;
            // 
            // pnl_red
            // 
            this.pnl_red.BackColor = System.Drawing.Color.Red;
            this.pnl_red.Location = new System.Drawing.Point(42, 145);
            this.pnl_red.Name = "pnl_red";
            this.pnl_red.Size = new System.Drawing.Size(154, 84);
            this.pnl_red.TabIndex = 0;
            // 
            // pnl_yellow
            // 
            this.pnl_yellow.BackColor = System.Drawing.Color.Yellow;
            this.pnl_yellow.Location = new System.Drawing.Point(42, 253);
            this.pnl_yellow.Name = "pnl_yellow";
            this.pnl_yellow.Size = new System.Drawing.Size(154, 84);
            this.pnl_yellow.TabIndex = 1;
            // 
            // pnl_green
            // 
            this.pnl_green.BackColor = System.Drawing.Color.Lime;
            this.pnl_green.Location = new System.Drawing.Point(42, 367);
            this.pnl_green.Name = "pnl_green";
            this.pnl_green.Size = new System.Drawing.Size(154, 84);
            this.pnl_green.TabIndex = 2;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(414, 278);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(83, 54);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(526, 278);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(83, 54);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(639, 278);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(85, 54);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 507);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.pnl_top);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_green;
        private System.Windows.Forms.Panel pnl_yellow;
        private System.Windows.Forms.Panel pnl_red;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_reset;
    }
}

