namespace BingRewards
{
    partial class BingRewards
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
            btn_start = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_start
            // 
            btn_start.BackColor = SystemColors.GradientActiveCaption;
            btn_start.Location = new Point(148, 121);
            btn_start.Margin = new Padding(4, 5, 4, 5);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(204, 76);
            btn_start.TabIndex = 0;
            btn_start.Text = "Start Earning";
            btn_start.UseVisualStyleBackColor = false;
            btn_start.Click += btn_start_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(139, 39);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(246, 51);
            label3.TabIndex = 6;
            label3.Text = "Bing Rewards";
            // 
            // BingRewards
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 608);
            Controls.Add(label3);
            Controls.Add(btn_start);
            Name = "BingRewards";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_start;
        private Label label3;
    }
}