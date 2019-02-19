package sample;

import java.util.ArrayList;

/**
 * Created by админъ on 09.11.2016.
 */
public class Restourant
{
    private String name;
    ArrayList<Cashbox> listCashbox=new ArrayList<Cashbox>();

    public Restourant(String name)
    {
        this.name=name;
    }

    public void addCashbox(Cashbox cash)
    {
        listCashbox.add(cash);
    }

    public ArrayList<Cashbox> getListCashbox()
    {
        return listCashbox;
    }
}
