#pragma once
# include <iostream>
# include <fstream>
using namespace std;
const int INF = 1000000000;

class Adj
{
protected:
	int v;
	double w;
	Adj *next;
public:
	friend class Vertex_List;
	friend class Graph;
};

class Vertex
{
protected:
	int v;
	double d;
	Vertex *pred;
public:
	friend class Graph;
};

class Vertex_List
{
protected:
	Adj *Head;
	Adj *tail;
	Vertex_List *Next;
public:
	friend class Graph;
	Vertex_List()
	{
		Head = NULL;
		tail = NULL;
	}
	void Add_Vertex(int v,double w)
	{
		Adj *x = new Adj;
		x->v = v;
		x->w = w;
		x->next = NULL;
		if (Head == NULL)
		{
			Head = x;
			tail = x;
		}
		else
		{
			tail->next = x;
			tail = x;
		}
	}

	void Delete_Vertex()
	{
		Adj *temp = new Adj;
		temp = Head;
		Head = Head->next;
		delete temp;
		if (Head == NULL)
		{
			tail = NULL;
		}
	}
	~Vertex_List()
	{
		while (Head != NULL)
		{
			Delete_Vertex();
		}
	}
};

class Graph :public Vertex_List
{
protected:
	Vertex_List *graph;
	Vertex *Vert;
	int n;
	Vertex s;
	double Path;
	int Start;

	void Initial_single_sourse()
	{
		for (int i = 0; i < n; i++)
		{
			Vert[i].d = INF;
			Vert[i].pred = NULL;
		}
		Vert[s.v].d = 0;
	}

	void Relax(Adj *v,Vertex &u, double w)
	{
		if (Vert[v->v].d >u.d + w)
		{
			Vert[v->v].d = u.d + w;
			Vert[v->v].pred = &u;
		}
	}

	void Print_Path(Vertex *v,ofstream *out)
	{
		
		if (v->v == s.v)
		{
			cout << s.v ;
			*out << s.v;
		}
		else
		{
			if (v->pred == NULL)
			{
				cout << "���� �� " << s.v << " � " << v->v << " ���\n";
				*out << "���� �� " << s.v << " � " << v->v << " ���\n";
			}
			else
			{
				Print_Path(v->pred,out);
				Path += v->d;
				cout <<"->"<< v->v ;
				*out << "->" << v->v;
			}
		}
	}

	int Bellman_Ford()
	{
		Initial_single_sourse();
		for (int i = 1; i < n; i++)
		{
			for (int j = 0; j < n;j++)
			{
				Adj *Current_Vertex = graph[j].Head;
				while (Current_Vertex!=NULL)
				{
					Relax(Current_Vertex, Vert[j], Current_Vertex->w);
					Current_Vertex = Current_Vertex->next;
				}
			}
		}
		for (int i = 0; i < n; i++)
		{
			Adj *temp_Vertex = graph[i].Head;
			while (temp_Vertex != NULL)
			{
				if (Vert[temp_Vertex->v].d >Vert[i].d +temp_Vertex->w)
				{
					return 0;
				}
				temp_Vertex = temp_Vertex->next;
			}
		}
		return 1;
	}

public:
	~Graph()
	{
		delete[] graph;
	}

	int Graph_Init()
	{
		int v;
		double  w;
		cout << "������� ���������� ������\n";
		if (!(cin >> n))
		{
			return 0;
		}
		Vert = new Vertex[n];
		graph = new Vertex_List[n];
		for (int i = 0; i < n; i++)
		{
			Vert[i].v = i;
			cout << "������� ������ ������� ������ ��� �������" << i << "\n";
			if (!(cin >> v))
			{
				return 0;
			}
			while (v != -1)
			{
				if (!(cin >> w))
				{
					return 0;
				}
				graph[i].Add_Vertex(v, w);
				if (!(cin >> v))
				{
					return 0;
				}
			}
		}
		cout << "�������  ����� ������� ��� ������ ���������� �����\n";
		if (!(cin >> Start))
		{
			return 0;
		}
		s = Vert[Start];
		return 1;
	}

	void PrintGraph()
	{
		for (int i = 0; i < n; i++)
		{
			Adj *curr = graph[i].Head;
			while (curr != NULL)
			{
				cout << curr->v << " " << curr->w << " ";
				curr = curr->next;
			}
			cout << "\n";
		}
	}

	
	void Print_Shortest_Path()
	{
		ofstream out("out.txt", ios_base::app);
		if (!out.is_open())
		{
			cout << "���� �� ����� ���� ������\n";
		}
		else
		{
			if (Bellman_Ford())
			{
				for (int i = 0; i < n; i++)
				{
					cout << "��� ���� �� ������� " << s.v << " � ������� " << Vert[i].v << " ����� " << Vert[i].d << ".����:\n";
					out << "��� ���� �� ������� " << s.v << " � ������� " << Vert[i].v << " ����� " << Vert[i].d << ".����:\n";
					Print_Path(&Vert[i],&out);
					cout << "\n";
					out << "\n";
				}
			}
			else
			{
				cout << "� ������ ����� ��������� ���� �������������� ����\n";
				out << "� ������ ����� ��������� ���� �������������� ����\n";
			}
		}
		out.close();
	}
	int GrafInitFromFile()
	{
		ifstream fin("in.txt",ios_base:: in);
		if (!fin.is_open())
		{
			cout << "���� �� ����� ���� ������\n";
			return 0;
		}
		else
		{
			int v;
			double  w;
			if (!(fin >> n))
			{
				return 0;
			}
			Vert = new Vertex[n];
			graph = new Vertex_List[n];
			for (int i = 0; i < n; i++)
			{
				Vert[i].v = i;
				if (!(fin>>v))
				{
					return 0;
				}
				while (v != -1)
				{
					if (!(fin >> w))
					{
						return 0;
					}
					graph[i].Add_Vertex(v, w);
					if (!(fin >> v))
					{
						return 0;
					}
				}
			}
			if (!(fin >> Start))
			{
				return 0;
			}
			s = Vert[Start];
			return 1;
		}
		fin.close();
	}
};
