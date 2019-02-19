/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lab3;
import java.util.*;
/**
 *
 * @author student
 */
public class Student implements CheckStudent {
   protected String Name;
   protected String Surname;
   protected String Patronymic;
   protected ArrayList Grade;
   protected double Average;
   
   public Student()
   {
       Name=" ";
       Surname=" ";
       Patronymic=" ";
       Grade=new ArrayList();
       Average=0.0;
   }
   
   public Student(String _name,String _surname,String _patronymic)
   {
       Name=_name;
       Surname=_surname;
       Patronymic=_patronymic;
       Grade=new ArrayList();
   }
   
   public String GetFullName()
   {
       return Name+" "+Surname+" "+Patronymic;
   }
   
   public double GetAverage()
   {
       return Average;
   }
   
   public void SetGrade(int _grade)
   {
     if(_grade>1 && _grade<6)
     {
        Grade.add(_grade);
        Average = (Average+_grade)/Grade.size();
     }
   }
   
   public void AverageGrade()
   {
       double sum=0;
       double number=0;
       for(int i=0;i<Grade.size();i++)
       {
           sum+=(double)(int)Grade.get(i);
          number++;
       }
       Average=sum/number; 
   }
  
   @Override
   public boolean IsOtlichnik()
   {
     if(Grade.indexOf(4)==-1&&Grade.indexOf(3)==-1&&Grade.indexOf(2)==-1)
     {
         return true;
     }
     else
     {
         return false;
     }
   }
   
   @ Override
   public boolean IsHoroshist()
   {
    if(Grade.indexOf(3)==-1&&Grade.indexOf(2)==-1&&!this.IsOtlichnik())
     {
         return true;
     }
     else
     {
         return false;
     }  
   }
}
