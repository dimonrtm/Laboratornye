/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lab2var;

/**
 *
 * @author админъ
 */
public class Matrix {
   private int M;
   private int N;
   private int[][] matrix;
   
   public Matrix()
   {
       M=1;
       N=1;
       matrix=new int [M][N];
   }
   
   public Matrix(int _m,int _n,int[][] _matrix)
   {
       M=_m;
       N=_n;
       matrix=_matrix;
   }
   
   public void OutputMatrix()
   {
       for(int i=0;i<M;i++)
       {
         for(int j=0;j<N;j++)
         {
             System.out.print(matrix[i][j]+" ");
         }
         System.out.println();
       }
   }
   
   public int determinant()
   {
        int sum=0;
        
       if(this.M!=this.N)
       {
           System.out.println("Матрица не квадратная.");
           return 0;
       }
       if(this.M==1)
       {
           return this.matrix[0][0];
       }
       if(this.M==2)
       {
           int det=this.matrix[0][0]*this.matrix[1][1]-this.matrix[1][0]*this.matrix[0][1];
           return det;
       }
       if(this.M>2)
       {
          
           int k=0;
           for(int i=0;i<this.M;i++)
           {
             int[][] temp=new int[this.M-1][this.M-1];
             for(int j=0;j<this.M;j++)
             {
                 int result1,result2;
                 if(k<j)
                 {
                   result1=j-1; 
                 }
                 else
                 {
                     result1=j;
                 }
                 for(int m=0;m<this.M;m++)
                 {
                     if(i<m)
                     {
                         result2=m-1;
                     }
                     else
                     {
                         result2=m;
                     }
                        if(j!=k&&m!=i)
                        {
                            temp[result1][result2]=this.matrix[j][m];
                        }
                 }
             }
             Matrix minor= new Matrix(this.M-1,this.M-1,temp);
             sum+=(int)(Math.pow((double)-1,(double)i)*this.matrix[k][i]*minor.determinant());
           }
       }
       return sum;
   }
   
   public Matrix Multiply(Matrix _matrix1)
   {
       if(this.N!=_matrix1.M)
       {
           System.out.println("Эти матрицы нельзя умножать.");
           return new Matrix();
       }
      int[][] c=new int[_matrix1.M][_matrix1.N];
      for(int i=0;i<_matrix1.M;i++)
      {
          for(int j=0;j<_matrix1.N;j++)
          {
              int sum=0;
             for(int k=0;k<_matrix1.M;k++)
             {
                 sum+=this.matrix[i][k]*_matrix1.matrix[k][j];
             }
             c[i][j]=sum;
          }
      }
      Matrix C=new Matrix(_matrix1.M,_matrix1.N,c);
      return C;
   }
   
   public Matrix Summary(Matrix _matrix1)
   {
       if(this.M!=_matrix1.M&&this.N!=_matrix1.N)
       {
           System.out.println("Эти матрицы нельзя складывать");
           return new Matrix();
       }
       int[][] c=new int[this.M][this.N];
       for(int i=0;i<this.M;i++)
       {
           for(int j=0;j<this.N;j++)
           {
               c[i][j]=this.matrix[i][j]+_matrix1.matrix[i][j];
           }
       }
       Matrix C=new Matrix(this.M,this.N,c);
       return C;
   }
   
   public Matrix Substract(Matrix _matrix1)
   {
       if(this.M!=_matrix1.M&&this.N!=_matrix1.N)
       {
           System.out.println("Эти матрицы нельзя вычитать");
           return new Matrix();
       }
       int[][] c=new int[this.M][this.N];
       for(int i=0;i<this.M;i++)
       {
           for(int j=0;j<this.N;j++)
           {
               c[i][j]=this.matrix[i][j]-_matrix1.matrix[i][j];
           }
       }
       Matrix C=new Matrix(this.M,this.N,c);
       return C; 
   }
   
   public Matrix MultiplyNumber(int _number)
   {
       int c[][]=new int[this.M][this.N];
       for(int i=0;i<this.M;i++)
       {
           for(int j=0;j<this.N;j++)
           {
               c[i][j]=this.matrix[i][j]*_number;
           }
       }
       Matrix C=new Matrix(this.M,this.N,c);
       return C;
   }
}
