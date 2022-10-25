using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //criar uma folha em branco

            //criar um desenhador

            //utilizar o desenho ou imagem
        }

        private void btnDesenhar_Click(object sender, EventArgs e)
        {
            //Folha em branco
            Bitmap folha = new Bitmap(picture.Width, picture.Height);

            //criar desenhador
            Graphics desenhador = Graphics.FromImage(folha);
            //desenhar na folha
            desenhador.Clear(Color.White);

            #region Desenhando linhas
            //Brush pincel = new SolidBrush(Color.Red);
            //Pen lapis = new Pen(pincel, 5);
            //Point ponto1 = new Point(100, 200);
            //Point ponto2 = new Point(400, 100);

            //Pen lapis2 = new Pen(Color.Black, 10);
            //Point ponto3 = new Point(0, 0);
            //Point ponto4 = new Point(100, 200);

            //desenhador.DrawLine(lapis, ponto1, ponto2);
            //desenhador.DrawLine(lapis2, ponto2, ponto3);
            //Point[] pontos =
            //{
            //    new Point(50,50),
            //    new Point(250,50),
            //    new Point(250,150),
            //    new Point(100,80),
            //    new Point(85,140),
            //};
            //desenhador.DrawLines(lapis, pontos);
            #endregion

            #region Retangulo
            //Pen lapis = new Pen(Color.Black, 5);
            //Pen lapis2 = new Pen(Color.Blue, 10);
            //Rectangle rect1 = new Rectangle(100, 50, 300, 200);
            //Rectangle rect2 = new Rectangle(50, 850, 120, 40);
            //Rectangle rect3 = new Rectangle(120, 20, 145, 100);
            //Rectangle rect4 = new Rectangle(75, 200, 250, 100);
            //desenhador.DrawRectangle(lapis, 100, 50, 300, 200);
            //desenhador.DrawRectangle(lapis, rect1);
            //desenhador.DrawRectangle(lapis2, 0,0,250,200);
            //Rectangle[] rectangles =
            //{
            //    rect1, rect2, rect3, rect4, new Rectangle(10,30,240,85)
            //};
            //desenhador.DrawRectangles(lapis, rectangles);

            //retangulo preenchido
            //Brush pincel = new SolidBrush(Color.Green);
            //Brush pincel2 = new LinearGradientBrush(rect1, Color.Green, Color.Yellow, 90);
            //desenhador.FillRectangle(pincel2, rect1);
            //desenhador.FillRectangles(pincel, rectangles);
            #endregion

            #region Ellipse e Circulos
            //desenhador.DrawRectangle(lapis, rec1);
            //desenhador.DrawEllipse(lapis, rec1);
            //Brush pincel = new SolidBrush(Color.Yellow);
            //desenhador.FillEllipse(pincel, rec1);
            //desenhador.FillEllipse(Brushes.Green, rec1); // não precisa criar um pincel
            #endregion

            #region Poligonos
            //Pen lapis = new Pen(Color.Black, 5);
            //Point[] pontos =
            //{
            //    new Point(100,100),
            //    new Point(300,200),
            //    new Point(250,250),
            //    new Point(100,100)

            //};
            //desenhador.DrawPolygon(lapis, pontos);
            //desenhador.FillPolygon(Brushes.Blue, pontos);
            #endregion

            #region Curvas
            //Pen lapis = new Pen(Color.Black, 5);
            //Point[] pontos =
            //{
            //    new Point(100,50),
            //    new Point(200,150),
            //    new Point(300,100),
            //    new Point(500, 250),
            //    new Point(300, 200)

            //};
            //desenhador.DrawCurve(lapis, pontos);
            //desenhador.DrawClosedCurve(lapis, pontos); une os ultimo ponto com o primeiro
            //desenhador.FillClosedCurve(Brushes.Red, pontos);
            #endregion

            #region Arcos
            //Pen lapis = new Pen(Color.Red, 5);
            //Rectangle rect = new Rectangle(100, 15, 300, 250);
            //desenhador.DrawArc(lapis, rect, 45f, 90f);
            #endregion

            #region Beziers
            //Pen lapis = new Pen(Color.Black, 5);
            //Point p1 = new Point(50, 50);
            //Point p2 = new Point(200, 400);
            //Point p3 = new Point(400, 100);
            //Point p4 = new Point(500, 200);

            //desenhador.DrawBezier(lapis, p1, p2, p3, p4);
            //Point [] pontos =
            //{
            //    new Point(50, 50), //inicio
            //new Point(200, 400),
            //new Point(400, 100),
            //new Point(500, 200), // meio
            //new Point(200, 400),
            //new Point(400, 100),
            //new Point(500, 200) //meio
            //};
            //desenhador.DrawBeziers(lapis, pontos);
            #endregion

            #region Pie
            //Pen lapis = new Pen(Color.Black, 5);
            //Rectangle rect = new Rectangle(50, 10, 100, 100);
            //desenhador.DrawPie(lapis, rect, 250,90 );
            //desenhador.FillPie(Brushes.Bisque, rect, 250, 45);
            //desenhador.DrawRectangle(lapis, rect);
            #endregion

            #region Path
            //Pen lapis = new Pen(Color.Black, 1);
            //GraphicsPath graphicsPath = new GraphicsPath(FillMode.Alternate);
            //graphicsPath.AddEllipse(new RectangleF(10, 10, 100, 150));
            //graphicsPath.AddEllipse(new RectangleF(50, 10, 100, 150));
            //graphicsPath.AddRectangle(new RectangleF(150, 50, 150, 100));
            //desenhador.DrawPath(lapis, graphicsPath);
            #endregion

            #region Strings
            //Pen lapis = new Pen(Color.Red, 1);
            //Font letra = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Point);
            //Point point = new Point(50, 100);
            //string texto = "hohgoah oihgdoaj jiodhfaoj jijgijgkãjoia oihhnahuaiuahdavnçiáoçdn";
            //StringFormat alinhamento = new StringFormat();
            //alinhamento.Alignment = StringAlignment.Center;
            //alinhamento.LineAlignment = StringAlignment.Center;
            //desenhador.DrawString("texto teste", letra, Brushes.Black, point);
            //Rectangle rect = new Rectangle(10, 50, 150, 150);

            //desenhador.DrawString(texto, letra, Brushes.Black, rect, alinhamento);
            //desenhador.DrawRectangle(lapis, rect);
            #endregion

            #region Imagens
            Image imgOrigem = Image.FromFile(@"C:\Users\fvo_l\OneDrive\Imagens\Planet9\planeta.jpg");
            Rectangle origem1 = new Rectangle(1484, 961, 904, 224);
            Rectangle destino1 = new Rectangle(125, 0, imgOrigem.Width / 10, imgOrigem.Height / 10);

            desenhador.DrawImage(imgOrigem, destino1, origem1, GraphicsUnit.Pixel);
            #endregion

            //utilizar o num picturebox
            picture.BackgroundImage = folha;

            //salvar imagem
            //folha.Save(@"D:\ProjetosC#\desenho.jpg", System.Drawing.Imaging.ImageFormat.);

        }
    }
}
