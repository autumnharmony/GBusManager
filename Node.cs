﻿
using System;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Forms;

namespace GBusManager
{
	
	public struct AdjNode {
		public Node node;
		public int route;

        
		
		
		Graph graph;
		
		// струкутра предназначенная для хранения
		// пары соседний узел - номер маршрута
		public AdjNode(Graph g, int nn, int rn){
			graph = g;
			node = g.Node(nn);
			route = rn;
		}
		
		public override string ToString()
		{
			return "node "+ node.n + " ["+route+"]";
		}
	}

	/// <summary>
	/// Description of Node.
	/// </summary>
	public class Node
	{
		#region fields
		
		// номер узла
		public int n;
		
		// минимальный автобусный маршрут
		public int r = -1;
		
		// длина минимального пути
		public int len = int.MaxValue / 2;

        public int prevn;
		
		Graph graph;

        public Point point;

		#endregion
		
		int X;
		int Y;

        public Node prev;

		Label label;
		
		public ArrayList neighbors = new ArrayList();
		
		// пары соседняя остановка - номер маршрута последнего участка перед ней
		// neighbors[i] - соседний узел
		// nr[i] 		- автобусный маршрут в этот узел
		//ArrayList neighbors;
		
		//public Edge[] edges;
		
		// посещена
		public bool v;
		
		
		public Node(Graph g, int bn,Point p)
		{
			graph = g;
			n = bn;
            len = int.MaxValue;
            point = p;
		}
		
		public Node(int bn, Label l, int x, int y)
		{
			//graph = g;
			n = bn;
			X = x;
			Y = y;
			label = l;
            len = int.MaxValue;
		}
		
		public Node(){
            len = int.MaxValue;
		}
		
		// добавление смежного
		public void AddAdj(int n, int r){
			neighbors.Add(new AdjNode(graph,n,r));
		}
		
		private string AdjNodesToString(){
            //throw new NotImplementedException();
			string s = "";
			foreach (AdjNode an in neighbors){
				//s+=""+an.node+"["+an.route+"]\n";
			}
			return s;
		}

        public Node Neighbor(int r, int d)
        {
            // r - route
            // d - direction

            return graph.Node(graph.routes[r].Near(n, d));
        }
		
		public override string ToString()
		{
			return n+"";
			//return n.ToString()+ "["+AdjNodesToString()+"]";
		}
	}
}
