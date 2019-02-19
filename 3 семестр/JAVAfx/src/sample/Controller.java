package sample;

import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.ListView;
import javafx.scene.control.TextField;
import javafx.scene.input.MouseEvent;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.*;

public class Controller {
    public ListView list;
    public TextField text1;
    public TextField text2;
    public Label label1;
    public Button button2;
    public TextField text3;
    private HashMap<String,String> dictionary=new HashMap<String,String>();

    public void click(ActionEvent actionEvent)throws FileNotFoundException {
        File file = new File("D:\\Words.txt");
        String s = "",p="";
        Scanner scan = new Scanner(file);
        while(scan.hasNext())
        {
             s= scan.nextLine();
            if(list.getItems().contains(s))
            {
                label1.setText("Данное слово уже есть в списке!");
            }
            else {
                list.getItems().add(s);
            }
                if (scan.hasNext()) {
                    p = scan.nextLine();
                }
                dictionary.put(s, p);

        }
        scan.close();
    }

    public void click2(ActionEvent actionEvent) {
        String s="",p="";
        s=text1.getText();

        if(list.getItems().contains(s))
        {
            label1.setText("Данное слово уже есть в списке!");

        }
        else
        {
            list.getItems().add(s);
        }
        p=text3.getText();
        dictionary.put(s,p);
    }

    public void click3(ActionEvent actionEvent) {
        File file=new File("D://Words.txt");
        try {
            PrintWriter write = new PrintWriter("D:\\words.txt");
            for(int i=0;i<list.getItems().size();i++)
            {

                write.print(list.getItems().get(i)+"\r\n");
                write.print(dictionary.get(list.getItems().get(i))+"\r\n");
            }
            write.close();


        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
    }

    public void click4(ActionEvent actionEvent) {
        String s=text2.getText();
        label1.setText("Данного слова в списке нет");
        for(int i=0;i<list.getItems().size();i++) {
            if (s.equals(list.getItems().get(i))) {
                label1.setText((dictionary.get((String)list.getItems().get(i))) );
                break;
            }
        }
    }

    public void click5(ActionEvent actionEvent) {
       int select= list.getSelectionModel().getSelectedIndex();
        String selectWord=(String)list.getSelectionModel().getSelectedItem();
        list.getItems().remove(select);
        dictionary.remove(selectWord);
    }

    public void clickList(MouseEvent mouseEvent) {
        text2.setText((String)list.getSelectionModel().getSelectedItem());
        label1.setText(dictionary.get((String)list.getSelectionModel().getSelectedItem()));
    }
}
