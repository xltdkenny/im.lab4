using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab4
{
    public partial class Form1 : Form
    {
        int CellSize = 10;
        int Rows = 50;
        int Cols = 50;
        bool[,] grid;
        bool running;

        public Form1()
        {
            InitializeComponent();
            InitializeMap();
        }

        private void InitializeMap()
        {
            grid = new bool[Rows, Cols];
            var rand = new Random();

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    grid[i, j] = rand.Next(0, 2) == 1;
                }
            }

            pictureBox1.Paint += pictureBox1_Paint;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;



            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (grid[i, j])
                    {
                        g.FillRectangle(Brushes.Black, j * CellSize, i * CellSize, CellSize, CellSize);
                    }
                }
            }

        }

        private void UpdateGrid()
        {
            var newGrid = new bool[Rows, Cols];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    int neighbors = CountNeighbors(i, j);

                    if (grid[i, j])
                    {

                        if (neighbors >= (int)edMinLive.Value && neighbors <= (int)edMaxLive.Value)
                        {
                            newGrid[i, j] = true;
                        }
                        else
                        {
                            newGrid[i, j] = false;
                        }

                    }
                    else
                    {
                        if (neighbors >= (int)edMinBorn.Value && neighbors <= (int)edMaxBorn.Value)
                        {
                            newGrid[i, j] = true;
                        }
                        else
                        {
                            newGrid[i, j] = false;
                        }
                    }
                }
            }

            grid = newGrid;
            pictureBox1.Invalidate();
        }

        private int CountNeighbors(int x, int y)
        {
            int count = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int row = (x + i + Rows) % Rows;
                    int col = (y + j + Cols) % Cols;

                    if (!(i == 0 && j == 0) && grid[row, col])
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                running = true;
                btStart.Text = "Stop";
                while (running)
                {
                    UpdateGrid();
                    Thread.Sleep(100);
                    Application.DoEvents();
                }
            }
            else
            {
                running = false;
                btStart.Text = "Start";
            }
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            InitializeMap();
            UpdateGrid();
        }
    }
}
