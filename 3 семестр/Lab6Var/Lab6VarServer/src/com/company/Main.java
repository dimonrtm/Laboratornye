package com.company;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;
import java.util.Random;

public class Main {
   static ArrayList<String> fileSonets=new ArrayList<String>();
    public static void main(String[] args) {
      for(int i=0;i<20;i++)
      {
          fileSonets.add("D:\\Сонеты\\сонет"+(i+1)+".txt");
      }
        System.out.println("Жду подключения...");
        ServerSocket server=null;
        try {
             server=new ServerSocket(4444);

        } catch (IOException e) {
            e.printStackTrace();
        }
        while(true)
        {
            Socket client=null;
            try {
                client=server.accept();
            } catch (IOException e) {
                e.printStackTrace();
            }
            System.out.println("Подключился "+client.getInetAddress().toString());
                 BufferedReader in=null;
                    try {
                        in = new BufferedReader(new InputStreamReader(client.getInputStream()));
                    }
                    catch(IOException e)
                    {
                        e.printStackTrace();
                    }
                    PrintWriter out=null;
                    try
                    {
                        out=new PrintWriter(client.getOutputStream(),true);
                    }
                    catch(IOException e)
                    {
                        e.printStackTrace();
                    }
                    Random rand=new Random();
                    out.println(fileSonets.get(rand.nextInt(19)));
            System.out.println("Отключился "+client.getInetAddress().toString());
            try {
                in.close();
            } catch (IOException e) {
                e.printStackTrace();
                out.close();
                try {
                    client.close();
                } catch (IOException e1) {
                    e1.printStackTrace();
                }
            }
        }

        }
    }


