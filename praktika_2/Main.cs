using System;
using System.Drawing;
using System.Windows.Forms;

namespace praktika_2
{
    public partial class Form : System.Windows.Forms.Form
    {
        Random Random;
        byte Rows, Columns;
        private Graphics Graphics;
        Cell Healthy, Virus, Macrophage, Dead;
        CellArray MainArray;
        bool NewCells;
        byte ProbabilityV, ProbabilityM;
        public Form()
        {
            InitializeComponent();
            Random = new Random();
            Healthy = new Cell(Brushes.BurlyWood, 1);
            Virus = new Cell(Brushes.OrangeRed, 2);
            Macrophage = new Cell(Brushes.SaddleBrown, 3);
            Dead = new Cell(Brushes.DimGray, -4);
            ProbabilityV = (byte)ScrollBarV.Value;
            ProbabilityM = (byte)ScrollBarM.Value;
            PictureBoxMain.Image = new Bitmap(PictureBoxMain.Width, PictureBoxMain.Height);
            Graphics = Graphics.FromImage(PictureBoxMain.Image);
        }
        public void Draw()
        {/*Нарисовать поколение*/
            byte Size = (byte)SquareSize.Value;
            Graphics.Clear(Color.Black);
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if(MainArray.Array[i,j] == Healthy.CellNumber) Graphics.FillRectangle(Healthy.CellBrush, i * Size + i, j * Size + j, Size, Size);
                    else if (MainArray.Array[i, j] == Virus.CellNumber) Graphics.FillRectangle(Virus.CellBrush, i * Size + i, j * Size + j, Size, Size);
                    else if (MainArray.Array[i, j] == Macrophage.CellNumber) Graphics.FillRectangle(Macrophage.CellBrush, i * Size + i, j * Size + j, Size, Size);
                    else if (MainArray.Array[i, j] < 0) Graphics.FillRectangle(Dead.CellBrush, i * Size + i, j * Size + j, Size, Size);
                }
            }
            PictureBoxMain.Refresh();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {/*Вычислить следующее поколение*/
            NewCells = false;
            /*Проверить все клетки, добавить изменения в MainArray.NewArray*/
            for (int i = 0;i<Rows;i++)
                for(int j = 0; j<Columns; j++)
                {
                    if (MainArray.Array[i, j] == Healthy.CellNumber)
                    {
                        MainArray.NewHealthy(i, j, ref NewCells,Healthy.CellNumber);
                    }
                    else if (MainArray.Array[i, j] == Virus.CellNumber)
                    {
                        if(!MainArray.NewMacrophage(i, j, ref NewCells, Healthy.CellNumber, Virus.CellNumber, Macrophage.CellNumber,ProbabilityM))
                        MainArray.NewVirus(i, j, ref NewCells,Healthy.CellNumber,Virus.CellNumber,Dead.CellNumber,ProbabilityV);
                    }
                    else if (MainArray.Array[i, j] == Macrophage.CellNumber) {
                        MainArray.NewDead(i, j, ref NewCells, Virus.CellNumber, Dead.CellNumber);
                    }
                    else if (MainArray.Array[i, j] <0) {
                        MainArray.DeadCell(i,j,ref NewCells);
                    };
                }
            /*Если были изменения, копировать MainArray.NewArray в MainArray.Array*/
            if (NewCells) MainArray.Update();
            /*не было изменений - добавить в рандомные клетки вируса*/
            else MainArray.RandomVirus(Virus.CellNumber);
            Draw();
        }
        private void ButtonNew_Click(object sender, EventArgs e)
        {/*Сгенерировать новое поле*/
            /*Вычислить количество квадратов*/
            int Size = (int)SquareSize.Value + 1;
            Rows = (byte)((int)PictureBoxMain.Height / Size);
            Columns = (byte)((int)PictureBoxMain.Width / Size);
            /*Создать CellArray*/
            MainArray = new CellArray(Rows,Columns, Healthy.CellNumber);
            /*Нарисовать первое поколение*/
            Draw();
            /*Разблокировать кнопку старт*/
            ButtonStart.Enabled = true;
        }
        private void ButtonColor1_Click(object sender, EventArgs e)
        {
            if(ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Healthy.CellBrush = new SolidBrush(ColorDialog.Color);
                PictureBoxHealthy.BackColor = ColorDialog.Color;
            }
        }
        private void ButtonColor2_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Virus.CellBrush = new SolidBrush(ColorDialog.Color);
                PictureBoxVirus.BackColor = ColorDialog.Color;
            }
        }
        private void ButtonColor3_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Macrophage.CellBrush = new SolidBrush(ColorDialog.Color);
                PictureBoxMacrophage.BackColor = ColorDialog.Color;
            }
        }
        private void ButtonColor4_Click(object sender, EventArgs e)
        {
            if(ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Dead.CellBrush = new SolidBrush(ColorDialog.Color);
                PictureBoxDead.BackColor = ColorDialog.Color;
            }
        }
        private void ScrollBarTimer_Scroll(object sender, ScrollEventArgs e)
        {/*Изменить интервал обновления*/
            Timer.Interval = ScrollBarTimer.Value;
        }
        private void SquareSize_ValueChanged(object sender, EventArgs e)
        {/*Перерисовать если изменён размер*/
            if (ButtonStart.Enabled && !Timer.Enabled) Draw();
        }
        private void ScrollBarV_Scroll(object sender, ScrollEventArgs e)
        {/*Изменить вероятность появления вирусных клеток*/
            ProbabilityV = (byte)ScrollBarV.Value;
        }
        private void ScrollBarM_Scroll(object sender, ScrollEventArgs e)
        {/*Изменить вероятность появления клеток макрофагов*/
            ProbabilityM = (byte)ScrollBarM.Value;
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {/*Старт и стоп*/
            if (Timer.Enabled)
            {
                Timer.Stop();
                ButtonStart.Text = "Старт";
                ButtonNew.Enabled = true;
                SquareSize.Enabled = true;
            }
            else
            {
                ButtonStart.Text = "Стоп";
                ButtonNew.Enabled = false;
                SquareSize.Enabled = false;
                Timer.Start();
            }
        }
    }
}