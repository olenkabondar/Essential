namespace _3Task
{
    internal class MyMatrix
    {
        private int[,] dataMatrix;
        private int rows;
        private int cols;

        public MyMatrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            dataMatrix = new int[rows, cols];
        }

        // Заповнення матриці випадковими числами від 1 до 100
        public void AddRandomDataMatrix()
        {
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    dataMatrix[i, j] = rand.Next(1, 100);
        }

        // Виведення матриці
        public void PrintDataMatrix()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write(dataMatrix[i, j].ToString() + " ");
                Console.WriteLine();
            }
        }

        // Зміна розміру матриці
        public void ResizeDataMatrix(int inputRows, int inputCols)
        {
            int[,] newData = new int[inputRows, inputCols];
            for (int i = 0; i < Math.Min(rows, inputRows); i++)
                for (int j = 0; j < Math.Min(cols, inputCols); j++)
                    newData[i, j] = dataMatrix[i, j];

            dataMatrix = newData;
            rows = inputRows;
            cols = inputCols;
        }
    }
}
