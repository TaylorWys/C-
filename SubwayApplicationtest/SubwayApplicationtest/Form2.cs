using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SubwayApplicationtest {
    public partial class Form2 : Form {
        public GraphList T =new GraphList();
        public Hashtable NM = new Hashtable();
        public Hashtable NumtoName = new Hashtable();

        public Form2(ref GraphList i,ref Hashtable j, ref Hashtable k) {
            InitializeComponent();
            T = i;
            NM = j;
            NumtoName = k;
        }

        private void del_Click(object sender, EventArgs e) {
            string delname = nameBox.Text;
            string[] splitArrary;
            //删除边文件中的相关数据
            List<string> lines = new List<string>(File.ReadAllLines("data/subway_data_easy.txt", Encoding.GetEncoding("gb2312")));
            for(int i = lines.Count-1; i >= 0; i--) {
                switch (lines[i]) {
                    case "1号线": continue;
                    case "2号线": continue;
                    case "5号线": continue;
                    case "6号线": continue;
                    case "10号线": continue;
                    default:
                        break;
                }
                splitArrary = lines[i].Split(' ');
                if(splitArrary[0]==delname || splitArrary[1] == delname) {
                            lines.RemoveAt(i);
                        }
                else {
                            continue;
                        }
            }
            File.WriteAllLines("data/subway_data_easy.txt", lines.ToArray(), Encoding.GetEncoding("gb2312"));
            //删除站点数据
            List<string> ltmp = new List<string>(File.ReadAllLines("data/station_line_easy.txt", Encoding.GetEncoding("gb2312")));
            for (int v = ltmp.Count - 1; v >= 0; v--) {
                switch (ltmp[v]) {
                    case "1号线": continue;
                    case "2号线": continue;
                    case "5号线": continue;
                    case "6号线": continue;
                    case "10号线": continue;
                    default:
                        break;
                }
                splitArrary = ltmp[v].Split(' ');
                if (splitArrary[0] == delname || splitArrary[1] == delname) {
                    ltmp.RemoveAt(v);
                }
                else {
                    continue;
                }
            }
            File.WriteAllLines("data/station_line_easy.txt", ltmp.ToArray(), Encoding.GetEncoding("gb2312"));           
        }

        private void delEdge_Click(object sender, EventArgs e) {
            string st1 = delE1.Text;
            string st2 = delE2.Text;
            string[] splitArrary;
            //删除边文件中的相关数据
            List<string> lines = new List<string>(File.ReadAllLines("data/subway_data_easy.txt", Encoding.GetEncoding("gb2312")));
            for (int i = lines.Count - 1; i >= 0; i--) {
                switch (lines[i]) {
                    case "1号线": continue;
                    case "2号线": continue;
                    case "5号线": continue;
                    case "6号线": continue;
                    case "10号线": continue;
                    default:
                        break;
                }
                splitArrary = lines[i].Split(' ');
                if ((splitArrary[0] == st1 && splitArrary[1] == st2) || (splitArrary[1] == st1 && splitArrary[0] == st2)) {
                    lines.RemoveAt(i);
                }
                else {
                    continue;
                }
            }
            File.WriteAllLines("data/subway_data_easy.txt", lines.ToArray(), Encoding.GetEncoding("gb2312"));
        }

        private void AddSt_Click(object sender, EventArgs e) {
            string stname = AddName.Text;
            string stline = AddlineNo.Text;
            string stX = PointX.Text;
            string stY = PointY.Text;
            int i=0;
            string insert = stname + ' ' + stX + ' ' + stY;
            List<string> ltmp = new List<string>(File.ReadAllLines("data/station_line_easy.txt", Encoding.GetEncoding("gb2312")));
            //添加到指定位置
            for (int v = 0; v <ltmp.Count; v++) {
                if (ltmp[v]==stline) {
                    i = v + 1;
                    ltmp.Insert(i, insert);
                }
                else {
                    continue;
                }
                //
            }
            File.WriteAllLines("data/station_line_easy.txt", ltmp.ToArray(), Encoding.GetEncoding("gb2312"));
        }

        private void AddEdge_Click(object sender, EventArgs e) {
            string stline = AddlineNo.Text;
            string s1 = AddE1.Text;
            string s2 = AddE2.Text;
            string w = AddWeight.Text;
            string insert = s1 + ' ' + s2 + ' ' + w;
            int i = 0;
            string[] splitArrary;
            List<string> lines = new List<string>(File.ReadAllLines("data/subway_data_easy.txt", Encoding.GetEncoding("gb2312")));
            //检测是否已存在
            for (int v = 0; v < lines.Count; v++) {
                switch (lines[v]) {
                    case "1号线": continue;
                    case "2号线": continue;
                    case "5号线": continue;
                    case "6号线": continue;
                    case "10号线": continue;
                    default:
                        break;
                }
                splitArrary = lines[v].Split(' ');
                if ((splitArrary[0] == s1 && splitArrary[1] == s2) || (splitArrary[1] == s1 && splitArrary[0] == s2)) {
                    MessageBox.Show("添加了重复边");
                    return;
                }
                else {
                    continue;
                }
            }
            //指定位置添加
            for (int v = 0; v < lines.Count; v++) {
                if (lines[v] == stline) {
                    i = v + 1;
                    lines.Insert(i, insert);
                }
                else {
                    continue;
                }
                //
            }
            File.WriteAllLines("data/subway_data_easy.txt", lines.ToArray(), Encoding.GetEncoding("gb2312"));
        }

    }
}
