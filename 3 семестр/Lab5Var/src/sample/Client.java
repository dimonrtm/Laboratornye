package sample;

import javafx.scene.shape.Circle;

import java.util.Random;
import java.util.concurrent.locks.ReentrantLock;

/**
 * Created by админъ on 16.11.2016.
 */
public class Client extends Thread {
    private Operator operator;
    private Circle circle;
    private boolean isStartServise = false;
    private boolean isEndServise = false;
    ReentrantLock locking = new ReentrantLock();
    private Organization org;

    public Client(Organization org)
    {
        this.org=org;
    }

    public void setCircle(Circle circle) {
        this.circle = circle;
    }

    public Circle getCircle() {
        return circle;
    }

    public void startServise() {
        locking.lock();
        try {
            isStartServise = true;
        }
        finally {
            locking.unlock();
        }
    }

    public void endServise() {
        locking.lock();
        try {
            isStartServise=false;
            isEndServise = true;
        }
        finally
        {
            locking.unlock();
        }
    }

    public void firstAddOperator(Operator opp)
    {
        opp.addClient(this);
        this.operator=opp;
    }


    public Operator SearshTheBestOperator() {
        Operator opp = org.getListOperators().get(0);
        for (int i = 1; i < org.getListOperators().size(); i++) {
            if (org.getListOperators().get(i).getOperatorPanel().getChildren().size()< opp.getOperatorPanel().getChildren().size()) {
                opp = org.getListOperators().get(i);
            }
        }
        return opp;
    }

    @Override
    public void run()
    {
        Random rand= new Random();
        firstAddOperator(SearshTheBestOperator());
        Random r=new Random();
        while (true) {
            boolean endLoop=false;
            locking.lock();
            try {
                endLoop = isStartServise;

            } finally {
                locking.unlock();
            }
            if (endLoop) {
                break;
            }
            try {
                Thread.sleep(2000);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
            if(r.nextInt(60)<20)
            {
                changeAddOperator();
            }
        }


            while (true) {
                boolean endLoop=false;
                    locking.lock();
                    try {

                        endLoop = isEndServise;
                    } finally {
                        locking.unlock();
                    }

                if (endLoop) {
                    break;
                }
                try {
                    Thread.sleep(300);
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
            }

            operator.removeClient(this);

    }

    public void changeAddOperator()
    {
        Random rand=new Random();
        boolean skip=false;
        locking.lock();
        try
        {
            skip=isStartServise;
        }

        finally {
            locking.unlock();
        }
        if(skip)
        {
            return;
        }
            operator.removeChangeClient(this);
        try {
            Thread.sleep(1000);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        operator.addClient(this);
    }


}
