using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace SubwayApplicationtest
{
    //站点类
    public class Vertex
    {
        public string name;                 //名字
        public int vno;                     //站点编号
        public Node firstEdge;              //邻接点链表头指针
        public Boolean isTran;              //是否是换乘站
        public Point location;                     //站点坐标
        public ArrayList lineNo = new ArrayList();            //所在几号线
        //待添加信息，是否是换乘站，所在线路等
        public Boolean visited;             //访问标志,遍历时使用
        public Vertex(string value, int num, Boolean i, int a,int x,int y)
        {          //构造方法
            name = value;
            vno = num;
            visited = false;
            isTran = i;
            lineNo.Add(a);
            location = new Point(x, y);
        }
    }
}
