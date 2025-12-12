namespace WinForm.Array
{
    partial class Form1
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
            texb = new TextBox();
            label1 = new Label();
            button1 = new Button();
            lCount = new Label();
            lSum = new Label();
            lAvg = new Label();
            lMax = new Label();
            lMin = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // texb
            // 
            texb.Location = new Point(132, 95);
            texb.Multiline = true;
            texb.Name = "texb";
            texb.Size = new Size(252, 362);
            texb.TabIndex = 0;
            texb.TextChanged += texb_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(132, 34);
            label1.Name = "label1";
            label1.Size = new Size(252, 46);
            label1.TabIndex = 1;
            label1.Text = "กรอกข้อมูลตัวเลข";
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.ForeColor = Color.FromArgb(0, 0, 192);
            button1.Location = new Point(403, 80);
            button1.Name = "button1";
            button1.Size = new Size(133, 56);
            button1.TabIndex = 2;
            button1.Text = "ประมวลผล";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lCount
            // 
            lCount.AutoSize = true;
            lCount.BackColor = Color.Lime;
            lCount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lCount.Location = new Point(630, 110);
            lCount.Name = "lCount";
            lCount.Size = new Size(171, 41);
            lCount.TabIndex = 3;
            lCount.Text = "จำนวนข้อมูล:";
            // 
            // lSum
            // 
            lSum.AutoSize = true;
            lSum.BackColor = Color.Lime;
            lSum.Font = new Font("Segoe UI", 18F);
            lSum.Location = new Point(630, 172);
            lSum.Name = "lSum";
            lSum.Size = new Size(115, 41);
            lSum.TabIndex = 4;
            lSum.Text = "ค่าเฉลี่ย:";
            // 
            // lAvg
            // 
            lAvg.AutoSize = true;
            lAvg.BackColor = Color.Lime;
            lAvg.Font = new Font("Segoe UI", 18F);
            lAvg.Location = new Point(630, 245);
            lAvg.Name = "lAvg";
            lAvg.Size = new Size(103, 41);
            lAvg.TabIndex = 5;
            lAvg.Text = "ผลรวม:";
            // 
            // lMax
            // 
            lMax.AutoSize = true;
            lMax.BackColor = Color.Lime;
            lMax.Font = new Font("Segoe UI", 18F);
            lMax.Location = new Point(630, 317);
            lMax.Name = "lMax";
            lMax.Size = new Size(117, 41);
            lMax.TabIndex = 6;
            lMax.Text = "ค่าสูงสุด:";
            // 
            // lMin
            // 
            lMin.AutoSize = true;
            lMin.BackColor = Color.Lime;
            lMin.Font = new Font("Segoe UI", 18F);
            lMin.Location = new Point(630, 406);
            lMin.Name = "lMin";
            lMin.Size = new Size(120, 41);
            lMin.TabIndex = 7;
            lMin.Text = "ค่าต่ำสุด:";
            lMin.Click += lMin_Click;
            // 
            // button2
            // 
            button2.Location = new Point(403, 461);
            button2.Name = "button2";
            button2.Size = new Size(136, 41);
            button2.TabIndex = 8;
            button2.Text = "ทดสอบ Array 2 มิติ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1017, 737);
            Controls.Add(button2);
            Controls.Add(lMin);
            Controls.Add(lMax);
            Controls.Add(lAvg);
            Controls.Add(lSum);
            Controls.Add(lCount);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(texb);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox texb;
        private Label label1;
        private Button button1;
        private Label lCount;
        private Label lSum;
        private Label lAvg;
        private Label lMax;
        private Label lMin;
        private Button button2;
    }
}
