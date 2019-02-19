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
public class Rectangle {
    private int FSideA;
    private int FSideB;
    private String FName;
    private int X0;
    private int Y0;
    private int X1;
    private int Y1;
    
    public Rectangle()
    {
        FSideA=1;
        FSideB=1;
        FName="Прямоугольник 1х1";
    }
    
    public Rectangle(String _name,int _sideA,int _sideB)
    {
        FSideA=_sideA;
        FSideB=_sideB;
        FName=_name;
    }
    
    public int GetPerimeter()
    {
        return (FSideA+FSideB)*2;
    }
    
    public void SetName(String newName)
    {
        FName=newName;
    }
    
    public String GetName()
    {
        return FName;
    }
    
    public int GetArea()
    {
        return FSideA*FSideB;
    }
    
    public void Resize(int _a,int _b)
    {
        FSideA=_a;
        FSideB=_b;
    }
    
    public void SetPointLeftTop(int _x,int _y)
    {
      X0=_x;
      Y0=_y;
    }
    
    public void SetPointRightBottom(int _x,int _y)
    {
        X1=_x;
        Y1=_y;
    }
    
    public static boolean Intersect(Rectangle _rect1,Rectangle _rect2)
    {
        if(_rect1.Y1>_rect2.Y0||_rect1.Y0<_rect2.Y1)
        {
            return false;
        }
        if(_rect1.X0>_rect2.X1||_rect1.X1<_rect2.X0)
        {
            return false;
        }
        return true;
    }
}
