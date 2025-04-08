namespace Practical_Guide_02_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string inputLetter = txtLetter.Text.Trim().ToLower();

            if(inputLetter.Length == 1)
            {
                switch (inputLetter)
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        MessageBox.Show("The letter is a vowel.");
                        break;
                    default:
                        MessageBox.Show("The letter is not a vowel.");
                        break;

                }
            }
            else
            {
                MessageBox.Show("Please enter a single letter.");
            }
        }
    }
}
