package sample;

import java.util.ArrayList;
import java.util.Stack;

/**
 * Created by админъ on 28.11.2016.
 */
public class Graph {
    private int order;
    int[][] adjMatrix;

    public Graph(int order, int[][] matrix) {
        this.order = order;
        adjMatrix = matrix;
    }

    private ArrayList<ArrayList<Integer>> bronKerboshClique() {
        ArrayList<Integer> candidates = new ArrayList<Integer>(), not = new ArrayList<Integer>(), compsub = new ArrayList<Integer>();
        ArrayList<ArrayList<Integer>> Clicues = new ArrayList<ArrayList<Integer>>();
        for (int i = 0; i < order; i++) {
            candidates.add(i);
        }
        int v = 0;
        Stack<Integer> stack1 = new Stack<Integer>();
        Stack<ArrayList<Integer>> stack2 = new Stack<ArrayList<Integer>>();

        while (candidates.size() != 0 || compsub.size() != 0) {
            if ((candidates.size() != 0)) {
                v = candidates.get(0);
                ArrayList<Integer> tempCompsub = new ArrayList<Integer>(compsub);
                ArrayList<Integer> tempCandidates = new ArrayList<Integer>(candidates);
                ArrayList<Integer> tempNot = new ArrayList<Integer>(not);
                stack2.push(tempCompsub);
                stack2.push(tempCandidates);
                stack2.push(tempNot);
                stack1.push(v);
                compsub.add(v);
                for (int i = 0; i < order; i++) {
                    if (adjMatrix[v][i] == 0) {
                        candidates.remove((Integer) i);
                        not.remove((Integer) i);
                    }
                }
                candidates.remove((Integer) v);
            } else {
                if (not.size() == 0) {
                    Clicues.add(compsub);
                }
                v = stack1.pop();
                not = stack2.pop();
                candidates = stack2.pop();
                compsub = stack2.pop();
                candidates.remove((Integer) v);
                not.add(v);
            }
        }
        return Clicues;
    }

    private ArrayList<Integer> maxClique(ArrayList<ArrayList<Integer>> cliques)
    {
        ArrayList<Integer> maxClique=new ArrayList<Integer>();
        for(int i=0;i<cliques.size();i++)
        {
            if(maxClique.size()<cliques.get(i).size())
            {
                maxClique=cliques.get(i);
            }
        }
        return maxClique;
    }

    public String outputMaxClique()
    {
        String s="";
        ArrayList<ArrayList<Integer>>cliques=bronKerboshClique();
        if(cliques.size()==0)
        {
            s+="В данном графе нет клик\n";
        }
        else {
            for (int i = 0; i < cliques.size(); i++) {
                s += "Максимальная клика № " + i + ":" + "{";
                for (int j = 0; j < cliques.get(i).size(); j++) {
                    s += cliques.get(i).get(j) + ", ";
                }
                s += "}\n";
            }
            ArrayList<Integer> maxClique = maxClique(cliques);
            s += "Наибольшая клика:";
            s += "{";
            for (int i = 0; i < maxClique.size(); i++) {
                s += maxClique.get(i) + ", ";
            }
            s += "}";
        }
        return s;
    }

    private ArrayList<ArrayList<Integer>> bronKerboshIndependentSet() {
        ArrayList<Integer> candidates = new ArrayList<Integer>(), not = new ArrayList<Integer>(), compsub = new ArrayList<Integer>();
        ArrayList<ArrayList<Integer>> IndependentSets = new ArrayList<ArrayList<Integer>>();
        for (int i = 0; i < order; i++) {
            candidates.add(i);
        }
        int v = 0;
        Stack<Integer> stack1 = new Stack<Integer>();
        Stack<ArrayList<Integer>> stack2 = new Stack<ArrayList<Integer>>();

        while (candidates.size() != 0 || compsub.size() != 0) {
            if ((candidates.size() != 0)) {
                v = candidates.get(0);
                ArrayList<Integer> tempCompsub = new ArrayList<Integer>(compsub);
                ArrayList<Integer> tempCandidates = new ArrayList<Integer>(candidates);
                ArrayList<Integer> tempNot = new ArrayList<Integer>(not);
                stack2.push(tempCompsub);
                stack2.push(tempCandidates);
                stack2.push(tempNot);
                stack1.push(v);
                compsub.add(v);
                for (int i = 0; i < order; i++) {
                    if (adjMatrix[v][i] == 1) {
                        candidates.remove((Integer) i);
                        not.remove((Integer) i);
                    }
                }
                candidates.remove((Integer) v);
            } else {
                if (not.size() == 0) {
                    IndependentSets.add(compsub);
                }
                v = stack1.pop();
                not = stack2.pop();
                candidates = stack2.pop();
                compsub = stack2.pop();
                candidates.remove((Integer) v);
                not.add(v);
            }
        }
        return IndependentSets;
    }

    public String outputMaxIndependedSet()
    {
        String s="";
        ArrayList<ArrayList<Integer>>independedSets=bronKerboshIndependentSet();
        for(int i=0;i<independedSets.size();i++)
        {
            s+="Максимальное независимое множество № "+i+":"+"{";
            for(int j=0;j<independedSets.get(i).size();j++)
            {
                s+=independedSets.get(i).get(j)+", ";
            }
            s+="}\n";
        }
        ArrayList<Integer> maxIndependedSet=maxClique(independedSets);
        s+="Наибольшее независимое множество:";
        s+= "{";
        for(int i=0;i<maxIndependedSet.size();i++)
        {
            s+= maxIndependedSet.get(i)+", ";
        }
        s+="}";
        return s;
    }

    public String printGraph()
    {
        String s="";
        for(int i=0;i<order;i++)
        {
            for(int j=0;j<order;j++)
            {
                s+=adjMatrix[i][j]+" ";
            }
            s+="\n";
        }
        return s;
    }

    public String printVertexCover()
    {
        ArrayList<edge> VertCover=vertexCover();

        String s="";
        if(VertCover.size()==0)
        {
            s+="Минимальное вершинное покрытие равно пустому множеству";
        }
        else {
            s += "Минимальное вершинное покрытие: {";
            for (int i = 0; i < VertCover.size(); i++) {
                s += VertCover.get(i).getU() + ", " + VertCover.get(i).getV() + ", ";
            }

            s += "}\n";
        }
        return s;
    }

    private ArrayList<edge> vertexCover()
    {
        ArrayList<edge> cover=new ArrayList<edge>();
        ArrayList<edge>E=new ArrayList<edge>();
        for(int i=0;i<order;i++)
        {
            for(int j=0;j<order;j++)
            {
                if(adjMatrix[i][j]==1)
                {
                    E.add(new edge(i,j));
                }
            }
        }
        while(E.size()!=0)
        {
            edge e=E.get(0);
            cover.add(e);
            for(int i=0;i<E.size();i++)
            {
                if(e.getU()==E.get(i).getU()||e.getU()==E.get(i).getV()||e.getV()==E.get(i).getU()||e.getV()==E.get(i).getV())
                {
                    E.remove(i);
                    i--;
                }
            }
        }
        return cover;
    }

}
