package sample;

import javafx.scene.control.Button;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;
import javafx.scene.input.MouseEvent;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.InputMismatchException;
import java.util.Scanner;

public class Controller {
    public TextArea text;
    public Button Button1;
    public Button button2;
    public Button Button3;
    public TextField pthfile;
    Graph G;

    public void load(MouseEvent mouseEvent) {
        String path=pthfile.getText();
        File file=new File(path);

        Scanner scan=null;
        try {
            scan=new Scanner(file);
        } catch (FileNotFoundException e) {
            e.printStackTrace();
            text.setText("Вы не ввели путь к файлу");
        }
        int n=0;
        try
        {
            n = Integer.parseInt(scan.nextLine());
        }
        catch(NumberFormatException e)
        {
            text.setText("Данный файл содержит некорректные данные!");
            return;
        }
        int [][] matrix=new int[n][n];
        String s="";
        for(int i=0;i<n;i++)
        {


            try {
                s =scan.nextLine();
            }
            catch(InputMismatchException e)
            {
                e.printStackTrace();
            }
            String [] strs=s.split(" ");
            for(int j=0;j<strs.length;j++)
            {
                int m=Integer.parseInt(strs[j]);
                matrix[i][j]=m;
            }
        }
         G=new Graph(n,matrix);
        String str=G.printGraph();
        text.setText(str);
    }

    public void clique(MouseEvent mouseEvent) {
      if(G==null)
      {
          text.setText("Вы еще не загрузили граф!");
      }
      else
      {
          String str=G.outputMaxClique();
          text.setText(str);
      }
        }

    public void independet(MouseEvent mouseEvent) {
        if(G==null)
        {
            text.setText("Вы еще не загрузили граф!");
        }
        else
        {
            String str=G.outputMaxIndependedSet();
            text.setText(str);
        }
    }

    public void cover(MouseEvent mouseEvent) {
        if(G==null)
        {
            text.setText("Вы еще не загрузили граф!");
        }
        String str=G.printVertexCover();
        text.setText(str);
    }
}
