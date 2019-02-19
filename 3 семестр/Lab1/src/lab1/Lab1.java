/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lab1;

/**
 *
 * @author админъ
 */
import java.io.IOException;
import java.util.InputMismatchException;
import java.util.Scanner;

public class Lab1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int n=0,k=0,count=0;
        char c=' ';
        while(true)
        {
            System.out.println("Введите количество строк текста:");
            Scanner sc1=new Scanner(System.in);
            try
            {
             n=sc1.nextInt();
             break;
            }
            catch(InputMismatchException ime1)
                    {
                      System.out.println("Вы ввели не число");
                    }
        }
        while(true)
        {
            System.out.println("Введите позицию в слове для замены символа:");
            Scanner sc2=new Scanner(System.in);
            try
            {
                k=sc2.nextInt();
               break; 
            }
            catch(InputMismatchException ime2)
            {
              System.out.println("Вы ввели не число");
            }
        }
        while(true)
        {
            System.out.println("Введите символ для замены:");
             Scanner sc3=new Scanner(System.in);
            try
            {
                c=(char)System.in.read();
                sc3.nextLine();
               break;
            }
            catch(IOException  e)
 
                    {
                     System.out.println("Ошибка ввода!");
                    }
        }
        String [] strs=new String[n];
        Scanner sc4=new Scanner(System.in);
        for(int i=0;i<n;i++)
        {
            strs[i]=sc4.nextLine();
        }
        for(int i=0;i<n;i++)
        {
            String [] temp=strs[i].split(" ");
            strs[i]="";
            for(int j=0;j<temp.length;j++)
            {
                if(temp[j].length()>k)
                {
                  temp[j]=temp[j].substring(0,k-1)+c+temp[j].substring(k);
                }
                if(temp[j].length()==k)
                {
                    temp[j]=temp[j].substring(0,k-1)+c;
                }
                strs[i]=strs[i]+temp[j]+" ";
            }
////         for(int j=0;j<strs[i].length();j++)
////         {
////             if(strs[i].charAt(j)==' '||j==(strs[i].length()-1))
////             {
////               if((j-count)>=k)
////               {
////                   strs[i]=strs[i].substring(0,count+k-1)+c+strs[i].substring(count+k);
////               }
////               count=j+1;
////             }
////         }
////           count=0;
        }
        for(int y=0;y<strs.length;y++)
        {
            System.out.println(strs[y]);
        }
    }
    
}
