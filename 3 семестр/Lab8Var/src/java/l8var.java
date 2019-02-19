/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author админъ
 */
public class l8var extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        try (PrintWriter out = response.getWriter()) {
            /* TODO output your page here. You may use following sample code. */
            out.println("<!DOCTYPE html>");
            out.println("<html>");
            out.println("<head>");
            out.println("<title>Вычисление триногометрических функций</title>");            
            out.println("</head>");
            out.println("<body>");
             out.print("<form action=\"l8var\"");
        out.print("Вычисление тригонометрических функций\" ");
        out.println("method=POST>");
            out.println("<br>");
           out.println("Введите число градусов/радиан:");
           out.println("<input type=text size=20 name=x>");
           out.println("<br>");
           out.println("Введите точность вычислений:");
           out.println("<input type=text size=20 name=eps>");
           out.println("<br>");
           out.println(" <input type=radio name=grr value=gr> Градусы<Br>");
           out.println(" <input type=radio name=grr value=rad> Радианы<Br>");
           out.println("<p><select size=1 name=function>");
           out.println(" <option value=Sinus >Sinus</option>");
           out.println(" <option value=Cosinus>Cosinus</option>");
           out.println(" <option value=Tangens>Tangens</option>");
           out.println(" <option value=Cotangens>Cotangens</option>");
           out.println(" <option value=Secans>Secans</option>");
           out.println(" <option value=Cosecans>Cosecans</option>");
           out.println(" </select></p>");
           out.println("<p><input type=submit value=Отправить></p>");
           out.println("</form>");
             String M=request.getParameter("grr");
           String X=request.getParameter("x");
           String E=request.getParameter("eps");
           String S=request.getParameter("function");
           out.println("<br>");
           double x=0,epsilon=0;
           if(X!=null)
           {
               try
               {
                x=Double.parseDouble(X);
               }
               catch(Exception e)
               {
                   out.println("Вы ввели не число");
               }
           }
           
           if(E!=null)
           {
               try
               {
               epsilon=Double.parseDouble(E);
               }
               catch(Exception e)
               {
                   out.println("Вы ввели не число");
               }
           }
           
           if(M!=null&&M.equals("gr"))
           {
            x=x*(Math.PI/180);   
           }
           out.println("<br");
                  if(S.equals("Sinus"))
                  {
                       Double sin=Trigonom.Sinus(x, epsilon);
                       out.println("<Body>Синус данного угла равен "+ sin+"</Body>");
                  }
                   if(S.equals("Cosinus"))
                   {
                       Double cos=Trigonom.Cosinus(x, epsilon);
                       out.println("<Body>Косинус данного угла равен "+cos+"</Body>");
                   }
                   if(S.equals("Tangens"))
                           {
                       if(Trigonom.Cosinus(x, epsilon)==0)
                       {
                           out.println("<Body>Тангенс данного угла не существует</Body>");
                       }
                       else
                       {
                           Double tan=Trigonom.Sinus(x, epsilon)/Trigonom.Cosinus(x, epsilon);
                           out.println("<Body>Тангенс данного угла равен "+tan+"</Body>");
                       }
                           }
                   if(S.equals("Cotangens"))
                           {
                       if(Trigonom.Sinus(x, epsilon)==0)
                       {
                           out.println("<Body>Котангенс данного угла не существует</Body>");
                       }
                       else
                       {
                           Double cotan=Trigonom.Cosinus(x, epsilon)/Trigonom.Sinus(x, epsilon);
                           out.println("<Body>Котангенс данного угла равен "+cotan+"</Body>");
                       }
                           }
                   if(S.equals("Secans"))
                   {
                        if(Trigonom.Cosinus(x, epsilon)==0)
                       {
                           out.println("<Body>Секанс данного угла не существует</Boody>");
                       }
                       else
                       {
                           Double sek=1/Trigonom.Cosinus(x, epsilon);
                           out.println("<Body>Секанс данного угла равен "+sek+"</Body>");
                       }
                   }
                   if(S.equals("Cosecans"))
                   {
                      if(Trigonom.Sinus(x, epsilon)==0)
                       {
                           out.println("<Body>Косеканс данного угла не существует</Body>");
                       }
                       else
                       {
                           Double cosek=1/Trigonom.Sinus(x, epsilon);
                           out.println("<Body>Косеканс данного угла равен "+cosek+"</Body>");
                       }
                   }
            out.println("</body>");
            out.println("</html>");
            
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
        
        
         
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
         
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
