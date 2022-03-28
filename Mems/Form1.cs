using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mems
{
    public partial class Mems : Form
    {
        Random rnd = new Random();
        int border; 
        // Граница между уже показанными и еще не показанными картинками.
        // Эта граница будет сдвигаться ближе к началу List'а айдишников по мере использования той или иной картинки.
        
        List<int> usingImages = new List<int> { }; 
        // List айдишников картинок


        public Mems()
        {
            InitializeComponent();

            Init(); // Метод на заполнение начальных полей и запуск других ключевых методов
        }

        
        
        private void Init()
        {
            MessageBox.Show($"На данный момент в программе представлены картинки в количестве: {imagesAmount}");

            for (int i = 0; i < imagesAmount; i ++) 
            // У каждого файла картинки имя в формате "{Число}.jpg"
            {
                usingImages.Add(i + 1); 
            }
            // Заполнили List числами от 1 и до кол-ва картинок
            // Получившийся List - Список айдишников наших картинок, через которые мы будем к ним обращаться
            border = imagesAmount - 1; // Индекс последнего элемента
            StartShowing(); // Показываем первую пару
        }

        int imagesAmount = 7; //Текущее кол-во картинок в папке

        private void switchNumbers(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        private void StartShowing() //Здесь мы покажем пользователю самую первую пару картинок 
        {
            Bitmap image1, image2;
            pictureLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureRight.SizeMode = PictureBoxSizeMode.StretchImage;

            int picNum1, picNum2, ind1, ind2, temp;

            ind1 = rnd.Next(0, border); // Выбрали индекс айдишника в List'е
            picNum1 = usingImages[ind1];

            temp = usingImages[ind1];
            usingImages[ind1] = usingImages[border];
            usingImages[border] = temp;

            border -= 1;

            ind2 = rnd.Next(0, border);
            picNum2 = usingImages[ind2];

            temp = usingImages[ind2];
            usingImages[ind2] = usingImages[border];
            usingImages[border] = temp;

            border -= 1;

            image1 = new Bitmap($"{picNum1}.jpg"); image2 = new Bitmap($"{picNum2}.jpg");
            pictureLeft.Image = (Image)image1; pictureRight.Image = (Image)image2;
        }

        private void ChangeImage(int leftRight)
        {
            Bitmap image;
            int temp;
            int imageInd = rnd.Next(0, border);
            int imageID = usingImages[imageInd];
            image =  new Bitmap($"{imageID}.jpg");

            if (leftRight == 0)
            {
                pictureLeft.Image = (Image)image;
            }
            else
            {
                pictureRight.Image = (Image)image;
            }

            temp = usingImages[imageInd];
            usingImages[imageInd] = usingImages[border];
            usingImages[border] = temp;

            border -= 1;
            // Переместили выбранную картинку за "границу", чтобы она нам не попадалась и передвинули границу на один влево
        }
        
        private void opinion_Click(object sender, EventArgs e)
        {
            Opin Opin = new Opin();
            Opin.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SocOpinion_Click(object sender, EventArgs e)
        {
            SocRating soc = new SocRating();
            soc.ShowDialog();
        }

        private void picLeftClick(object sender, EventArgs e)
        {
            if (border >= 1)
            {
                ChangeImage(1);
            }
            else if (border == 0)
            {
                pictureLeft.Image = (Image)new Bitmap($"{usingImages[0]}.jpg");
                MessageBox.Show("Картинки закончились");
                ShowResults();
            }            
            
        }

        private void picRightClick(object sender, EventArgs e)
        {
            if (border >= 1)
            {
                ChangeImage(0);
            }
            else if (border == 0)
            {
                pictureLeft.Image = (Image)new Bitmap($"{usingImages[0]}.jpg");
                MessageBox.Show("Картинки закончились");
                ShowResults();
            }           
        }

        private void ShowResults()
        {
            Opin Opin = new Opin();
            Opin.ShowDialog();
        }
    }
}
