namespace insertion_sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] stringArr = textBox1.Text.Split(' ');
            int[] intArray = new int[stringArr.Length];
            for (int i = 0; i < stringArr.Length; i++)
            {
                intArray[i] = int.Parse(stringArr[i]);
            }
            progressBar1.Maximum = intArray.Length;
            progressBar1.Value = 0;
            for (int i = 1; i < intArray.Length; i++)
            {
                int j = i - 1;
                int temp = intArray[i];
                while (j >= 0 && intArray[j] > temp)
                {
                    intArray[j + 1] = intArray[j];
                    j--;
                }
                intArray[j + 1] = temp;
                progressBar1.Value = i+1;
            }
            string outputString = string.Join(" ", intArray);
            textBox2.Text = outputString;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}