using System;
using System.IO;
using System.Windows.Forms;

namespace Prac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath+"\\Memory"+"\\"+textBox1.Text+".txt" );
            sw.WriteLine(label1.Text + " " + textBox1.Text);
            sw.WriteLine(label2.Text + " " + textBox2.Text);
            sw.WriteLine(label4.Text + " " + textBox3.Text);
            sw.WriteLine(label3.Text + " " + comboBox1.Text);
            sw.Close();
            FileStream fs = new FileStream(Application.StartupPath + "\\Memory" + "\\" + textBox1.Text + ".bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(label1.Text + " " + textBox1.Text);
            bw.Write(label2.Text + " " + textBox2.Text);
            bw.Write(label4.Text + " " + textBox3.Text);
            bw.Write(label3.Text + " " + comboBox1.Text);
            bw.Close();

            StreamReader sr = new StreamReader (Application.StartupPath + "\\Memory" + "\\" + textBox1.Text + ".txt");
            ReadTxt.Text = sr.ReadToEnd(); 
            sr.Close();

            FileStream fs1 = new FileStream(Application.StartupPath + "\\Memory" + "\\" + textBox1.Text + ".bin", FileMode.Open);
            BinaryReader br = new BinaryReader(fs1);
            ReadBin.Text = br.ReadString() + "\n" + br.ReadString() + "\n"+ br.ReadString() + "\n" + br.ReadString();
            fs1.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
