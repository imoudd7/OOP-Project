
/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
** PROGRAMLAMAYA GİRİŞİ DERSİ
**Youtube Link: https://www.youtube.com/watch?v=e4TP2revs3c
** ÖDEV NUMARASI: NDP Project
** ÖĞRENCİ ADI: MAHMOUD ALDAHER
** ÖĞRENCİ NUMARASI: G221210588
** DERS GRUBU:  2/B
****************************************************************************/




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {





            Random random = new Random();






            int xCember, yCember, x2Cember, y2Cember;
            xCember = random.Next(200, 250);
            yCember = random.Next(50, 100);
            x2Cember = random.Next(120, 150);
            y2Cember = random.Next(120, 150);




            Pen pen = new Pen(Color.DarkSeaGreen, 5);
           
                e.Graphics.DrawEllipse(pen, xCember, yCember, x2Cember, y2Cember);



          

            

            // ucgenin koordinatlar
            int ucgenX1, ucgenX2, ucgenY1, ucgenY2, ucgenZ1, ucgenZ2;

            ucgenX1 = random.Next(25, 45); ucgenX2 = random.Next(25, 45);
           ucgenY1 = random.Next(100, 145); ucgenY2 = random.Next(100, 145);
            ucgenZ1 = 160; ucgenZ2 = 80;
            // Üçgenin köşeleri
            Point point1 = new Point(ucgenX1, ucgenX2);
            Point point2 = new Point(ucgenY1, ucgenY2);
            Point point3 = new Point(ucgenZ1, ucgenZ2);

            //Bu Ukoseleri iceren bir dizidir
            Point[] trianglePoints = { point1, point2, point3 };

            //Bu Cizginin Rengi
            Color lineColor = Color.White;

            //Bu Cizginin kalinligi icin
            int lineWidth = 2;

            //Bu Cizginin nesnesii olusturma icim
            Pen trianglePen = new Pen(lineColor, lineWidth);

            // Üçgeni çizme
            e.Graphics.DrawPolygon(trianglePen, trianglePoints);














            int xdogru, ydogru, x2dogru, y2dogru;
            xdogru = random.Next(50, 100);
            ydogru = random.Next(300, 330);
            x2dogru = random.Next(300, 310);
            y2dogru = random.Next(300, 330);







            //Bu Dogru icin
            Pen pen1 = new Pen(Color.DarkOrchid, 3);
            Point pointdx = new Point(xdogru, x2dogru);
            Point pointdy = new Point(ydogru, y2dogru);
            e.Graphics.DrawLine(pen1, pointdx, pointdy);
















            Graphics nokta = e.Graphics;
            
            int noktax, noktay;
            noktax = random.Next(300, 340);
            noktay = random.Next(80, 100);

            //Nokta
            Pen pen2 = new Pen(Color.DimGray, 3);
            nokta.DrawEllipse(pen2, noktax, noktay, 2, 2);








            Graphics h = e.Graphics;


            int dikx1, dikx2, diky1, diky2;
            dikx1 = random.Next(140, 145);
            dikx2 = random.Next(40, 85);
            diky1 = random.Next(250, 260);
            diky2 = random.Next(60, 85);



            // Dikdortgen
            Pen pen3 = new Pen(Color.Purple, 7);
            h.DrawRectangle(pen3, dikx1, diky1, dikx2 + dikx2, diky2+diky2);












            Graphics kure = e.Graphics;

            int kurex, kurey, kurex2, kurey2;
            kurex = random.Next(400, 450);
            kurey = random.Next(400, 450);
            kurex2 = random.Next(150, 200);
            kurey2 = random.Next(150, 250);

           
                
                
 
            //KURE
            SolidBrush brush = new SolidBrush(Color.DeepPink);
            kure.FillEllipse(brush, kurex, kurey, kurex2 , kurey2);






            int dikpx1, dikpx2, dikpy1, dikpy2;

            dikpx1 = random.Next(450, 500);
            dikpx2 = random.Next(50, 150);
            dikpy1 = random.Next(200, 210);
            dikpy2 = random.Next(200, 210);


                             


            Graphics dik = e.Graphics;

            //DikdOrtgen Prizma
            SolidBrush brushdik = new SolidBrush(Color.Red);
            SolidBrush brushdik2 = new SolidBrush(Color.DarkRed);
            dik.FillRectangle(brushdik, dikpx1, dikpy1, dikpx2, dikpy2);
            dik.FillRectangle(brushdik, dikpx1 + 1, dikpy1 + 1, dikpx2 + 5, dikpy2 + 3);
            dik.FillRectangle(brushdik, dikpx1 + 2, dikpy1 + 2, dikpx2 + 5, dikpy2 + 3);
            dik.FillRectangle(brushdik2, dikpx1 + 5, dikpy1 + 5, dikpx2 +5, dikpy2+3);





            // -----------------------------------------------CARPISMA KOONTROLLERI----------------------------------------//



           

            // Dogru ve dikdortgen cakisma 
            if (xdogru == x2dogru && ydogru == y2dogru)
            {
                textBox3.Text = ("Doğru sadece bir noktadan oluşuyor ve dikdörtgenle çakışamaz.");
            }
            else if (xdogru == x2dogru)
            {
                if ((ydogru > diky1 && ydogru < diky2) || (y2dogru > diky1 && y2dogru < diky2))
                {
                    textBox3.Text = ("Doğru dikdörtgenle çakışıyor.");
                }
                else
                {
                    textBox3.Text = ("Doğru dikdörtgenle çakışmıyor.");
                }
            }
            else if (ydogru == y2dogru)
            {
                if ((xdogru > dikx1 && xdogru < dikx2) || (x2dogru > dikx1 && x2dogru < dikx2))
                {
                    textBox3.Text = ("Doğru dikdörtgenle çakışıyor.");
                }
                else
                {
                    textBox3.Text = ("Doğru dikdörtgenle çakışmıyor.");
                }
            }
            else
            {
                textBox3.Text = ("Doğru eğimli olduğu için dikdörtgenle çakışması kontrol edilemiyor.");
            }



            //-------------------------------------------------------------------------------//


            if ((noktax - xCember) * (noktax - xCember) + (noktay - yCember) * (noktay - yCember) <= x2Cember * y2Cember)
            {
                textBox2.Text = ("Çember noktayla çakışıyor.");
            }
            else
            {
                textBox2.Text=("Çember noktayla çakışmıyor.");
            }




            //-------------------------------------------------------------------------------//





            // Cember ve ucgen cakısma.
            if (((xCember - ucgenX1) * (ucgenY2 - ucgenY1) - (ucgenX2 - ucgenX1) * (yCember - ucgenY1)) * ((xCember - ucgenX2) *
                (ucgenZ2 - yCember) - (ucgenZ1 - ucgenX2) * (yCember - yCember)) >= 0 && ((xCember - ucgenX2) * (ucgenZ2 - yCember) - (ucgenZ1 - ucgenX2) * 
                (yCember - yCember)) * ((xCember - ucgenZ1) * (ucgenY1 - ucgenZ2) - (ucgenX1 - ucgenZ1) * (yCember - ucgenZ2)) >= 0 && ((xCember - ucgenZ1)
                * (ucgenY1 - ucgenZ2) - (ucgenX1 - ucgenZ1) * (yCember - ucgenZ2)) * ((xCember - ucgenX1) * (yCember - ucgenY1) - (ucgenX2 - ucgenX1) * 
                (yCember - ucgenY1)) >= 0)
            {
                textBox1.Text = "Çember üçgenle çakışıyor.";
            }
            else if ((xCember - ucgenX1) * (xCember - ucgenX1) + (yCember - ucgenY1) * (yCember - ucgenY1) <= y2Cember *
                x2Cember || (xCember - ucgenX2) * (xCember - ucgenX2) + (yCember - yCember) * (yCember - yCember) <= y2Cember *
                x2Cember || (xCember - ucgenZ1) * (xCember - ucgenZ1) + (yCember - ucgenZ2) * (yCember - ucgenZ2) <= y2Cember * x2Cember)
            {
                textBox1.Text = "Çember üçgenle çakışıyor.";
            }
            else
            {
               textBox1.Text = "Çember üçgenle çakışmıyor.";
            }




            //-------------------------------------------------------------------------------//



            // Dikdortgen ve ucgen çakışma.
            if ((ucgenX1 >= dikx1 && ucgenX1 <= dikx2 && ucgenY1 >= diky1 && ucgenY1 <= diky2) ||
                (ucgenX2 >= dikx1 && ucgenX2 <= dikx2 && ucgenY2 >= diky1 && ucgenY2 <= diky2) ||
                (ucgenZ1 >= dikx1 && ucgenZ1 <= dikx2 && ucgenZ2 >= diky1 && ucgenZ2 <= diky2))
            {
                textBox4.Text = ("Dikdörtgen ve üçgen çakışıyor.");
            }
            else
            {
                textBox4.Text = ("Dikdörtgen ve üçgen çakışmıyor.");
            }


















        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string cisim1, cisim2;
        private void button1_Click(object sender, EventArgs e)
        {
            cisim1 = comboBox1.Text;
            cisim2 = comboBox2.Text;
            textBox8.Text = "      " + cisim1 + " veya  " + cisim2;
        }
        

        private void label7_Click(object sender, EventArgs e)
        {
            cisim1 = comboBox1.Text;
            cisim2 = comboBox2.Text;
            textBox8.Text = "      " + cisim1 + " veya  " + cisim2;
        }
    }
}
