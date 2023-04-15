namespace Tema_4
{
    public partial class Form1 : Form
    {
        private int marime;

        public Form1()
        {
            marime = 0; //0 = Greutate , 1=Temperatura , 2=Lungime;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nr=0;

            switch (marime)
            {
                case 0: //greutate
                    {
                        switch (comboBox1.SelectedIndex) // convertim in kg
                        {
                            case 0:
                                nr = double.Parse(textBox1.Text);
                                break;
                            case 1:
                                nr = double.Parse(textBox1.Text);
                                nr = nr / 1000;
                                break;
                            case 2:
                                nr = double.Parse(textBox1.Text);
                                nr = nr * 0.02835;
                                break;
                            case 3:
                                nr = double.Parse(textBox1.Text);
                                nr = nr* 0.45359237;
                                break;
                        }
                        switch (comboBox2.SelectedIndex) //convertim din kg in marimea ceruta
                        {
                            case 0:
                                label1.Text=nr.ToString();
                                break;
                            case 1:label1.Text=(nr*1000).ToString("F3");
                                break;
                            case 2:label1.Text=(nr/ 0.02835).ToString("F3");
                                break;
                            case 3:label1.Text = (nr / 0.45359237).ToString("F3");
                                break;
                        }
                    }
                    break;
                case 1:
                    {
                        switch (comboBox1.SelectedIndex) //convertim in Celsius
                        {
                            case 0:
                                nr = double.Parse(textBox1.Text);
                                break;
                            case 1:
                                nr = double.Parse(textBox1.Text);
                                nr = (nr-32)*0.5556;
                                break;
                            case 2:
                                nr = double.Parse(textBox1.Text);
                                nr = nr - 273.15;
                                break;
                        }
                        switch (comboBox2.SelectedIndex) //convertim din Celsius in marimea dorita
                        {
                            case 0:
                                label1.Text = nr.ToString("F3");
                                break;
                            case 1:
                                label1.Text = (nr*1.8+32).ToString("F3");
                                break;
                            case 2:
                                label1.Text = (nr+273.15).ToString("F3");
                                break;
                        }
                    }

                    break;
                case 2:
                    {
                        switch (comboBox1.SelectedIndex) //convertim in Metri
                        {
                            case 0:
                                nr = double.Parse(textBox1.Text); //m
                                break;
                            case 1:
                                nr = double.Parse(textBox1.Text);
                                nr = nr* 0.0254; //inch
                                break;
                            case 2:
                                nr = double.Parse(textBox1.Text);
                                nr = nr* 0.304;  //feet
                                break;
                            case 3:
                                nr = double.Parse(textBox1.Text);
                                nr = nr*1000;  //km
                                break;
                        }
                        switch (comboBox2.SelectedIndex) //convertim din Celsius in marimea dorita
                        {
                            case 0:
                                label1.Text = nr.ToString("F3"); //m
                                break;
                            case 1:
                                label1.Text = (nr * 39.36).ToString("F3");//inch
                                break;
                            case 2:
                                label1.Text = (nr + 3.28084).ToString("F3");//feet
                                break;
                            case 3:
                                label1.Text = (nr/1000).ToString("F3");//km
                                break;
                        }
                    }

                    break;
            }
            label1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            label1.Hide();
        }

        private void greutateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox1.Items.Add("Kilograme");
            comboBox1.Items.Add("Grame");
            comboBox1.Items.Add("Uncii");
            comboBox1.Items.Add("Livre");

            foreach (var item in comboBox1.Items)
            {
                comboBox2.Items.Add(item);
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            marime = 0;
            label1.Hide();
            textBox1.Clear();
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox1.Items.Add("Celsius");
            comboBox1.Items.Add("Fahrenheit");
            comboBox1.Items.Add("Kelvin");

            foreach (var item in comboBox1.Items)
            {
                comboBox2.Items.Add(item);
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            marime = 1;
            label1.Hide();
            textBox1.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox1.Items.Add("Metri");
            comboBox1.Items.Add("Inci");
            comboBox1.Items.Add("Feet");
            comboBox1.Items.Add("Kilometri");

            foreach (var item in comboBox1.Items)
            {
                comboBox2.Items.Add(item);
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            marime = 2;
            label1.Hide();
            textBox1.Clear();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}