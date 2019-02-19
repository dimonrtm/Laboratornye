package sample;

/**
 * Created by админъ on 29.11.2016.
 */
public class edge {
    private int u;
    private int v;

     public edge(int u,int v)
     {
         this.u=u;
         this.v=v;
     }

     public void setU(int u)
     {
         this.u=u;
     }

     public void setV(int v)
     {
         this.v=v;
     }

     public int getU()
     {
         return u;
     }

     public int getV()
     {
         return v;
     }
}
