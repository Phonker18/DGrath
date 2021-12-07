using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DGrath
{
    public partial class Form1 : Form
    {
        DrawGraph G;
        List<Vertex> V;
        List<Edge> E;
        int[,] AMatrix; //матрица смежности
        int[,] DMatrix;
        int selected1; //выбранные вершины, для соединения линиями
        int selected2;

        public Form1()
        {
            InitializeComponent();
            V = new List<Vertex>();
            G = new DrawGraph(sheet.Width, sheet.Height);
            E = new List<Edge>();
            sheet.Image = G.GetBitmap();

        }

        //кнопка - рисовать вершину
        private void drawVertexButton_Click(object sender, EventArgs e)
        {
            drawVertexButton.Enabled = false;
            drawEdgeButton.Enabled = true;
            deleteButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
        }

        //кнопка - рисовать ребро
        private void drawEdgeButton_Click(object sender, EventArgs e)
        {
            drawEdgeButton.Enabled = false;
            drawVertexButton.Enabled = true;
            deleteButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
            selected1 = -1;
            selected2 = -1;
        }

        //кнопка - удалить элемент
        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteButton.Enabled = false;
            drawVertexButton.Enabled = true;
            drawEdgeButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
        }

        //кнопка - удалить граф
        private void deleteALLButton_Click(object sender, EventArgs e)
        {
            drawVertexButton.Enabled = true;
            drawEdgeButton.Enabled = true;
            deleteButton.Enabled = true;
            const string message = "Вы действительно хотите полностью удалить граф?";
            const string caption = "Удаление";
            var MBSave = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MBSave == DialogResult.Yes)
            {
                V.Clear();
                E.Clear();
                G.clearSheet();
                sheet.Image = G.GetBitmap();
            }
        }

        //кнопка - матрица смежности
        private void buttonAdj_Click(object sender, EventArgs e)
        {
            createAdjAndOut();
        }


        private void sheet_MouseClick(object sender, MouseEventArgs e)
        {
            //нажата кнопка "рисовать вершину"
            if (drawVertexButton.Enabled == false)
            {
                V.Add(new Vertex(e.X, e.Y));
                G.drawVertex(e.X, e.Y, V.Count.ToString());
                sheet.Image = G.GetBitmap();
            }
            //нажата кнопка "рисовать ребро"
            if (drawEdgeButton.Enabled == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    for (int i = 0; i < V.Count; i++)
                    {
                        if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                        {
                            if (selected1 == -1)
                            {
                                G.drawSelectedVertex(V[i].x, V[i].y);
                                selected1 = i;
                                sheet.Image = G.GetBitmap();
                                break;
                            }
                            if (selected2 == -1)
                            {
                                G.drawSelectedVertex(V[i].x, V[i].y);
                                selected2 = i;
                                E.Add(new Edge(selected1, selected2, Convert.ToInt32(txbValue.Text)));
                                G.drawEdge(V[selected1], V[selected2], E[E.Count - 1]);
                                selected1 = -1;
                                selected2 = -1;
                                sheet.Image = G.GetBitmap();
                                break;
                            }
                        }
                    }
                }
                if (e.Button == MouseButtons.Right)
                {
                    if ((selected1 != -1) &&
                        (Math.Pow((V[selected1].x - e.X), 2) + Math.Pow((V[selected1].y - e.Y), 2) <= G.R * G.R))
                    {
                        G.drawVertex(V[selected1].x, V[selected1].y, (selected1 + 1).ToString());
                        selected1 = -1;
                        sheet.Image = G.GetBitmap();
                    }
                }
            }
            //нажата кнопка "удалить элемент"
            if (deleteButton.Enabled == false)
            {
                bool flag = false; //удалили ли что-нибудь по ЭТОМУ клику
                //ищем, возможно была нажата вершина
                for (int i = 0; i < V.Count; i++)
                {
                    if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                    {
                        for (int j = 0; j < E.Count; j++)
                        {
                            if ((E[j].v1 == i) || (E[j].v2 == i))
                            {
                                E.RemoveAt(j);
                                j--;
                            }
                            else
                            {
                                if (E[j].v1 > i) E[j].v1--;
                                if (E[j].v2 > i) E[j].v2--;
                            }
                        }
                        V.RemoveAt(i);
                        flag = true;
                        break;
                    }
                }
                //ищем, возможно было нажато ребро
                if (!flag)
                {
                    for (int i = 0; i < E.Count; i++)
                    {

                        if (((e.X - V[E[i].v1].x) * (V[E[i].v2].y - V[E[i].v1].y) / (V[E[i].v2].x - V[E[i].v1].x) + V[E[i].v1].y) <= (e.Y + 4) &&
                            ((e.X - V[E[i].v1].x) * (V[E[i].v2].y - V[E[i].v1].y) / (V[E[i].v2].x - V[E[i].v1].x) + V[E[i].v1].y) >= (e.Y - 4))
                        {
                            if ((V[E[i].v1].x <= V[E[i].v2].x && V[E[i].v1].x <= e.X && e.X <= V[E[i].v2].x) ||
                                (V[E[i].v1].x >= V[E[i].v2].x && V[E[i].v1].x >= e.X && e.X >= V[E[i].v2].x))
                            {
                                E.RemoveAt(i);
                                flag = true;
                                break;
                            }
                        }
                    }
                }
                //если что-то было удалено, то обновляем граф на экране
                if (flag)
                {
                    G.clearSheet();
                    G.drawALLGraph(V, E);
                    sheet.Image = G.GetBitmap();
                }
            }
        }

        //создание матрицы смежности и вывод в грид
        private void createAdjAndOut()
        {
            AMatrix = new int[V.Count, V.Count];
            G.fillAdjacencyMatrix(V.Count, E, AMatrix);
            MGridView.RowCount = V.Count;
            MGridView.ColumnCount = V.Count;
            for (int i = 0; i < MGridView.RowCount; i++)
            {
                MGridView.Columns[i].HeaderText = (i + 1).ToString();
                MGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                for (int j = 0; j < MGridView.ColumnCount; j++)
                {
                    MGridView.Rows[i].Cells[j].Value = AMatrix[i, j];
                }
            }
        }


        private int ShortestPath(int start, int end, int[,] matrix)
        {
            txbRes.Text = "";
            bool[] visited = new bool[V.Count];
            int visitedCount = 0;
            int[] dist = new int[V.Count];
            for (int i = 0; i < V.Count; i++)
            {
                dist[i] = int.MaxValue;
            }
            dist[start] = 0;
            int current = start;
            while (visitedCount <= V.Count)
            {
                visited[current] = true;
                visitedCount++;
                if (current == end)
                    break;
                for (int i = 0; i < V.Count; i++)
                    if (matrix[current, i] != 0)
                    {
                        var newDist = dist[current] + matrix[current, i];
                        dist[i] = Math.Min(newDist, dist[i]);
                    }
                int min = int.MaxValue;
                for (int i = 0; i < V.Count; i++)
                    if (!visited[i] && dist[i] < min)
                    {
                        min = dist[i];
                        current = i;
                    }
            }
            var path = new Stack<int>();
            path.Push(end);
            while (path.Peek() != start)
            {
                int i;
                for (i = 0; i < V.Count; i++)

                    if (matrix[path.Peek(), i] != 0)
                        if (dist[i] == dist[path.Peek()] - matrix[path.Peek(), i])
                        {
                            path.Push(i);
                            break;
                        }
                if (i == V.Count)
                {
                    txbRes.Text = "Между вершинами нет пути";
                    break;
                }
            }

            foreach (var v in path)
                txbRes.Text += " -> " + (v + 1);
            int distance = dist[end];
            txbRes.Text += $" | Расстояние = {distance}";
            return distance;
        }

        private void CreateDistAndOut()
        {
            DMatrix = new int[V.Count, V.Count];
            for (int i = 0; i < V.Count; i++)
            {
                for (int j = 0; j < V.Count; j++)
                {
                    if (i == j) DMatrix[i, j] = 0;
                    else DMatrix[i, j] = DMatrix[j, i] = ShortestPath(i, j, AMatrix);
                }
            }
            txbRes.Text = "";
            DGridView.RowCount = V.Count;
            DGridView.ColumnCount = V.Count;
            for (int i = 0; i < DGridView.RowCount; i++)
            {
                DGridView.Columns[i].HeaderText = (i + 1).ToString();
                DGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                for (int j = 0; j < DGridView.ColumnCount; j++)
                {
                    DGridView.Rows[i].Cells[j].Value = DMatrix[i, j];
                }
            }
        }

        private void foundMinV()
        {
            txbRes.Text = "";
            int[] sumDist = new int[V.Count];
            for (int i = 0; i < V.Count; i++)
            {
                sumDist[i] = 0;
                for (int j = 0; j < V.Count; j++)
                {
                    sumDist[i] += DMatrix[i, j];
                }
            }
            int min = sumDist[0];
            int minV = 0;
            for (int i = 1; i < V.Count; i++)
            {
                if (sumDist[i] < min)
                {
                    min = sumDist[i];
                    minV = i;
                }
            }
            txbRes.Text = $"Город: {minV + 1} | минимальная сумма: {min}";
        }
        private bool DFC(int v)
        {
            txbRes.Text = "";
            bool[] visited = new bool[V.Count];
            for (int i = 0; i < V.Count; i++)
            {
                visited[i] = false;
            }
            //For DFS use stack
            var stack = new Stack<int>();
            stack.Push(v);
            while (stack.Count > 0)
            {
                v = stack.Pop();
                if (visited[v]!=true)
                txbRes.Text = txbRes.Text + " -> " + (v + 1);
                visited[v] = true;
                for (int i = V.Count-1; i >= 0; i--)
                {
                    if (AMatrix[v, i] != 0 && !visited[i])
                    {
                        stack.Push(i);
                    }
                }
            }
            int cnt = 0;
            for (int i = 0; i < V.Count; i++)
            {
                if (visited[i] == false)
                    cnt++;
            }
            if (cnt > 0)
                return false;
            else return true;
        }

        private int getDegree(int v, int[,] matrix)
        {
            int degree = 0;
            for (int i = 0; i < V.Count; i++)
            {
                degree += matrix[v, i];
            }
            return degree;
        }

        private int getAdjacent(int v, int[,] matrix)
        {
            int adjacent = -1;
            for (int i = 0; i < V.Count; i++)
            {
                if (matrix[v, i] == 1)
                {
                    adjacent = i;
                    break;
                }
            }
            return adjacent;
        }


        private void EulerianCycle()
        {

            if (DFC(0) == false)
            {
                txbRes.Text = "";
                txbRes.Text = "Граф не содержит эйлерова цикла, так как граф несвязный";
            }
            else
            {
                bool flag = true;
                txbRes.Text = "";
                for (int i = 0; i < V.Count; i++)
                {
                    if (getDegree(i, AMatrix) % 2 != 0)
                    {
                        txbRes.Text = "Граф не содержит эйлерова цикла, так как не все вершины имеют четную степень";
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    int[,] matrix = new int[V.Count, V.Count];

                    for (int i = 0; i < V.Count; i++)
                    {
                        for (int j = 0; j < V.Count; j++)
                        {
                            matrix[i, j] = AMatrix[i, j];
                        }
                    }
                    var stack = new Stack<int>();
                    var cycl = new Stack<int>();
                    stack.Push(0);
                    while (stack.Count > 0)
                    {
                        int node = stack.Peek();
                        if (getDegree(node, matrix) > 0)
                        {
                            int adjacent = getAdjacent(node, matrix);
                            stack.Push(adjacent);
                            matrix[node, adjacent] = 0;
                            matrix[adjacent, node] = 0;
                        }
                        else
                            cycl.Push(stack.Pop());
                    }

                    while (cycl.Count > 0)
                    {
                        int v = cycl.Pop();
                        txbRes.Text = txbRes.Text + " -> " + (v + 1);
                    }
                }

            }
        }

        private void btnDFC_Click(object sender, EventArgs e)
        {

            int start = Convert.ToInt32(txbStart.Text);
            DFC(start - 1);
        }

        private void btnCycle_Click(object sender, EventArgs e)
        {
            EulerianCycle();
        }

        private void btnDist_Click(object sender, EventArgs e)
        {
            CreateDistAndOut();
        }

        private void btnMinV_Click(object sender, EventArgs e)
        {
            foundMinV();
        }
    }
}
