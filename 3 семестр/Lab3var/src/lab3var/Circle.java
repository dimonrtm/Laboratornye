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
public class Circle {
  protected double R;

public Circle(double _r)
{
  R=_r;  
}

public double GetArea()
{
    return Math.PI*Math.pow(R, 2.0);
}

public double GetLength()
{
    return 2*Math.PI*R;
}

public void printShape()
{
    System.out.println("Площадь круга: "+this.GetArea()+"."+" Длинна окружности: "+this.GetLength());
}
}
