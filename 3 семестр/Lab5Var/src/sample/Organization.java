package sample;

import java.util.ArrayList;

/**
 * Created by админъ on 16.11.2016.
 */
public class Organization {
    private String name;
    ArrayList<Operator> listOperators = new ArrayList<Operator>();

    public Organization(String name) {
        this.name = name;
    }

    public void addOperator(Operator o) {
        listOperators.add(o);
    }

    public ArrayList<Operator> getListOperators() {
        return listOperators;
    }
}