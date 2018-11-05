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

namespace Motor_Imagery_Protocol
{
    public partial class FormMI : System.Windows.Forms.Form
    {
        // Ajustar a posicição de panels, labels, button...
        int x; int y;

        // Variavel para embaralhar as classes
        Random randonNum = new Random();

        // Classes que serão embaralhadas
        List<int> TwoMoviments = new List<int>() { 1, 2};

        //Dicionário para colocar as listas com a ordem de imagens e seu indice de 0 a 39
        Dictionary<int, List<int>> data = new Dictionary<int, List<int>>();

        // Lista de imagens dos movimentos que devem ser executados
        List<Bitmap> imageList = new List<Bitmap>();

        System.Media.SoundPlayer player;

        string currentPath = Environment.CurrentDirectory;

        //Carregando todas as imagens usadas
        Bitmap img1; Bitmap img2; Bitmap img3;

        bool iRest = true; bool iImg = true;
        //Contagem da quantidade do numero de movimentos, total e parcial.
        int countT = 0; int countP = 0;
        // incrementam a lista de imagens e a imagem dentro da lista
        int countTwo = 0; int countOne = 0;
        
        public FormMI()
        {
            InitializeComponent();
        }

        private void FormMI_Load(object sender, EventArgs e)
        {            
            pnOne.Dock = DockStyle.Fill;
            pnTwo.Dock = DockStyle.Fill;
            pnTwo.Visible = false;

            x = (pnOne.Size.Width - BtAvancar.Width) / 2;
            y = (pnOne.Size.Height)*100 / 120 ;
            BtAvancar.Location = new Point(x, y);

            lbStartMessage1.Text = "Protocolo de Coleta";
            x = (pnOne.Size.Width - lbStartMessage1.Width) / 2;
            y = (pnOne.Size.Height - lbStartMessage1.Height - 50) / 2;
            lbStartMessage1.Location = new Point(x, y);

            lbStartMessage2.Text = "Imagética Motora";
            x = (pnOne.Size.Width - lbStartMessage2.Width) / 2;
            y = (pnOne.Size.Height - lbStartMessage2.Height + 50) / 2;
            lbStartMessage2.Location = new Point(x, y);

        }

        private void BtInicio_Click(object sender, EventArgs e)
        {
            pnOne.Visible = false;
            pnTwo.Visible = true;
            BtColeta.Enabled = false;

            x = (pnTwo.Size.Width - pbCross.Width) / 2;
            y = (pnTwo.Size.Height - pbCross.Height) / 2;
            pbCross.Location = new Point(x, y);

            x = (pnTwo.Size.Width - pbMain.Width) / 2;
            y = (pnTwo.Size.Height - pbMain.Height) / 2;
            pbMain.Location = new Point(x, y);

            x = Convert.ToInt16(pnTwo.Size.Width*0.05);
            y = (pnTwo.Size.Height - 200);
            pnTrigger.Location = new Point(x, y);


        }

        private void ImageShow()
        {
            player = new System.Media.SoundPlayer(soundLocation: currentPath + @"\img\beep.wav");
            img1 = new Bitmap(currentPath + @"\img\SetaE.jpg");
            img2 = new Bitmap(currentPath + @"\img\SetaD.jpg");
            img3 = new Bitmap(currentPath + @"\img\+.jpg");
            imageList.Add(img1);
            imageList.Add(img2);
            imageList.Add(img3);

            for (int i = 0; i < 10; i++)
            {
                data.Add(i, TwoMoviments.OrderBy(s => randonNum.Next()).Take(2).ToList());
            }
        }

        private void BtColeta_Click(object sender, EventArgs e)
        {
            if (BtColeta.Text == "Iniciar Coleta")
            {
                BtColeta.Text = "Parar Coleta";
                TimerOne.Start();
            }
            else if (BtColeta.Text == "Parar Coleta")
            {
                BtColeta.Text = "Iniciar Coleta";
                TimerOne.Stop();
                countTwo = 0;
                countOne = 0;
                countT = 0;
                countP = 0;
                lbCountT.Text = "0";
                pbMain.Image = null;
                pnTrigger.Visible = false;
                BtColeta.Enabled = false;
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                ImageShow();
                DataSave();
                BtColeta.Enabled = true;
            }
        }


        private void TimerOne_Tick(object sender, EventArgs e)
        {
            if (iRest == true)
            {
                TimerOne.Interval = 3000;
                pbMain.Image = null;
                iRest = false;
                pnTrigger.BackColor = Color.White;
                switch (countTwo)
                {
                    case 10:
                        countTwo = 0;
                        lbCountT.Text = "0";
                        pbMain.Image = null;
                        pnTrigger.Visible = false;
                        for (int i = data.Count; i >= 0; i--)
                        {
                            data.Remove(i);
                        }
                        BtColeta.Text = "Iniciar Coleta";
                        BtColeta.Enabled = false;
                        TimerOne.Stop();
                        break;
                }
            }
            else
            {
                if (iImg == true)
                {
                    TimerOne.Interval = 1000;
                    pbCross.Image = imageList[2];
                    pbCross.Visible = true;
                    pbMain.Visible = false;
                    player.Play();
                    iImg = false;
                }
                else
                {
                    TimerOne.Interval = 4000;
                    pbMain.Visible = true;
                    pbCross.Visible = false;
                    pnTrigger.BackColor = Color.Black;
                    pbMain.Image = imageList[data[countTwo][countOne++] - 1];

                    countP++;
                    iRest = true;
                    iImg = true;
                }
                switch (countOne)
                {
                    case 2:
                        countT++;
                        lbCountT.Text = countT.ToString();
                        countOne = 0;
                        countTwo++;
                        break;
                }
            }
        }



        private void DataSave()
        {
            var File = currentPath + @"\Respostas\" + tbName.Text + "-Resposta.txt";            
            using (var write = new StreamWriter(File))
                foreach (KeyValuePair<int, List<int>> N in data)
                {
                    write.Write("[{0}]\r\n", N.Key);
                    foreach (var item in N.Value)
                    {
                        write.Write("{0}\r\n", item);
                    }
                }
        }
    }
}
