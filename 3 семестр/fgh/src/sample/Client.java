package sample;

import javafx.application.Platform;
import javafx.scene.shape.Circle;

import java.util.Random;
import java.util.concurrent.locks.ReentrantLock;

/**
 * Created by админъ on 07.11.2016.
 */
public class Client extends Thread {
    private Cashbox cashbox;
    private Circle circle;
    private boolean isStartServise = false;
    private boolean isEndServise = false;
    private Restourant r;
    private Cashbox changeCashBox;
    ReentrantLock locking = new ReentrantLock();

    public Client(Restourant r) {
        this.r = r;
    }

    public void setCashbox(Cashbox cash) {
        cashbox = cash;
    }

    public void setCircle(Circle circle) {
        this.circle = circle;
    }

    public Circle getCircle() {
        return circle;
    }

    @Override
    public void run() {
        Random rand= new Random();
        firstAddCashBox(r.getListCashbox().get(rand.nextInt(3)));

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
            changeAddCasbox();
        }

        while (true) {
            boolean endLoop=false;
            locking.lock();
            try {

                 endLoop = isEndServise;
            }
            finally{
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
        cashbox.removeClient(this);

}



    public boolean startServise(Cashbox cash) {
        if (this.cashbox != cash) {
            return false;
        }
        locking.lock();
        try {
            isStartServise = true;
            return true;
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

    public Cashbox SearshTheBestCasbox() {
                    Cashbox cash = r.getListCashbox().get(0);
                    for (int i = 1; i < r.getListCashbox().size(); i++) {
                        if (r.getListCashbox().get(i).getCashBoxPanel().getChildren().size()< cash.getCashBoxPanel().getChildren().size()) {
                            cash = r.getListCashbox().get(i);
                        }
                    }
        return cash;
    }

    public void firstAddCashBox(Cashbox cash)
    {
            cash.addClient(this);
        this.cashbox=cash;
    }

    public void changeAddCasbox()
    {
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
        Cashbox cash=SearshTheBestCasbox();
        if(cash==this.cashbox)
        {
            return;
        }
        if(this.cashbox.getCashBoxPanel().getChildren().indexOf(this.getCircle())>this.cashbox.getCashBoxPanel().getChildren().size()/2) {
            cashbox.removeChangeClient(this);
            cash.addClient(this);
            this.cashbox = cash;
        }
    }
}



