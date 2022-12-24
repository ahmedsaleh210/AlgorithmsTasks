using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KruskalAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void verticesNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int numVertices = int.Parse(verticesNumber.Text);
            int numEdges = int.Parse(edgesNumber.Text);
            string[] inputString = edgesField.Text.Split(',');
            List<Tuple<int, int, int>> edges = new List<Tuple<int, int, int>>();
            for (int n = 0; n < inputString.Length; n++)
            {
                string[] edgeString = inputString[n].Split(' ');
                int u = int.Parse(edgeString[0]);
                int v = int.Parse(edgeString[1]);
                int w = int.Parse(edgeString[2]);
                edges.Add(new Tuple<int, int, int>(w, u, v));
            }
            edges.Sort();

            int[] parent = new int[numVertices];
            for (int j = 0; j < numVertices; j++)
            {
                parent[j] = j;
            }

            List<Tuple<int, int>> mst = new List<Tuple<int, int>>();
            int i = 0;
            while (mst.Count < numVertices - 1)
            {
                int u = edges[i].Item2;
                int v = edges[i].Item3;
                int w = edges[i].Item1;
                i++;
                int setU = Find(parent, u);
                int setV = Find(parent, v);
                if (setU != setV)
                {
                    mst.Add(new Tuple<int, int>(u, v));
                    Union(parent, setU, setV);
                }
            }
            foreach (Tuple<int, int> edge in mst)
            {
                richTextBox1.AppendText(edge.Item1 + " - " + edge.Item2 + "\n");
            }
        }

        static int Find(int[] parent, int vertex)
        {
            if (parent[vertex] != vertex)
            {
                parent[vertex] = Find(parent, parent[vertex]);
            }
            return parent[vertex];
        }

        // Union two disjoint sets
        static void Union(int[] parent, int set1, int set2)
        {
            parent[set1] = set2;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

}


