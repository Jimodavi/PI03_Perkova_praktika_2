using System;

namespace praktika_2
{    class CellArray
    {
        public sbyte[,] Array;
        private sbyte[,] NewArray;
        private byte Rows, Columns;
        private Random Random;
        private static sbyte[,] coordinates = { { -1, -1 }, { -1, 0 }, { -1, 1 }, { 0, 1 }, { 1, 1 }, { 1, 0 }, { 1, -1 }, { 0, -1 } };
        public CellArray(byte Rows, byte Columns, sbyte Healthy)
        {/*Создать CellArray*/
            this.Rows = Rows;
            this.Columns = Columns;
            Array = new sbyte[Rows, Columns];
            NewArray = new sbyte[Rows, Columns];
            Random = new Random();
            /*Добавить в this.Array рандомные пары здоровых клеток*/
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (Random.Next(0, 100) == 0)
                    {
                        this.Array[i, j] = Healthy;
                        /*Выбираем случайную соседнюю пустую клетку*/
                        int b = Random.Next(0, 8);
                        /*Добавляем вторую здоровую клетку*/
                        try
                        {
                            this.Array[i + coordinates[b, 0], j + coordinates[b, 1]] = Healthy;
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                }
            }
            /*Копировать this.Array в this.NewArray*/
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    this.NewArray[i, j] = this.Array[i, j];
                }
            }
        }
        public void NewHealthy(int i, int j, ref bool NewCells, sbyte Healthy)
        {/*Создать новую здоровую клетку*/
            bool flag = false, flag2=false;
            for (int k = 0; (k < 8) && !(flag && flag2); k++)
            {
                try
                {/*Если есть соседняя пустая клетка*/
                    if (this.Array[i + coordinates[k, 0], j + coordinates[k, 1]] == 0) flag = true;
                    /*Если есть соседняя здоровая клетка*/
                    else if (this.Array[i + coordinates[k, 0], j + coordinates[k, 1]] == Healthy) flag2 = true;
                }
                catch (Exception)
                {
                    continue;
                }
            }
            if (flag&&flag2)
            {/*Выбрать случайную соседнюю клетку*/
                int b = Random.Next(0, 8);
                int x = i + coordinates[b, 0]; int y = j + coordinates[b, 1];
                /*Если >1 соседних пустых клеток у случайной соседней пустой клетки, то новая здоровая клетка*/
                try
                {
                    if ((this.Array[x, y] == 0) && (Neighboors(x, y, 0) > 1)){
                        this.NewArray[x, y] = Healthy;
                        NewCells = true;
                        }
                }
                catch (Exception){
                    return;
                }
            }
        }
        public void NewVirus(int i, int j, ref bool NewCells, sbyte Healthy, sbyte Virus, sbyte Dead, byte Probability)
        {/*Создать новую клетку вируса*/
            bool[] eight_n = new bool[8];
            bool flag = false;
            int a = 0;
            /*Посчитать и запомнить соседние здоровые клетки*/
            for (int k = 0; (k < 8); k++)
            {
                try
                {
                    if (this.Array[i + coordinates[k, 0], j + coordinates[k, 1]] == Healthy)
                    {
                        eight_n[k] = true;
                        flag = true;
                        a++;/*Количество соседних здоровых клеток*/
                    }
                    else eight_n[k] = false;
                }
                catch (Exception)
                {
                    eight_n[k] = false;
                    continue;
                }
            }
            /*Если есть соседняя здоровая клетка*/
            if (flag)
            {/*C вероятностью Probability/100*/
                int b = Random.Next(0, 100);
                if (b < Probability) {
                    /*Выбрать случайную соседнюю здоровую клетку*/
                    b = Random.Next(0, a);
                    for (a = 0; a < 8; a++)
                    {
                        if (eight_n[a])
                        {
                            if (b == 0) break;
                            else b--;
                        }
                    }
                    int x = i + coordinates[a, 0]; int y = j + coordinates[a, 1];
                    /*Новая клетка вируса*/
                    this.NewArray[x, y] = Virus;
                    NewCells = true;
                }
            }
            else
            {/*Если нет соседних здоровых клеток и <2 вирусов, то новая мёртвая клетка*/
                if (Neighboors(i, j, Virus) < 2) this.NewArray[i, j] = Dead;
                NewCells = true;
            }
        }
        public bool NewMacrophage(int i, int j, ref bool NewCells, sbyte Healthy, sbyte Virus, sbyte Macrophage, byte Probability)
        {/*Создать новую клетку макрофаг*/
            /*Если >1 соседних здоровых и вирусных клеток*/
            if ((Neighboors(i, j, Healthy) > 1) && (Neighboors(i, j, Virus) > 1))
            {/*C вероятностью Probability/100*/
                int RandomNumber = Random.Next(0, 100);
                if (RandomNumber < Probability)
                {/*Новая клетка макрофаг*/
                    this.NewArray[i, j] = Macrophage;
                    NewCells = true;
                    return true;
                }
            }return false;
        }
        public void NewDead(int i, int j, ref bool NewCells, sbyte Virus, sbyte Dead)
        {/*Создать новые мёртвые клетки*/
            bool[] eight_n = new bool[8];
            bool flag = false;
            int a = 0;
            /*Считаем и запоминаем соседние клетки вируса*/
            for (int k = 0; k < 8; k++)
            {
                try {
                if (this.Array[i + coordinates[k, 0], j + coordinates[k, 1]] == Virus)
                {
                    eight_n[k] = true;
                    flag = true;
                    a++;/*Количество соседних клеток вируса*/
                }
                else eight_n[k] = false;
                }
                catch (Exception)
                {
                    eight_n[k] = false;
                    continue;
                }
            }
            /*Если есть соседняя клетка вируса*/
            if (flag)
            {
                /*Выбираем случайную соседнюю клетку вируса*/
                int b = Random.Next(0, a);
                for (a = 0; a < 8; a++)
                {
                    if (eight_n[a])
                    {
                        if (b == 0) break;
                        else b--;
                    }
                }
                int x = i + coordinates[a, 0]; int y = j + coordinates[a, 1];
                /*Новые мёртвые клетки*/
                this.NewArray[x, y] = Dead;
                this.NewArray[i, j] = Dead;
                NewCells = true;
            }
        }
        public void DeadCell(int i, int j, ref bool NewCells)
        {/*Переход мёртвой клетки в пустую*/
            this.NewArray[i, j] = this.Array[i, j];
            this.NewArray[i, j]++;
            NewCells = true;
        }
        protected int Neighboors(int i, int j, sbyte NeighboorNumber)
        {/*Количество соседних this.Array[i,j] клеток равных NeighboorNumber*/
            int result = 0;
            for (int k = 0; k < 8; k++)
            {
                try { 
                if (this.Array[i + coordinates[k, 0], j + coordinates[k, 1]] == NeighboorNumber) result++;
                }
                catch (Exception)
                {
                    continue;
                }
            }
            return result;
        }
        public void Update()
        {/*Глубокое копирование this.NewArray в this.Array*/
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    this.Array[i, j] = this.NewArray[i, j];
                }
            }
        }
        public void RandomVirus(sbyte Virus)
        {/*Добавить рандомные клетки вируса*/
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (Random.Next(0, 100) == 0)
                    {
                        this.Array[i, j] = Virus;
                        this.NewArray[i, j] = Virus;
                    }
                }
            }
        }
    }
}