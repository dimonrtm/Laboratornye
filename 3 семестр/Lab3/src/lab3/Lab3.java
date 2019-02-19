/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lab3;

/**
 *
 * @author student
 */
import java.util.*;
public class Lab3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       ArrayList Students=new ArrayList();
       ArrayList Horoshisty=new ArrayList();
       for(int i=0;i<20;i++)
       {
           Student st=new Student("Ivan","Ivanovich","Ivanov");
           for(int j=0;j<5;j++)
           {
               int grade=(int)Math.round(Math.random()*3+2);
               st.SetGrade(grade);
           }
           st.AverageGrade();

           if(st.IsHoroshist())
             {
              st= new Horoshist(st);
              Horoshisty.add(st);
             }
           else
           {
           Students.add(st);       
           }
       }
      
       System.out.println("Хорошисты:");
       for(int i=0;i<Horoshisty.size();i++)
       {  
         Horoshist hor=(Horoshist)Horoshisty.get(i);
           System.out.println("Полное имя "+hor.GetFullName());
           System.out.println("Средняя успеваемость "+hor.GetAverage());
       }
       System.out.println("Остальные студенты:");
       for(int i=0;i<Students.size();i++)
       {
           Student st=(Student)Students.get(i);
           System.out.println("Полное имя "+st.GetFullName());
           System.out.println("Средняя успеваемость "+st.GetAverage());
       }
    }
    
}

