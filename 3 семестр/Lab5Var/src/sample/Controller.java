package sample;

import javafx.scene.input.MouseEvent;
import javafx.scene.layout.Pane;

public class Controller {
    public Pane operator1;
    public Pane operator2;
    public Pane operator3;
    public Pane operator4;
    private Organization org=new Organization("name");
    private  Operator opp1;
    private Operator opp2;
    private Operator opp3;
    private Operator opp4;
    private Thread th5;

    public void init(MouseEvent mouseEvent) {
      opp1=new Operator(operator1);
        opp1.setCoordinatesOperator(414,35);
        org.addOperator(opp1);
        opp2=new Operator(operator2);
        opp2.setCoordinatesOperator(424,43);
        org.addOperator(opp2);
        opp3=new Operator(operator3);
        opp3.setCoordinatesOperator(426,40);
        org.addOperator(opp3);
        opp4=new Operator(operator4);
        opp4.setCoordinatesOperator(432,34);
        org.addOperator(opp4);
        th5=new Thread(new Runnable() {
            @Override
            public void run() {
             for(int i=0;i<100;i++)
             {
               Client c=new Client(org);
                 c.start();
                 try {
                     Thread.sleep(1000);
                 } catch (InterruptedException e) {
                     e.printStackTrace();
                 }
             }
            }
        });
        opp1.start();
        opp2.start();
        opp3.start();
        opp4.start();
        th5.start();
    }
}
