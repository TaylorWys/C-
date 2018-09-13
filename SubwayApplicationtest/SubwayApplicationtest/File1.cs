using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace SubwayApplicationtest
{
    public class File1
    {
        public void Read(GraphList G, out Hashtable HN, out Hashtable NTN)
        {
            //station_name文件读取
            StreamReader nr = new StreamReader("data/station_line_easy.txt", Encoding.GetEncoding("gb2312"));
            string[] splitName;                                                          
            Hashtable hn = new Hashtable();
            Hashtable NumToName = new Hashtable();    //与上一个哈希表相反；
            int num = 0;                         //哈希表value值，动态数组对应下标
            string sValue;                     //站名
            int lineNo = 0;
            Vertex tmp;
            while ((sValue = nr.ReadLine()) != null)
            {          //Vertex类创建
                switch (sValue)
                {
                    case "1号线": lineNo = 1; continue;
                    case "2号线": lineNo = 2; continue;
                    case "4号线": lineNo = 4; continue;
                    case "5号线": lineNo = 5; continue;
                    case "6号线": lineNo = 6; continue;
                    case "7号线": lineNo = 7; continue;
                    case "8号线": lineNo = 8; continue;
                    case "9号线": lineNo = 9; continue;
                    case "10号线": lineNo = 10; continue;
                    case "13号线": lineNo = 13; continue;
                    case "14号线西段": lineNo = 141; continue;
                    case "14号线东段": lineNo = 142; continue;
                    case "15号线": lineNo = 15; continue;
                    case "八通线": lineNo = 30; continue;
                    case "昌平线": lineNo = 31; continue;
                    case "亦庄线": lineNo = 32; continue;
                    case "房山线": lineNo = 33; continue;
                    default:
                        break;
                }
                splitName = sValue.Split(' ');
                if (!hn.ContainsKey(splitName[0]))
                {
                    hn.Add(splitName[0], num);
                    NumToName.Add(num, splitName[0]);
                    tmp = new Vertex(splitName[0], num, false, lineNo, Convert.ToInt32(splitName[1]), Convert.ToInt32(splitName[2]));
                    G.items.Add(tmp);
                    num++;
                }
                else
                {
                    int i = Convert.ToInt32(hn[splitName[0]]);
                    ((Vertex)G.items[i]).lineNo.Add(lineNo);
                }

            }
            nr.Close();
            //subway_data文件读取
            StreamReader er = new StreamReader("data/subway_data_easy.txt", Encoding.GetEncoding("gb2312"));
            string rLine;
            int fromTmp, toTmp;
            string[] splitArrary;                                                            //储存按行读取,分割后数值
            int weightTmp;
            while ((rLine = er.ReadLine()) != null)
            {
                switch (rLine) {
                    case "1号线": continue;
                    case "2号线": continue;
                    case "5号线": continue;
                    case "6号线": continue;
                    case "10号线": continue;
                    default:
                        break;
                }
                splitArrary = rLine.Split(' ');
                weightTmp = Convert.ToInt32(splitArrary[2]);
                if (hn.ContainsKey(splitArrary[0]) && hn.ContainsKey(splitArrary[1]))
                {      //检测两个站点是否创建
                    fromTmp = Convert.ToInt32(hn[splitArrary[0]]);
                    toTmp = Convert.ToInt32(hn[splitArrary[1]]);
                    G.AddEdge((Vertex)G.items[fromTmp], (Vertex)G.items[toTmp], weightTmp);
                }
            }
            er.Close();
            //subway_transport文件读取
            StreamReader tr = new StreamReader("data/subway_transport.txt", Encoding.GetEncoding("gb2312"));
            string tranName;
            while ((tranName = tr.ReadLine()) != null)
            {
                foreach (Vertex i in G.items)
                {
                    if (tranName == i.name)
                    {
                        i.isTran = true;
                    }
                }
            }
            tr.Close();
            HN = hn;
            NTN = NumToName;
        }
    }
}
