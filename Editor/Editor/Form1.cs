using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Confirm_Click(object sender, EventArgs e)
        {
            //Set directory to the name of the folder that holds the story
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            System.IO.Directory.CreateDirectory(desktopPath + "\\Story");
            
            string path = @"C:\\Users\\Harsimran Singh\\Desktop\\Story\\"+textBox4.Text+".txt";
            using (StreamWriter writer = File.CreateText(path))
            {
                //Read all the data entered in the editor and write it to the textfile
                writer.Write(textBox1.Text + Environment.NewLine);
                writer.Write(textBox4.Text + Environment.NewLine);
                writer.Write(textBox2.Text + Environment.NewLine);
                writer.Write(DecisionOne.Text + Environment.NewLine);
                
                //Check to see whether there are values for the decisions. If there are, then write it to the text-file
                if(!string.IsNullOrEmpty(DecisionOne.Text))
                {
                    writer.Write(OneToNode.Text + Environment.NewLine);
                }
                else
                {
                    writer.Write(Environment.NewLine);
                }
                writer.Write(DecisionTwo.Text + Environment.NewLine);
                if (!string.IsNullOrEmpty(DecisionTwo.Text))
                {
                    writer.Write(TwoToNode.Text + Environment.NewLine);
                }
                else
                {
                    writer.Write(Environment.NewLine);
                }
                writer.Write(DecisionThree.Text + Environment.NewLine);
                if (!string.IsNullOrEmpty(DecisionThree.Text))
                {
                    writer.Write(ThreeToNode.Text + Environment.NewLine);
                }
                else
                {
                    writer.Write(Environment.NewLine);
                }
                writer.Write(DecisionFour.Text + Environment.NewLine);
                if(!string.IsNullOrEmpty(DecisionFour.Text))
                {
                    writer.Write(FourToNode.Text + Environment.NewLine);
                }
                else
                {
                    writer.Write(Environment.NewLine);
                }

                //Check to see which decision is chosen as "correct" and write its value (which screen it goes to) to the file
                if (radioButton1.Checked) 
                {
                    writer.Write(OneToNode.Text + Environment.NewLine);
                }
                else if (radioButton2.Checked)
                {
                    writer.Write(TwoToNode.Text + Environment.NewLine);
                }
                else if (radioButton3.Checked)
                {
                    writer.Write(ThreeToNode.Text + Environment.NewLine);
                }
                else if (radioButton4.Checked)
                {
                    writer.Write(FourToNode.Text + Environment.NewLine);
                }
                else
                {
                    writer.Write(Environment.NewLine);
                }
                writer.Write(Image.Text + Environment.NewLine);

                //Set all of the UI elements to null
                textBox1.Text = String.Empty;
                textBox4.Text = String.Empty;
                textBox2.Text = String.Empty;
                DecisionOne.Text = String.Empty;
                OneToNode.Text = String.Empty;
                DecisionTwo.Text = String.Empty;
                TwoToNode.Text = String.Empty;
                DecisionThree.Text = String.Empty;
                ThreeToNode.Text = String.Empty;
                DecisionFour.Text = String.Empty;
                FourToNode.Text = String.Empty;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                Image.Text = String.Empty;

                this.Refresh();
                writer.Close();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void DecisionOne_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CorrectToNode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Image_TextChanged(object sender, EventArgs e)
        {

        }
        private void openFileDialog1_FileOk(object sender, EventArgs e)
        {

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void label14_Click_1(object sender, EventArgs e)
        {

        }
        private void label17_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void button1_Click(object sender, System.EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            System.IO.Directory.CreateDirectory(desktopPath + "\\Story");

            string path = @"C:\\Users\\Harsimran Singh\\Desktop\\Story\\" + textBox4.Text + ".txt";
            using (StreamWriter writer = File.CreateText(path))
            {
                writer.Write(textBox1.Text + Environment.NewLine);
                writer.Write(textBox4.Text + ".txt" + Environment.NewLine);
                writer.Write(textBox2.Text + Environment.NewLine);
                writer.Write(DecisionOne.Text + Environment.NewLine);

                if (!string.IsNullOrEmpty(DecisionOne.Text))
                {
                    writer.Write(OneToNode.Text + ".txt" + Environment.NewLine);
                }
                else
                {
                    writer.Write(Environment.NewLine);
                }
                writer.Write(DecisionTwo.Text + Environment.NewLine);
                if (!string.IsNullOrEmpty(DecisionTwo.Text))
                {
                    writer.Write(TwoToNode.Text + ".txt" + Environment.NewLine);
                }
                else
                {
                    writer.Write(Environment.NewLine);
                }
                writer.Write(DecisionThree.Text + Environment.NewLine);
                if (!string.IsNullOrEmpty(DecisionThree.Text))
                {
                    writer.Write(ThreeToNode.Text + ".txt" + Environment.NewLine);
                }
                else
                {
                    writer.Write(Environment.NewLine);
                }
                writer.Write(DecisionFour.Text + Environment.NewLine);
                if (!string.IsNullOrEmpty(DecisionFour.Text))
                {
                    writer.Write(FourToNode.Text + ".txt" + Environment.NewLine);
                }
                else
                {
                    writer.Write(Environment.NewLine);
                }
                if (radioButton1.Checked)
                {
                    writer.Write(OneToNode.Text + ".txt" + Environment.NewLine);
                }
                else if (radioButton2.Checked)
                {
                    writer.Write(TwoToNode.Text + ".txt" + Environment.NewLine);
                }
                else if (radioButton3.Checked)
                {
                    writer.Write(ThreeToNode.Text + ".txt" + Environment.NewLine);
                }
                else if (radioButton4.Checked)
                {
                    writer.Write(FourToNode.Text + ".txt" + Environment.NewLine);
                }
                else
                {
                    writer.Write(Environment.NewLine);
                }
                writer.Write(Image.Text + Environment.NewLine);

                textBox1.Text = String.Empty;
                textBox4.Text = String.Empty;
                textBox2.Text = String.Empty;
                DecisionOne.Text = String.Empty;
                OneToNode.Text = String.Empty;
                DecisionTwo.Text = String.Empty;
                TwoToNode.Text = String.Empty;
                DecisionThree.Text = String.Empty;
                ThreeToNode.Text = String.Empty;
                DecisionFour.Text = String.Empty;
                FourToNode.Text = String.Empty;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                Image.Text = String.Empty;

                this.Refresh();
                writer.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Creating the file dialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }

            //Reading everything from selected file and displaying it to UI on editor
            using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
            {
                string title = reader.ReadLine();
                string nodenumber = reader.ReadLine();
                string description = reader.ReadLine();
                string decone = reader.ReadLine();
                string onetonode = reader.ReadLine();
                string dectwo = reader.ReadLine();
                string twotonode = reader.ReadLine();
                string decthree = reader.ReadLine();
                string threetonode = reader.ReadLine();
                string decfour = reader.ReadLine();
                string fourtonode = reader.ReadLine();
                string answer = reader.ReadLine();
                string imagelink = reader.ReadLine();

                textBox1.Text = title;
                textBox4.Text = nodenumber;
                textBox2.Text = description;
                DecisionOne.Text = decone;
                OneToNode.Text = onetonode;
                DecisionTwo.Text = dectwo;
                TwoToNode.Text = twotonode;
                DecisionThree.Text = decthree;
                ThreeToNode.Text = threetonode;
                DecisionFour.Text = decfour;
                FourToNode.Text = fourtonode;

                if (answer == onetonode)
                {
                    radioButton1.Checked = true;
                }
                if (answer == twotonode)
                {
                    radioButton2.Checked = true;
                }
                if (answer == threetonode)
                {
                    radioButton3.Checked = true;
                }
                if (answer == fourtonode)
                {
                    radioButton4.Checked = true;
                }

                Image.Text = imagelink;
                reader.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Images",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "jpeg",
                /*Filter = "jpeg files (*.jpeg)|*.jpeg",*/
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image.Text = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
            }
        }
    }
}
    
    






