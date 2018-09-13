using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SubwayApplicationtest
{
    //邻接表类
    public class GraphList
    {
        public ArrayList items = new ArrayList();                  //站点集合的动态数组
        public void AddVertex(Vertex item)
        {                       //添加一个顶点     //不允许插入重复值
            if (items.Contains(item))
            {
                throw new ArgumentException("插入了重复顶点！");
            }
            else
            {
                items.Add(item);
            }
        }
        //添加有向边
        private void AddDirectedEdge(Vertex fromVer, Vertex toVer, int weight)
        {
            if (items.Contains(fromVer) && items.Contains(toVer))
            {
                if (fromVer.firstEdge == null)                  //无邻接点时
                {
                    fromVer.firstEdge = new Node(toVer, weight);
                }
                else
                {
                    Node tmp, node = fromVer.firstEdge;
                    do
                    {                                        //检查是否添加了重复边
                        if (node.adjvex.name.Equals(toVer.name))
                        {
                            Console.WriteLine(fromVer.name);
                            Console.WriteLine(toVer.name);
                            throw new ArgumentException("添加了重复的边!");
                        }
                        tmp = node;
                        node = node.next;
                    } while (node != null);
                    tmp.next = new Node(toVer, weight);                 //添加到链表未尾
                }
            }
            else
                throw new ArgumentException("头或尾顶点不存在");
        }
        //添加无向边
        public void AddEdge(Vertex fromVer, Vertex toVer, int weight)
        {
            //无向边的两个顶点都需记录边信息
            AddDirectedEdge(fromVer, toVer, weight);
            AddDirectedEdge(toVer, fromVer, weight);
        }


        //仅用于测试，打印每个节点和它的邻接点
        public override string ToString()
        {
            string s = string.Empty;
            foreach (Vertex v in items)
            {
                s += v.name.ToString() + ":";
                if (v.firstEdge != null)
                {
                    Node tmp = v.firstEdge;
                    while (tmp != null)
                    {
                        s = s + "-->" + tmp.adjvex.name.ToString();
                        tmp = tmp.next;
                    }
                }
                s += "\r\n";
            }
            return s;
        }
        //dijkstra算法，最短路径,返回动态数组，内部存储路径信息。
        public void ShortestPath(Vertex source, Vertex final, out string finalPath, out int finalDistance,out ArrayList St)
        {
            ArrayList PathStationNo = new ArrayList();
            int a = source.vno;                              //起始站点编号
            int[] path = new int[items.Count];            //站点编号数组，角标为对应站点，内部指为前置站点编号
            int[] distance = new int[items.Count];        //到各点最短路径的权值和
            bool[] finish = new bool[items.Count];        //用来表示起始点a到某点最短路径是否求得
            int i, v, w, min;
            int INF = 100000000;
            //初始化数据
            for (i = 0; i < items.Count; i++)
            {
                //前驱站点默认为源点
                path[i] = a;
                //与源点最短路径赋值，不存在直接相连则无穷大
                if (source.firstEdge == null)
                {                 //检测是否存在后继站点   
                    distance[i] = INF;
                }
                else
                {
                    Node tmp, node = source.firstEdge;
                    do
                    {
                        if (node.adjvex.vno.Equals(i))
                        {        //是否是源点到i点
                            distance[i] = node.weight;
                            break;                              //找到并退出
                        }
                        else
                            distance[i] = INF;                  //不符合条件付最大值，直到循环结束
                        tmp = node;
                        node = node.next;
                    } while (node != null);
                }
                //全部做最短路径为未求得
                finish[i] = false;
            }
            distance[a] = 0;
            finish[a] = true;
            v = a;
            //主循环，每次求得源点到v顶点的最短路径，并标记v完成求解
            for (i = 0; i < items.Count; i++)
            {
                if (i == a) continue;
                min = INF;
                for (w = 0; w < items.Count; w++)
                {
                    if (!finish[w] && distance[w] < min)
                    {
                        min = distance[w];
                        v = w;
                    }
                }
                finish[v] = true;
                //更新
                for (w = 0; w < items.Count; w++)
                {
                    int xxx;
                    if (((Vertex)items[v]).firstEdge == null)
                    {                 //检测是否存在后继站点 
                        xxx = INF;
                    }
                    else
                    {
                        Node Ttmp, Tnode = ((Vertex)items[v]).firstEdge;
                        do
                        {
                            if (Tnode.adjvex.vno.Equals(w))
                            {        //是否是v到w点
                                xxx = Tnode.weight;
                                break;                              //找到并退出
                            }
                            else
                                xxx = INF;                          //不符合条件付最大值，直到循环结束
                            Ttmp = Tnode;
                            Tnode = Tnode.next;
                        } while (Tnode != null);
                    }
                    //Console.WriteLine(xxx);
                    if (min + xxx < distance[w])
                    {
                        distance[w] = min + xxx;
                        path[w] = v;
                    }
                }
            }
            //将path数组转换成finalPath字符串
            int stmp = source.vno;
            int ftmp = final.vno;
            int prev = ftmp;
            finalPath = final.name;
            while (prev != stmp)
            {
                prev = path[prev];
                finalPath = ((Vertex)items[prev]).name + "-->" + finalPath;
            }
            prev = final.vno;
            PathStationNo.Add(prev);
            while (prev != stmp) {
                prev = path[prev];
                PathStationNo.Add(prev);         
            }
            St = PathStationNo;
            //最短路径赋值传回
            finalDistance = distance[ftmp];
        }
        //最少换乘
        public void LeastTransport(Vertex source, Vertex final, out string finalPath, out int tranNum, out ArrayList St) {
            ArrayList PathStationNo = new ArrayList();
            int a = source.vno;                           //起始站点编号
            int[] path = new int[items.Count];            //站点编号数组，角标为对应站点，内部指为前置站点编号
            int[] distance = new int[items.Count];        //到各点路径的权值和
            int[] tranN = new int[items.Count];           //到达对应站点的换乘次数，初始为INF
            bool[] finish = new bool[items.Count];        //用来表示起始点a到某点最短路径是否求得
            int i, v, w, min;
            int preline = 0;
            int nextline = 0;
            int INF = 100000000;
            //初始化数据
            for (i = 0; i < items.Count; i++) {
                //前驱站点默认为源点
                path[i] = a;
                //与源点最短路径赋值，不存在直接相连则无穷大
                if (source.firstEdge == null) {                 //检测是否存在后继站点   
                    distance[i] = INF;
                    tranN[i] = INF;
                }
                else {
                    Node tmp, node = source.firstEdge;
                    do {
                        if (node.adjvex.vno.Equals(i)) {
                            //是否是源点到i点
                            distance[i] = node.weight;
                            tranN[i] = 0;
                            break;                              //找到并退出
                        }
                        else {
                            distance[i] = INF;                  //不符合条件付最大值，直到循环结束
                            tranN[i] = INF;
                        }
                        tmp = node;
                        node = node.next;
                    } while (node != null);
                }
                //全部做最少换乘路径未求得
                finish[i] = false;
            }
            distance[a] = 0;
            tranN[a] = 0;
            finish[a] = true;
            v = a;
            //主循环，每次求得源点到v顶点的最短路径，并标记v完成求解
            for (i = 0; i < items.Count; i++) {
                if (i == a) continue;
                min = INF;
                for (w = 0; w < items.Count; w++) {
                    if (!finish[w] && distance[w] < min) {   //从未访问过得，距离呢最近的点开始访问
                        min = distance[w];
                        v = w;
                    }
                }
                finish[v] = true;
                //更新
                for (w = 0; w < items.Count; w++) {
                    int xxx;
                    int yyy;
                    if (((Vertex)items[v]).firstEdge == null) {                 //检测是否存在后继站点 
                        xxx = INF;
                        yyy = INF;
                    }
                    else {
                        Node Ttmp, Tnode = ((Vertex)items[v]).firstEdge;
                        do {
                            if (Tnode.adjvex.vno.Equals(w)) {        //是否是v到w点
                                xxx = Tnode.weight;
                                foreach (int element1 in ((Vertex)items[path[v]]).lineNo) {
                                    foreach (int element2 in ((Vertex)items[v]).lineNo) {
                                        if (element1 == element2) {
                                            preline = element1;
                                        }
                                    }
                                }
                                foreach (int element1 in ((Vertex)items[v]).lineNo) {
                                    foreach (int element2 in ((Vertex)items[w]).lineNo) {
                                        if (element1 == element2) {
                                            nextline = element1;
                                        }
                                    }
                                }
                                if (preline == nextline) {
                                    yyy = 0;
                                }
                                else {
                                    yyy = 1;
                                }
                                break;                              //找到并退出
                            }
                            else {
                                xxx = INF;                          //不符合条件付最大值，直到循环结束
                                yyy = INF;
                            }
                            Ttmp = Tnode;
                            Tnode = Tnode.next;
                        } while (Tnode != null);
                    }
                    //Console.WriteLine(xxx);
                    //是否更新前驱结点
                    if (tranN[v] + yyy < tranN[w]) {
                        distance[w] = min + xxx;
                        tranN[w] = tranN[v] + yyy;
                        path[w] = v;
                    }
                    else if (tranN[v] + yyy == tranN[w]) {
                        if (min + xxx < distance[w]) {
                            distance[w] = min + xxx;
                            tranN[w] = tranN[v] + yyy;
                            path[w] = v;
                        }
                    }
                    else if (tranN[v] + yyy > tranN[w]) {
                        continue;
                    }
                }
            }
            //将path数组转换成finalPath字符串
            int stmp = source.vno;
            int ftmp = final.vno;
            int prev = ftmp;
            finalPath = final.name;
            while (prev != stmp) {
                prev = path[prev];
                finalPath = ((Vertex)items[prev]).name + "-->" + finalPath;
            }
            prev = final.vno;
            PathStationNo.Add(prev);
            while (prev != stmp) {
                prev = path[prev];
                PathStationNo.Add(prev);
            }
            St = PathStationNo;
            //最短路径赋值传回
            tranNum = tranN[ftmp];
        }
    }
}
