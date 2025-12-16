namespace WinForm.Array
{
    partial class Jagged_Array
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
            btnRun = new Button();
            txtOutput = new TextBox();
            txtInput = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.BackColor = Color.FromArgb(128, 255, 255);
            btnRun.Location = new Point(60, 328);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(94, 29);
            btnRun.TabIndex = 0;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = Color.FromArgb(255, 224, 192);
            txtOutput.Location = new Point(23, 59);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(271, 267);
            txtOutput.TabIndex = 1;
            txtOutput.TextChanged += txtOutput_TextChanged;
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.FromArgb(255, 224, 192);
            txtInput.Location = new Point(23, 42);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.Size = new Size(195, 280);
            txtInput.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 255, 128);
            groupBox1.Controls.Add(txtInput);
            groupBox1.Controls.Add(btnRun);
            groupBox1.Location = new Point(125, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 368);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "กรอกจำนวนตัวเลข";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 255, 128);
            groupBox2.Controls.Add(txtOutput);
            groupBox2.Location = new Point(468, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(309, 357);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "ผลรวม";
            // 
            // Jagged_Array
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Jagged_Array";
            Text = "Jagged_Array";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRun;
        private TextBox txtOutput;
        private TextBox txtInput;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}