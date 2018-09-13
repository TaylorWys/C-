using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SubwayApplicationtest
{
    public partial class Form1 : Form
    {
        public string sourceName, finalName, shortestPath, leastPath;
        public Vertex source, final;
        public int shortestDistance, tranNum;
        public GraphList G = new GraphList();
        public Hashtable hn = new Hashtable();
        public Hashtable NumToName = new Hashtable();
        File1 Ftmp = new File1();
        public ArrayList St = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            Ftmp.Read(G, out hn, out NumToName);
        }

        private void DrawGrayBack() {
            Graphics g;
            g = this.CreateGraphics();
            g.Clear(this.BackColor);
            Pen graypen2 = new Pen(Color.Gray, 2);
            Pen graypen1 = new Pen(Color.Gray, 2);
            Brush stringbrush = new SolidBrush(Color.Black);
            Font stringfont = new Font("宋体", 10);
            foreach (Vertex i in G.items) {
                g.DrawEllipse(graypen2, i.location.X-4, i.location.Y-4, 8, 8);
                g.DrawString(i.name, stringfont, stringbrush, i.location);
            }
            StreamReader er = new StreamReader("data/subway_data_easy.txt", Encoding.GetEncoding("gb2312"));
            string rLine,aline;
            Vertex A;
            Vertex B;
            string[] splitArrary;                                                            //储存按行读取,分割后数值
            while ((rLine = er.ReadLine()) != null) {
                switch (rLine) {
                    case "1号线":  continue;
                    case "2号线":  continue;
                    case "5号线":  continue;
                    case "6号线":  continue;
                    case "10号线":  continue;
                    default:
                        break;
                }
                splitArrary = rLine.Split(' ');
                aline = splitArrary[0];
                A = (Vertex)G.items[Convert.ToInt32(hn[splitArrary[0]])];
                B = (Vertex)G.items[Convert.ToInt32(hn[splitArrary[1]])];
                g.DrawLine(graypen1,A.location,B.location);
            }
            er.Close();
        }

        private void DrawMap() {
            Graphics g;
            g = this.CreateGraphics();
            g.Clear(this.BackColor);
            Pen graypen1 = new Pen(Color.Gray, 2);
            Pen redpen1 = new Pen(Color.Red, 2);
            Pen bluepen1 = new Pen(Color.Blue, 2);
            Pen lightbluepen1 = new Pen(Color.LightBlue,2);
            Pen purple1 = new Pen(Color.Purple, 2);
            Pen orangepen1 = new Pen(Color.Orange,2);
            Brush stringbrush = new SolidBrush(Color.Black);
            Font stringfont = new Font("宋体", 10);
            foreach (Vertex i in G.items) {
                g.DrawEllipse(graypen1, i.location.X - 4, i.location.Y - 4, 8, 8);
                g.DrawString(i.name, stringfont, stringbrush, i.location);
            }
            StreamReader er = new StreamReader("data/subway_data_easy.txt", Encoding.GetEncoding("gb2312"));
            string rLine, aline;
            Vertex A;
            Vertex B;
            Pen P=graypen1;
            string[] splitArrary;                                                            //储存按行读取,分割后数值
            while ((rLine = er.ReadLine()) != null) {
                switch (rLine) {
                    case "1号线": P = redpen1; continue;
                    case "2号线": P = lightbluepen1; continue;                 
                    case "5号线": P = purple1; continue;
                    case "6号线": P = orangepen1; continue;
                    case "10号线": P = bluepen1; continue;
                    default:
                        break;
                }
                splitArrary = rLine.Split(' ');
                aline = splitArrary[0];
                A = (Vertex)G.items[Convert.ToInt32(hn[splitArrary[0]])];
                B = (Vertex)G.items[Convert.ToInt32(hn[splitArrary[1]])];
                textBox4.Clear();
                textBox4.AppendText(splitArrary[0]+ splitArrary[1]);
                g.DrawLine(P, A.location, B.location);
            }
            er.Close();
        }

        private void DrawPath(ArrayList St) {
            Graphics g;
            g = this.CreateGraphics();
            Vertex A;
            Vertex B;
            Pen pen1 = new Pen(Color.Red, 2);
            Pen redpen1 = new Pen(Color.Red, 2);
            Pen bluepen1 = new Pen(Color.Blue, 2);
            Pen lightbluepen1 = new Pen(Color.LightBlue, 2);
            Pen purple1 = new Pen(Color.Purple, 2);
            Pen orangepen1 = new Pen(Color.Orange, 2);
            int lineColor = 0;
            for (int i = 1; i < St.Count; i++) {
                A = (Vertex)G.items[Convert.ToInt32(St[i])];
                B = (Vertex)G.items[Convert.ToInt32(St[i-1])];
                foreach (int element1 in (A.lineNo)) {
                    foreach (int element2 in (B.lineNo)) {
                        if (element1 == element2) {
                            lineColor = element1;
                        }
                    }
                }
                switch (lineColor) {
                        case 1: pen1 = redpen1; break;
                        case 2: pen1= lightbluepen1; break;
                        case 5: pen1 = purple1; break;
                        case 6: pen1 = orangepen1; break;
                        case 10: pen1 = bluepen1; break;
                        default: pen1 = new Pen(Color.Red, 2);break;
                    }
                g.DrawLine(pen1, A.location, B.location);
            }
        }

        private void Re_Click(object sender, EventArgs e) {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            G = new GraphList();
            hn.Clear();
            NumToName.Clear();
            Ftmp.Read(G, out hn, out NumToName);
            DrawMap();
        }

        private void delete_Click(object sender, EventArgs e) {
            Form2 fm2;
            fm2 = new Form2(ref G, ref hn, ref NumToName);
            fm2.Show();
        }

        private void shortest_Click(object sender, EventArgs e)
        {
            sourceName = textBox1.Text;
            finalName = textBox2.Text;
            source = (Vertex)G.items[Convert.ToInt32(hn[sourceName])];
            final = (Vertex)G.items[Convert.ToInt32(hn[finalName])];
            G.ShortestPath(source, final, out shortestPath, out shortestDistance, out St);
            textBox3.Clear();
            textBox3.AppendText(shortestPath+"\r\n"+"距离："+shortestDistance);
            DrawGrayBack();
            DrawPath(St);
        }

        private void least_Click(object sender, EventArgs e)
        {
            sourceName = textBox1.Text;
            finalName = textBox2.Text;
            source = (Vertex)G.items[Convert.ToInt32(hn[sourceName])];
            final = (Vertex)G.items[Convert.ToInt32(hn[finalName])];
            G.LeastTransport(source, final, out leastPath, out tranNum, out St);
            textBox3.Clear();
            textBox3.AppendText(leastPath+"\r\n"+"换乘次数："+tranNum);
            DrawGrayBack();
            DrawPath(St);
        }
    }
}
