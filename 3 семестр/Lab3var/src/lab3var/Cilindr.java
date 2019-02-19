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
public class Cilindr extends Circle {
   private double h;

    public Cilindr(double _r,double _h) {
        super(_r);
        h=_h;   
    }
   
    public double GetV()
    {
      return super.GetArea()*h;   
    }
    
   @Override
   public double GetArea()
   {
       return super.GetLength()*(h+R);
   }
   
   @Override
   public void printShape()
   {
     System.out.println("Площадь цилиндра: "+this.GetArea()+"."+" Объем цилиндра: "+this.GetV());  
   }
}
