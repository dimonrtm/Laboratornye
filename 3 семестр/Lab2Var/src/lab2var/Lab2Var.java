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
public class Lab2Var {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       int[][] a={{5,1,7},{10,-2,1},{0,1,2}};
       Matrix A=new Matrix(3,3,a);
       int[][] b={{2,4,1},{2,1,0},{7,2,1}};
       Matrix B=new Matrix(3,3,b);
       Matrix C=A.Substract(B).Multiply(A.Multiply(A).Summary(B)).MultiplyNumber(2);
       C.OutputMatrix();
       System.out.println(C.determinant());
    }
    
}
