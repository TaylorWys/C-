using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubwayApplicationtest
{
    //邻接结点
    public class Node
    {
        public Vertex adjvex;               //邻接点域
        public int weight;                  //权重
        public Node next;                   //下一个邻接点指针域
        public Node(Vertex value, int w)
        {
            adjvex = value;
            weight = w;
        }
    }
}
