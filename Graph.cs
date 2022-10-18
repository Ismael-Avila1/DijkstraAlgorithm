using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithm
{
    internal class Graph
    {
        List<Vertex> vertices;

        public Graph()
        {
            vertices = new List<Vertex>();
        }

       public void addVertex(int x, int y)
        {
            vertices.Add(new Vertex(vertices.Count+1, new Point(x, y)));
        }

        public int VertexCount
        {
            get { return vertices.Count; }
        }

        public List<Vertex> Vertices
        {
            get { return vertices; }
        }

        public int getIndex(Vertex v)
        {
            for(int i = 0; i < VertexCount; i++)
                if(vertices[i] == v)
                    return i;
            return -1;
        }



        // ************* Kruskal *************
        public List<Edge> kruskal()
        {
            List<Edge> candidates = getCandidates();
            List<Edge> promising = new List<Edge>();

            Edge e_i;
            int index1, index2;

            int[,] CC = ccInitialize();

            while(candidates.Count != 0) {
                e_i = selection(candidates);

                index1 = findInCC(CC, e_i.Origin);
                index2 = findInCC(CC, e_i.Destination);

                if(index1 != index2) {
                    combineCC(CC, index1, index2);
                    promising.Add(e_i);
                }
            }

            return promising;
        }

        List<Edge> getCandidates()
        {
            List<Edge> edges = new List<Edge>();

            foreach(Vertex v in vertices)
                foreach(Edge e in v.Edges)
                    edges.Add(e);
            
            return edges;
        }

        int[,] ccInitialize()
        {
            int[,] cc = new int[VertexCount, VertexCount];

            for(int i=0; i<VertexCount; i++)
                for(int j=0; j<VertexCount; j++)
                    cc[i, j] = -1;
            
            for(int i=0; i<VertexCount; i++)
                cc[i, i] = vertices[i].Id;

            return cc;
        }

        Edge selection(List<Edge> candidates)
        {
            Edge candidate; 
            int minorIndex = 0;

            for(int i=0; i<candidates.Count; i++)
                if(candidates[i].Weight < candidates[minorIndex].Weight)
                    minorIndex = i;
            
            candidate = candidates[minorIndex];
            candidates.RemoveAt(minorIndex);
            return candidate;
        }

        int findInCC(int[,] CC, Vertex v_d)
        {
            for (int i = 0; i < VertexCount; i++)
                for (int j = 0; j < VertexCount; j++)
                    if (CC[i, j] == v_d.Id)
                        return i;
            return -1;
        }

        void combineCC(int[,] CC, int index1, int index2)
        {
            for(int i=0; i<VertexCount; i++)
                if(CC[index2, i] != -1) {
                    CC[index1, i] = CC[index2, i];
                    CC[index2, i] = -1;
                }
        }



        // ************* Dijkstra *************

        public List<DijkstraElement> dijkstra(int origin)
        {
            List<DijkstraElement> VD = initializeDijkstraVector(origin);
            int minorIndex;

            while(!solution(VD)) {
                minorIndex = select(VD);

                if(minorIndex == -1)
                    continue;

                updateDijkstraElements(VD, minorIndex);
            }

            return VD;
        }

        List<DijkstraElement> initializeDijkstraVector(int origin)
        {
            List<DijkstraElement> VD = new List<DijkstraElement>();

            for (int i = 0; i < VertexCount; i++)
                VD.Add(new DijkstraElement(false, float.MaxValue, null, vertices[i]));

            VD[origin].AccumulatedWeight = 0;

            return VD;
        }

        bool solution(List<DijkstraElement> VD)
        {
            for(int i=0; i<VD.Count; i++)
                if(!VD[i].Definitive)
                    return false;
            return true;
        }

        int select(List<DijkstraElement> VD)
        {
            int minorIndex = -1;
            float minor = float.MaxValue;

            for(int i=0; i<VD.Count; i++)
                if(!VD[i].Definitive)
                    if(VD[i].AccumulatedWeight < minor) {
                        minor = VD[i].AccumulatedWeight;
                        minorIndex = i;
                    }
            if(minorIndex == -1) {
                for(int i=0; i<VD.Count; i++)
                    if(VD[i].AccumulatedWeight == float.MaxValue) {
                        VD.RemoveAt(i);
                        return -1;
                    }
            }

            VD[minorIndex].Definitive = true;
            return minorIndex;
        }

        void updateDijkstraElements(List<DijkstraElement> VD, int minorIndex)
        {
            float weight_i, actualWeight = VD[minorIndex].AccumulatedWeight;
            Vertex v_d, v = vertices[minorIndex];

            for(int i=0; i<v.Edges.Count; i++) {
                weight_i = actualWeight + v.Edges[i].Weight;
                v_d = v.Edges[i].Destination;

                if(VD[v_d.Id - 1].AccumulatedWeight > weight_i) {
                    VD[v_d.Id - 1].AccumulatedWeight = weight_i;
                    VD[v_d.Id - 1].ComimgFrom = v;
                }
            }
        }


    }
}
