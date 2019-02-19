/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author админъ
 */
public class Trigonom {
    
    public static double Sinus(double x,double e)
    {
        double sinus=0;
        double sn=1;
        int n=0;
        while(Math.abs(sn)>e)
        {
            sn=(Math.pow(-1,n)*Math.pow(x,(2*n+1)))/factorial((2*n+1));
            sinus=sinus+sn;
            n++;
        }
        return sinus;
    }
    
    public static double Cosinus(double x,double e)
    {
        double cosinus=0;
        double sn=1;
        int n=0;
        while(Math.abs(sn)>e)
        {
            sn=(Math.pow(-1,n)*Math.pow(x,(2*n)))/factorial((2*n));
            cosinus=cosinus+sn;
            n++;
        }
        return cosinus;  
    }
    
    private static double factorial(double n)
    {
        if(n==0)
        {
            return 1;
        }
     double fact=1;
     for(int i=1;i<=n;i++)
     {
         fact*=i;
     }
     return fact;
    }
    
}
