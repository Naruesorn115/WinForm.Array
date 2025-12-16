using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForm.Array
{
    public partial class Jagged_Array : Form
    {
        public Jagged_Array()
        {
            InitializeComponent();
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();

            // แยกแต่ละบรรทัด (แต่ละ array ย่อย)
            string[] lines = txtInput.Text
                .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            int[][] MyArr = new int[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                // แยกตัวเลขด้วย ,
                string[] nums = lines[i].Split(',');

                MyArr[i] = new int[nums.Length];

                for (int j = 0; j < nums.Length; j++)
                {
                    MyArr[i][j] = int.Parse(nums[j]);
                }
            }

            // แสดงผล + คำนวณผลรวม
            for (int i = 0; i < MyArr.Length; i++)
            {
                int sum = 0;

                foreach (int n in MyArr[i])
                {
                    txtOutput.AppendText(n + " ");
                    sum += n;
                }

                txtOutput.AppendText(Environment.NewLine);
                txtOutput.AppendText("Sum = " + sum + Environment.NewLine);
                txtOutput.AppendText("--end--" + Environment.NewLine);
            }
        }
    }
}
