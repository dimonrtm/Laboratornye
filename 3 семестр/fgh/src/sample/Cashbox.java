package sample;

import javafx.application.Platform;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;

import java.util.LinkedList;
import java.util.Random;
import java.util.concurrent.locks.ReentrantLock;

/**
 * Created by админъ on 07.11.2016.
 */
public class Cashbox extends Thread {
    private Pane cashBoxPanel;
    private int cashBoxX;
    private int cashBoxY;
    private int deltaX=40;
    private int radius=17;
    private ReentrantLock locking=new ReentrantLock();
    LinkedList<Client> clients=new LinkedList<Client>();
    private int speed;


    public Cashbox(Pane pane,int speed)
    {
        cashBoxPanel=pane;
        this.speed=speed;
    }

    public LinkedList<Client> getClients()
    {
        return clients;
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
        if(cashBoxPanel.getChildren().size()<=1)
        {
            cl1.setLayoutX(cashBoxX-deltaX);
            cl1.setLayoutY(cashBoxY);
        }
        else
        {
            cl1.setLayoutX(cashBoxPanel.getChildren().get(cashBoxPanel.getChildren().size()-1).getLayoutX()-deltaX);
            cl1.setLayoutY(cashBoxY);
        }
        cl1.setRadius(radius);
                Random rand=new Random();
                int red=rand.nextInt(255);
                int green=rand.nextInt(255);
                int blue=rand.nextInt(255);
                cl1.setFill(Color.rgb(red,green,blue));
                cashBoxPanel.getChildren().add(cl1);
                cl.setCircle(cl1);
            }
            else
                {
                    if(cashBoxPanel.getChildren().size()<=1)
                    {
                        cl.getCircle().setLayoutX(cashBoxX-deltaX);
                        cl.getCircle().setLayoutY(cashBoxY);
                    }
                    else
                    {
                        cl.getCircle().setLayoutX(cashBoxPanel.getChildren().get(cashBoxPanel.getChildren().size()-1).getLayoutX()-deltaX);
                    }
                    cashBoxPanel.getChildren().add(cl.getCircle());
                }
        }});
        clients.add(c);
    }

    public Pane getCashBoxPanel()
    {
        return cashBoxPanel;
    }

    public void removeClient(Client c)
    {
        final Client cl=c;
        Platform.runLater(new Runnable() {
           @Override
            public void run() {
                cashBoxPanel.getChildren().remove(cl.getCircle());
            }
        });
        //cashBoxPanel.getChildren().remove(c.getCircle());
    }

    public void removeChangeClient(Client c)
    {
        final Client cl=c;
        Platform.runLater(new Runnable() {
            @Override
            public void run() {
             int index=cashBoxPanel.getChildren().indexOf(cl.getCircle());
                cashBoxPanel.getChildren().remove(cl.getCircle());
                if(cashBoxPanel.getChildren().size()>1) {
                    for (int i = index; i < cashBoxPanel.getChildren().size(); i++) {
                     cashBoxPanel.getChildren().get(i).setLayoutX(cashBoxPanel.getChildren().get(i).getLayoutX()+deltaX);
                    }
                }
            }
        });
        clients.remove(c);
    }

    public void setCoordinatesCashBox(int X,int Y)
    {
        cashBoxX=X;
        cashBoxY=Y;
    }

    @Override
    public void run() {
        Random rand= new Random();
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
                      if(cashBoxPanel.getChildren().size()>1)
                      {
                          for(int i=1;i<cashBoxPanel.getChildren().size();i++)
                          {
                              cashBoxPanel.getChildren().get(i).setLayoutX(cashBoxPanel.getChildren().get(i).getLayoutX()+deltaX);
                          }
                      }
                    }
                });
                if(!c.startServise(this))
                {
                  return;
                }
                try {
                    Thread.sleep(speed);
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
                c.endServise();
            }
        }
    }

