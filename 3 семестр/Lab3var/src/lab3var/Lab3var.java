/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lab3var;

/**
 *
 * @author student01
 */
import java.util.Scanner;
import java.util.InputMismatchException;
import java.util.ArrayList;
public class Lab3var {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int N,M;
        ArrayList Circles=new ArrayList();
        ArrayList Cilindres=new ArrayList();
        //ввод числа окружностей
        while(true)
        {
          System.out.println("Введите число окружностей:"); 
          Scanner sc1=new Scanner(System.in);
            try
            {
             N=sc1.nextInt();
             break;
            }
            catch(InputMismatchException ime1)
            {
                System.out.println("Вы ввели не число.");
            }
        }
        //ввод числа цилиндров
        while(true)
        {
           System.out.println("Введите число цилиндров:");
           Scanner sc2=new Scanner(System.in);
           try
           {
               M=sc2.nextInt();
               break;
           }
           catch(InputMismatchException ime2)
           {
               System.out.println("Вы ввели не число.");
           }
        }
        // ввод списка цилиндров
        for(int i=0;i<N;i++)
        {
            double r;
            while(true)
            {
                System.out.println("Введите радиус окружности:");
                Scanner sc3=new Scanner(System.in);
                try
                {
                    r=sc3.nextDouble();
                    break;
                }
                catch(InputMismatchException ime3)
                {
                    System.out.println("Вы ввели не число.");
                }
            }
            Circle circle=new Circle(r);
            Circles.add(circle);
        }
        //ввод списка цилиндров
        for(int i=0;i<M;i++)
        {
            double rOsn,h;
           while(true)
           {
               System.out.println("Введите радиус основания цилиндра:");
               Scanner sc4=new Scanner(System.in);
               try
               {
                   rOsn=sc4.nextDouble();
                   break;
               }
               catch(InputMismatchException ime4)
               {
                   System.out.println("Вы ввели не число.");
               }
           }
           while(true)
           {
               System.out.println("Введите высоту цилиндра:");
               Scanner sc5=new Scanner(System.in);
               try
               {
                   h=sc5.nextDouble();
                   break;
               }
               catch(InputMismatchException ime5)
               {
                   System.out.println("Вы ввели не число.");
               }
           }
           Cilindr cilindr=new Cilindr(rOsn,h);
           Cilindres.add(cilindr);
        }
        // нахождение окружности с максимальной площадью
        Circle maxArea=(Circle)Circles.get(0);
        for(int i=1;i<Circles.size();i++)
        {
            Circle c=(Circle)Circles.get(i);
            if(maxArea.GetArea()<c.GetArea())
            {
                maxArea=c;
            }
        }
        System.out.println("Окружность с максимальной площадью:");
        maxArea.printShape();
        // нахждение среднего объема всех цилиндров
        double sum =0;
        double averageV;
        for(int i=0;i<Cilindres.size();i++)
        {
          sum+=((Cilindr)Cilindres.get(i)).GetV();  
        }
        averageV=sum/Cilindres.size();
        System.out.println("Средний объем цилиндра: "+averageV);
    }
    
}
