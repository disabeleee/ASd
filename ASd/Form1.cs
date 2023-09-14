namespace ASd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

            //Clear piture
            pictureBox1.Image = null;



        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {

            //Show the color dialog box. If the users click "OK", change the "PircureBox" control's background to the color user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }



        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {  
                // If the user selects the Stretch check box, 
                // change the PictureBox's
                // SizeMode property to "Stretch". If the user clears 
                // the check box, change it to "Normal".
                if (checkBox1.Checked)
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                else
                    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }
    }
}