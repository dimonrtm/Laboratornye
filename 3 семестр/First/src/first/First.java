/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package first;

/**
 *
 * @author админъ
 */
import java.io.*;
import java.util.*;
import java.util.InputMismatchException;
import java.util.Scanner;
public class First {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
//       Rectangle myRectangle1=new Rectangle();
//       myRectangle1.FSideA=5;
//       myRectangle1.FSideB=10;
//       myRectangle1.SetName("Большой прямоугольник");
//       int perimeter1=myRectangle1.GetPerimeter();
//       System.out.println(myRectangle1.FName);
//       System.out.println(perimeter1);
//       System.out.println(myRectangle1.GetArea());
//       Rectangle myRectangle2=new Rectangle();
//       myRectangle2.FSideA=2;
//       myRectangle2.FSideB=3;
//       myRectangle2.SetName("Маленький прямоугольник");
//       int perimeter2=myRectangle2.GetPerimeter();
//       System.out.println(myRectangle2.FName);
//       System.out.println(perimeter2);
//       System.out.println(myRectangle2.GetArea());

         Rectangle R1=new Rectangle("Большой прямоугольник",5,10);
         System.out.println(R1.GetName());
         System.out.println(R1.GetPerimeter());
         Rectangle R2=new Rectangle();
         System.out.println(R2.GetName());
         System.out.println(R2.GetPerimeter());
         
         int n=0;
                 //Ввод количества прямоугольников 
         System.out.println("Введите число прямоугольников");
         Scanner sc1=new Scanner(System.in);
         while(true)
         {
         try
         {
             n=sc1.nextInt();
             break;
         }
         catch(InputMismatchException ime1)
         {
           System.out.println("Вы ввели не число!");
         }
         }
         // Массивы в которых хранятся координаты правого верхнего и левого нижнего углов прямоугольников
         Rectangle [] Rects=new Rectangle[n];
         for(int i=0;i<n;i++)
         {
             // Ввод координат левого верхнего угла прямоугольника
             int x=0,y=0;
             Rects[i]=new Rectangle();
             System.out.println("Введите координаты левого верхнего угла прямоуголника №"+(i+1));
             System.out.print("X:");
             Scanner sc2=new Scanner(System.in);
             while(true)
             {
             try
             {
                 x=sc2.nextInt();
                 break;
             }
             catch(InputMismatchException ime2)
             {
               System.out.println("Вы ввели не число!");  
             }
             }
             System.out.print("Y:");
             Scanner sc3=new Scanner(System.in);
             while(true)
             {
                 try
                 {
                     y=sc3.nextInt();
                     break;
                 }
                 catch(InputMismatchException ime3)
                 {
                   System.out.println("Вы ввели не число!");  
                 }
             }
            Rects[i].SetPointLeftTop(x, y);
            
            // Ввод координат правого нижнего угла прямоугольника
            System.out.println("Введите координаты правого нижнего угла прямоугольника № "+(i+1));
            System.out.print("X:");
            Scanner sc4=new Scanner(System.in);
            while(true)
            {
                try
                {
                    x=sc4.nextInt();
                    break;
                }
                catch(InputMismatchException ime4)
                {
                 System.out.println("Вы ввели не число!");   
                }
            }
            System.out.print("Y:");
            Scanner sc5=new Scanner(System.in);
            while(true)
            {
                try
                {
                y=sc5.nextInt();
                break;
                }
                catch(InputMismatchException ime5)
                {
                  System.out.println("Вы ввели не число!");  
                }
            }
            Rects[i].SetPointRightBottom(x, y);
            Rects[i].SetName("Прямоугольник № "+(i+1));
         }
         // Проверка пересечения прямоугольников
         for(int i=0;i<n-1;i++)
         {
             for(int j=i+1;j<n;j++)
             {
                 if(Rectangle.Intersect(Rects[i],Rects[j]))
                 {
                     System.out.println(Rects[i].GetName()+" пересекает "+Rects[j].GetName());
                 }
             }
         }
    }
    
}
