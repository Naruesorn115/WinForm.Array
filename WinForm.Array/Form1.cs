using System.Globalization;

namespace WinForm.Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] data = texb.Lines;
            int[] numbers = new int[data.Length];
            for (int i = 0; i < data.Length; i++)

                if (int.TryParse(data[i], out int number))
                {
                    numbers[i] = number;
                }
                else
                {
                    numbers[i] = int.Parse(data[i]);
                }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double average = (double)sum / numbers.Length;

            lCount.Text = "จำนวนสมาชิกข้อมูล :" + numbers.Length;
            lSum.Text = "ผลรวม :" + sum;
            lAvg.Text = "ค่าเฉลี่ย :" + average.ToString("F2", CultureInfo.InvariantCulture);
        }

        private void lMin_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void texb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[,] data = new string[5,3]
             {
                    { "ธันวา", "ท็อป", "หนองคาย" },
                    { "ณัฐภูมิ", "น็อต", "หนองคาย" },
                    { "วัชชิระ", "สนิก", "อุดรธานี" },
                    { "ภูริณัฐ", "ทีนนี่", "อุดรธานี" },
                    { "อินทิรา", "เอ็มมี่", "หนองคาย" }
             };
            int row = data.GetLength(0);
            string result = "";
            for (int i = 0; i < row; i++)
            {
                result += "ข้อมูลที่ " + (i + 1) + " : ";
                result += "ชื่อจริง : " + data[i, 0] + ", ";
                result += "ชื่อเล่น : " + data[i, 1] + ", ";
                result += "จังหวัด : " + data[i, 2] + "\n";

            }   
            MessageBox.Show(result, "ข้อมูลใน Array 2มิติ");

        }
    }
}
