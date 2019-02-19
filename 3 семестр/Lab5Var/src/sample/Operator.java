package sample;

import javafx.application.Platform;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;

import java.util.LinkedList;
import java.util.Random;
import java.util.concurrent.locks.ReentrantLock;

/**
 * Created by админъ on 16.11.2016.
 */
public class Operator extends Thread {
    private Pane OperatorPanel;
    private int operatorX;
    private int operatorY;
    private int deltaX=40;
    private int radius=17;
    private boolean isPutPhoneDown;
    private ReentrantLock locking=new ReentrantLock();
    LinkedList<Client> clients=new LinkedList<Client>();

    public Operator(Pane pane)
    {
        OperatorPanel=pane;
    }

    public LinkedList<Client> getClients()
    {
        return clients;
    }

    public Pane getOperatorPanel()
    {
        return OperatorPanel;
    }

    public void addClient(Client c)
    {
        final Client cl=c;
        Platform.runLater(new Runnable() {
            @Override
            public void run() {
                if(cl.getCircle()==null)
                {
                    Circle cl1=new Circle();
                    if(OperatorPanel.getChildren().size()<=1)
                    {
                        cl1.setLayoutX(operatorX-deltaX);
                        cl1.setLayoutY(operatorY);
                    }
                    else
                    {
                        cl1.setLayoutX(OperatorPanel.getChildren().get(OperatorPanel.getChildren().size()-1).getLayoutX()-deltaX);
                        cl1.setLayoutY(operatorY);
                    }
                    cl1.setRadius(radius);
                    Random rand=new Random();
                    int red=rand.nextInt(255);
                    int green=rand.nextInt(255);
                    int blue=rand.nextInt(255);
                    cl1.setFill(Color.rgb(red,green,blue));
                    OperatorPanel.getChildren().add(cl1);
                    cl.setCircle(cl1);
                }
                else
                {
                    if(OperatorPanel.getChildren().size()<=1)
                    {
                        cl.getCircle().setLayoutX(operatorX-deltaX);
                        cl.getCircle().setLayoutY(operatorY);
                    }
                    else
                    {
                        cl.getCircle().setLayoutX(OperatorPanel.getChildren().get(OperatorPanel.getChildren().size()-1).getLayoutX()-deltaX);
                    }
                    OperatorPanel.getChildren().add(cl.getCircle());
                }
            }});
            clients.add(c);

    }

    public void removeChangeClient(Client c)
    {
        final Client cl=c;
        Platform.runLater(new Runnable() {
            @Override
            public void run() {
                int index=OperatorPanel.getChildren().indexOf(cl.getCircle());
                OperatorPanel.getChildren().remove(cl.getCircle());
                if(OperatorPanel.getChildren().size()>1) {
                    for (int i = index; i < OperatorPanel.getChildren().size(); i++) {
                        OperatorPanel.getChildren().get(i).setLayoutX(OperatorPanel.getChildren().get(i).getLayoutX()+deltaX);
                    }
                }
            }
        });
        clients.remove(c);
    }

    public void removeClient(Client c)
    {
        final Client cl=c;
        Platform.runLater(new Runnable() {
            @Override
            public void run() {
                OperatorPanel.getChildren().remove(cl.getCircle());
            }
        });
        //cashBoxPanel.getChildren().remove(c.getCircle());
    }


    public void setCoordinatesOperator(int X,int Y)
    {
        operatorX=X;
        operatorY=Y;
    }

    @Override
    public void run()
    {
        while (true) {
            Client c = null;
            locking.lock();
            try
            {
                if(clients.size()>0)
                {
                    try {
                        c = clients.removeFirst();
                    }
                    catch(Exception e)
                    {
                        continue;
                    }
                }

            }
           finally {
                locking.unlock();
            }

            if(c==null)
            {
                try {
                    Thread.sleep(2000);
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
                continue;
            }
            Platform.runLater(new Runnable() {
                @Override
                public void run() {
                    if(OperatorPanel.getChildren().size()>1)
                    {
                        for(int i=1;i<OperatorPanel.getChildren().size();i++)
                        {
                            OperatorPanel.getChildren().get(i).setLayoutX(OperatorPanel.getChildren().get(i).getLayoutX()+deltaX);
                        }
                    }
                }
            });
            c.startServise();
                try {
                    Thread.sleep(5000);
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
                c.endServise();

        }
    }
}
