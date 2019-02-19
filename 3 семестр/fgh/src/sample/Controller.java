package sample;

import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.TextArea;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;

import java.util.Random;

public class Controller {
    public Pane cashbox1;
    public Pane cashbox2;
    public Pane cashbox3;
    public Pane cashbox4;
    public TextArea textblock;
    public Button begin;
   private Cashbox cash1;
    private Cashbox cash2;
    private Cashbox cash3;
    private Cashbox cash4;
    private Thread th5;
    final Restourant r=new Restourant("KFC");

    public void init(MouseEvent mouseEvent) {

             cash1=new Cashbox(cashbox1,7000);
            cash1.setCoordinatesCashBox(371,29);
            r.addCashbox(cash1);
         cash2=new Cashbox(cashbox2,5000);
        cash2.setCoordinatesCashBox(370,29);
        r.addCashbox(cash2);
         cash3=new Cashbox(cashbox3,6000);
        cash3.setCoordinatesCashBox(395,33);
        r.addCashbox(cash3);
         cash4=new Cashbox(cashbox4,4000);
        cash4.setCoordinatesCashBox(383,35);
        r.addCashbox(cash4);
        cash1.start();
        cash2.start();
        cash3.start();
        cash4.start();
         th5=new Thread(new Runnable() {
            @Override
            public void run() {
              for(int i=0;i<100;i++) {
                  Client c=new Client(r);
                  Random rand=new Random();
                  c.start();
                  try {
                      Thread.sleep(1000);
                  } catch (InterruptedException e) {
                      e.printStackTrace();
                  }
              }
        }});

        th5.start();
        }
}



