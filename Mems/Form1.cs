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
        List <LabelAndRating> calllabel = new List<LabelAndRating> { } ;

        int tempo, terra;

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

            LabelAndRating one = new LabelAndRating();
            one.id = 1;
            one.label = "Запомните, твари";
            one.count = 0;
            LabelAndRating two = new LabelAndRating();
            two.id = 2;
            two.label = "Студбатл ПМ или гроб в аренду";
            two.count = 0;
            LabelAndRating three = new LabelAndRating();
            three.id = 3;
            three.label = "Домик на стипу";
            three.count = 0;
            LabelAndRating four = new LabelAndRating();
            four.id = 4;
            four.label = "ПАКА";
            four.count = 0;
            LabelAndRating five = new LabelAndRating();
            five.id = 5;
            five.label = "Яндекс Никита";
            five.count = 0;
            LabelAndRating six = new LabelAndRating();
            six.id = 6;
            six.label = "Замазка";
            six.count = 0;
            LabelAndRating seven = new LabelAndRating();
            seven.id = 7;
            seven.label = "Зарядка на весь день";
            seven.count = 0;
            LabelAndRating eight = new LabelAndRating();
            eight.id = 8;
            eight.label = "Ж-жиза";
            eight.count = 0;
            LabelAndRating nine = new LabelAndRating();
            nine.id = 9;
            nine.label = "Б****";
            nine.count = 0;
            LabelAndRating ten = new LabelAndRating();
            ten.id = 10;
            ten.label = "Контрольная...";
            ten.count = 0;

            calllabel.Add(one);
            calllabel.Add(two);
            calllabel.Add(three);
            calllabel.Add(four);
            calllabel.Add(five);
            calllabel.Add(six);
            calllabel.Add(seven);
            calllabel.Add(eight);
            calllabel.Add(nine);
            calllabel.Add(ten);



            // Заполнили List числами от 1 и до кол-ва картинок
            // Получившийся List - Список айдишников наших картинок, через которые мы будем к ним обращаться
            border = imagesAmount - 1 ; // Индекс последнего элемента
            StartShowing(); // Показываем первую пару
        }

        int imagesAmount = 10; //Текущее кол-во картинок в папке

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

            ind1 = rnd.Next(0, border - 1); // Выбрали индекс айдишника в List'е
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
            terra = picNum1 - 1;
            tempo = picNum2 - 1;
            label1.Text = calllabel[picNum1-1].label;
            label2.Text = calllabel[picNum2-1].label;

            //int fool = new int($"Mrat{picNum1 }"); 
            //pictureLeft.Image = (Image)image1;

        }
        int helper;
        public void ChangeImage(int leftRight)
        {
            Bitmap image;
            int temp;
            
            int imageInd = rnd.Next(0, border);
             int imageID = usingImages[imageInd];
           
            image =  new Bitmap($"{imageID}.jpg");
           

            if (leftRight == 0)
            {
                helper = calllabel[tempo].count;
                terra = imageID - 1;
                calllabel[tempo].count = helper + 1;
                pictureLeft.Image = (Image)image;
                label1.Text = calllabel[imageID-1].label;
               
               

            }
            else
            {
                helper = calllabel[terra].count;
                tempo = imageID - 1;
                calllabel[terra].count = helper + 1;
                pictureRight.Image = (Image)image;
                label2.Text = calllabel[imageID-1].label;
               
            }

           

            temp = usingImages[imageInd];
            usingImages[imageInd] = usingImages[border];
            usingImages[border] = temp;
           
            border -= 1;
            // Переместили выбранную картинку за "границу", чтобы она нам не попадалась и передвинули границу на один влево
        }
        
        private void opinion_Click(object sender, EventArgs e)
        {
            ShowResults();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void picLeftClick(object sender, EventArgs e)
        {
            if (border >= 1)
            {
                ChangeImage(1);
            }
            else if (border == 0)
            {
                pictureLeft.Image = (Image)new Bitmap($"11.jpg");
                label1.Text = "";
                helper = calllabel[terra].count;
                calllabel[tempo].count = helper + 1;
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
                pictureLeft.Image = (Image)new Bitmap($"11.jpg"); // Тут точно Left?
                helper = calllabel[tempo].count;
                calllabel[terra].count = helper + 1;
                label1.Text = "";
                MessageBox.Show("Картинки закончились");
                ShowResults();
            }           
        }
      
        private void ShowResults()
        {
            Opin Opin = new Opin();
            
            try
            {
                calllabel.Sort(delegate (LabelAndRating x, LabelAndRating y)
                {
                    if (x == null && y == null) return 0;
                    else if (x == null) return -1;
                    else if (y == null) return 1;
                    else
                        return x.count.CompareTo(y.count);
                });


                Opin.dataGridViewOpin.Rows.Clear();
                for (int i = 0; i < calllabel.Count; i++)
                {
                    Opin.dataGridViewOpin.Rows.Add(calllabel[calllabel.Count - i - 1].label);
                }
               
                   

                Opin.ShowDialog();
            }

            catch (Exception e)
            {
                MessageBox.Show("Ошибка обработки данных");

            }

        }


    }
}
