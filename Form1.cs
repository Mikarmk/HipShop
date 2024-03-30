using System.Media;

namespace hip_shop
{
    public partial class Form1 : Form
    {
        int num = 52;
        SoundPlayer simple = new SoundPlayer(/*openFileDialog.FileName */ @"C:\Users\amirk\source\repos\hip shop\hip shop\Resources\hipmp.wav");

        public Form1() 
        {
            InitializeComponent();
            // OpenFileDialog openFileDialog = new OpenFileDialog();
            // openFileDialog.ShowDialog();
            simple.PlayLooping();

            panel1.Visible = true;
            panel1.Enabled = true;

            pictureBox3.Visible = true;
            pictureBox3.Enabled = true;

            pictureBox2.Visible = true;
            pictureBox2.Enabled = true;

            panel2.Enabled = false;
            panel2.Visible = false;

            panel3.Enabled = false;
            panel3.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // button1.Visible = false;
            //  button1.Enabled = false;
            //  button2.Visible = false;
            //   button2.Enabled = false;
            //   button3.Visible = false;
            //  button3.Enabled = false;
            //   button4.Visible = false;
            //  button4.Enabled = false;

            panel2.Enabled = true;
            panel2.Visible = true;

            panel3.Enabled = true;
            panel3.Visible = true;

            panel1.Visible = false;
            panel1.Enabled = false;

            panel4.Visible = false;
            panel4.Enabled = false;

            pictureBox3.Visible = false;
            pictureBox3.Enabled = false;

            pictureBox2.Visible = false;
            pictureBox2.Enabled = false;

        }

        private void button1_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.КупитьС;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.Купить;

        }


        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.ПродатьС;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.Продать;

        }


        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackgroundImage = Properties.Resources.ГоворитьС;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = Properties.Resources.Говорить;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackgroundImage = Properties.Resources.ВыходС;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = Properties.Resources.Выход;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.ПродатьТ;
            //  Thread thread = new Thread(new ThreadStart(Delay));
            // thread.Start();
            //  pictureBox3.Image = Properties.Resources.Добро_пожаловать;
        }

        private void Delay()
        {

            Thread.Sleep(3);
            //pictureBox1.Visible = true;
        }

        private async void button4_ClickAsync(object sender, EventArgs e)
        {
            await Task.Run(() => pictureBox3.Image = Properties.Resources.Пока);

            Thread.Sleep(3000);

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.Ахъ__каков_вашъ_интересъ;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.Что_соизволите_купить_;
            if (num > 50)
            {
                pictureBox4.Image = Properties.Resources._2;
                //SoundPlayer simple1 = new SoundPlayer(/*openFileDialog.FileName */ @"C:\Users\amirk\source\repos\hip shop\hip shop\Resources\google-pay-success-sound-effect.wav");
                //simple1.PlayLooping();
                // simple.Stop();
                // simple.SoundLocation = @"C:\Users\amirk\source\repos\hip shop\hip shop\Resources\google-pay-success-sound-effect.wav";
                // simple.Play();
                //   Thread.Sleep(3000);
                num -= 50;

                //  simple.SoundLocation = @"C:\Users\amirk\source\repos\hip shop\hip shop\Resources\hipmp.wav";
                //  simple.PlayLooping();

            }
            else
            {
                pictureBox5.Image = Properties.Resources.Ваших_средств_не_хватает;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackgroundImage = Properties.Resources.купить1;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackgroundImage = Properties.Resources.купить1_1;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.Ваших_средств_не_хватает;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.Ваших_средств_не_хватает;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.Ваших_средств_не_хватает;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackgroundImage = Properties.Resources.Купить2;

        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackgroundImage = Properties.Resources.Купить2_1;

        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackgroundImage = Properties.Resources.Купить3;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackgroundImage = Properties.Resources.Купить3_1;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackgroundImage = Properties.Resources.Купить4;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackgroundImage = Properties.Resources.Купить4_1;
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BackgroundImage = Properties.Resources.Уйти;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackgroundImage = Properties.Resources.Уйти_1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Enabled = true;

            pictureBox3.Visible = true;
            pictureBox3.Enabled = true;

            panel4.Visible = true;
            panel4.Enabled = true;

            pictureBox2.Visible = true;
            pictureBox2.Enabled = true;

            panel2.Enabled = false;
            panel2.Visible = false;

            panel3.Enabled = false;
            panel3.Visible = false;

            if (num > 50)
            {
                pictureBox2.Image = Properties.Resources._52;
            } else
            {
                pictureBox2.Image = Properties.Resources._2;
            }
           




        }
    }
}
