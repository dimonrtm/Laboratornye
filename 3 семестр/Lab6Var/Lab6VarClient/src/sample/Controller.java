package sample;

import javafx.scene.control.TextArea;
import javafx.scene.input.MouseEvent;

import java.io.*;
import java.net.Socket;
import java.util.Scanner;

public class Controller {
    public TextArea text;

    public void getSonet(MouseEvent mouseEvent) {
        Socket server=null;
        try {
            server = new Socket("localhost", 4444);
        } catch (IOException e) {
            e.printStackTrace();
        }
        BufferedReader in=null;
        try {
             in = new BufferedReader(new InputStreamReader(server.getInputStream()));
        } catch (IOException e) {
            e.printStackTrace();
        }
        try {
            PrintWriter out = new PrintWriter(server.getOutputStream(), true);
        } catch (IOException e) {
            e.printStackTrace();
        }
        String s=null;
        File f=null;
        try {
            s=in.readLine();
        } catch (IOException e) {
            e.printStackTrace();
        }
         f=new File(s);
        Scanner scan2=null;
        try {
             scan2=new Scanner(f);
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
        String str="";
        while(scan2.hasNext())
        {
           str+= scan2.nextLine()+"\n";
        }
        text.setText(str);
    }
}
