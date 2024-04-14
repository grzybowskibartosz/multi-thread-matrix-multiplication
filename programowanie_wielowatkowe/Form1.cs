using System.Diagnostics;

namespace programowanie_wielowatkowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void create_matrix_Click(object sender, EventArgs e)
        {
            // Pobranie wartosci rzedu macierzy
            if (!int.TryParse(rankBox1.Text, out int rank_of_matrix))
            {
                MessageBox.Show("Podaj poprawna wartosc rzedu macierzy.", "B³¹d!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            matrix matrixx = new matrix();

            double[,] matrixA = matrixx.GenerateRandomMatrix(rank_of_matrix);

            double[,] matrixB = matrixx.GenerateRandomMatrix(rank_of_matrix);
            DisplayMatrix(matrixA, matrixView1);
            DisplayMatrix(matrixB, matrixView2);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            MultiplyLowLevel(matrixA, matrixB, 1);
            stopwatch.Stop();
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            MultiplyLowLevel(matrixA, matrixB, 8);
            stopwatch2.Stop();
            Stopwatch stopwatch3 = new Stopwatch();
            stopwatch3.Start();
            MultiplyHighLevel(matrixA, matrixB);
            stopwatch2.Stop();

            textBox1.Text = $"{stopwatch2.ElapsedMilliseconds} ms";
            textBox2.Text = $"{stopwatch3.ElapsedMilliseconds} ms";
            textBox3.Text = $"{stopwatch.ElapsedMilliseconds} ms";

        }

        private void DisplayMatrix(double[,] matrix, System.Windows.Forms.DataGridView view)
        {
            view.Rows.Clear();
            view.Columns.Clear();

            // Dodaj kolumny do DataGridView
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                view.Columns.Add("Column" + j, "Column" + j);
            }

            // Dodaj wiersze i ustaw wartoœci komórek
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0)
                        row.CreateCells(view);

                    row.Cells[j].Value = matrix[i, j].ToString("F2");
                }

                view.Rows.Add(row);
                view.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private double[,] MultiplyMatrix(double[,] MA, double[,] MB)
        {
            int size = MA.GetLength(0);
            double[,] result = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < size; k++)
                    {
                        sum += MA[i, k] * MB[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }

        public double[,] MultiplyLowLevel(double[,] MA, double[,] MB, int threadCount)
        {
            int size = MA.GetLength(0);
            double[,] result = new double[size, size];
            Thread[] threads = new Thread[threadCount];
            int elementsPerThread = (size * size) / threadCount;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int t = 0; t < threadCount; t++)
            {
                int threadIndex = t;
                threads[t] = new Thread(() =>
                {
                    int start = threadIndex * elementsPerThread;
                    int end = (threadIndex == threadCount - 1) ? size * size : start + elementsPerThread;

                    for (int index = start; index < end; index++)
                    {
                        int i = index / size;
                        int j = index % size;
                        double sum = 0;
                        for (int k = 0; k < size; k++)
                        {
                            sum += MA[i, k] * MB[k, j];
                        }
                        result[i, j] = sum;
                    }
                });
                threads[t].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            stopwatch.Stop();

            //textBox1.Text = $"{stopwatch.ElapsedMilliseconds} ms";
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.MarqueeAnimationSpeed = 0;

            return result;
        }

        public double[,] MultiplyHighLevel(double[,] MA, double[,] MB)
        {
            int size = MA.GetLength(0);
            double[,] result = new double[size, size];

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Parallel.For(0, size, i =>
            {
                for (int j = 0; j < size; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < size; k++)
                    {
                        sum += MA[i, k] * MB[k, j];
                    }
                    result[i, j] = sum;
                }
            });

            stopwatch.Stop();

            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.MarqueeAnimationSpeed = 0;

            return result;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
