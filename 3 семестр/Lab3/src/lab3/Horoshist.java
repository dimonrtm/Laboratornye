/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lab3;

import java.util.ArrayList;

/**
 *
 * @author админъ
 */
public class Horoshist extends Student {
        
     public Horoshist(Student _st)
     {
       this.Name=_st.Name;
       this.Surname=_st.Surname;
       this.Patronymic=_st.Patronymic;
       this.Grade=_st.Grade;
       this.Average=_st.Average;
     }
    
    @Override
    public void SetGrade(int _grade)
    {
        if(_grade==5||_grade==4)
        {
            Grade.add(_grade);
        }
        else
        {
            System.out.println("Вы уверены что хотите поставить такую маленькую оценку?");
        }
    }
}
