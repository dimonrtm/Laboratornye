package sample;

import javafx.scene.control.Button;
import javafx.scene.control.TreeItem;
import javafx.scene.control.TreeView;
import javafx.scene.input.MouseEvent;

import java.io.File;
import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.Stack;

public class Controller {
    public Button button1;
    public TreeView<String> tree;

    public void GetPath(MouseEvent mouseEvent) {
        String path = "D:\\";
        TreeItem<String> root = new TreeItem<String>(path);
        root.setExpanded(false);
        Stack<File> stackFile = new Stack<File>();
        Stack<String> stackString = new Stack<String>();
        File file = new File(path);
        File [] files=file.listFiles();
        String [] fileNames=file.list();
        Collections.addAll(stackFile,files);
        Collections.addAll(stackString,fileNames);
        createRoot(root,stackString,stackFile);
       /* stackFile.push(file);
        stackString.push(path);
        TreeItem<String> temp = new TreeItem<String>();
        while (!stackFile.isEmpty() && !stackString.isEmpty()) {
            File dirOrFile = stackFile.pop();
            TreeItem<String> first = createNode(dirOrFile, stackString, stackFile);
            if(first.getValue().equals(path)) {
                root = first;
            }
            temp.getChildren().addAll(first);
            if(!stackFile.isEmpty()) {
                dirOrFile = stackFile.pop();
            }
            TreeItem<String> second = createNode(dirOrFile, stackString, stackFile);
            first.getChildren().addAll(second);
            temp = second;

        }*/
        tree.setRoot(root);
    }
           /* File fileDir = stack.pop();
            root=new TreeItem<String>(fileDir.getName());
        System.out.println(fileDir.getName());
            if(fileDir.isDirectory()) {ro
                File[] files = fileDir.listFiles();
                for (int i = 0; i < files.length; i++)
                    stack.push(files[i]);
            }*/


    public static void createRoot(TreeItem<String> root, Stack<String> _stackString, Stack<File> _stackFile) {

        while((!_stackFile.isEmpty())&&(!_stackString.isEmpty()))
        {
            File dirOrFile=_stackFile.pop();
            String dirOrFileName=_stackString.pop();
            TreeItem<String> treeitem=new TreeItem<String>(dirOrFileName);
            treeitem.setExpanded(false);
            root.getChildren().add(treeitem);
            System.out.println(dirOrFileName);

            if(dirOrFile.isDirectory())
            {
                Stack<File> stackFile=new Stack<File>();
                Stack<String> stackString=new Stack<String>();
                File[] files=dirOrFile.listFiles();
                String [] fileNames=dirOrFile.list();
                Collections.addAll(stackFile,files);
                Collections.addAll(stackString,fileNames);
                createRoot(treeitem,stackString,stackFile);
            }
        }
       /* TreeItem<String> treeItem = new TreeItem<String>(",dhdbd");
            if (_dirOrFile.isDirectory()) {

                String s = " ";
                if (!_stackString.isEmpty()) {
                    s = _stackString.pop();
                }
                System.out.println(s);
                treeItem = new TreeItem<String>(s);
                treeItem.setExpanded(true);
                File[] files = _dirOrFile.listFiles();
                String[] fileNames = _dirOrFile.list();
                ArrayList<File>listFiles=new ArrayList<File>();
                Collections.addAll(listFiles, files);
                _stackFile.addAll(listFiles);
                ArrayList<String> listString=new ArrayList<String>();
                Collections.addAll(listString,fileNames);
                _stackString.addAll(listString);*/
               /* if (files != null && fileNames != null) {
                    for (int i = 0; i < files.length; i++) {
                        _stackFile.push(files[i]);
                        _stackString.push(fileNames[i]);
                    }
                }*/
               /* return treeItem;
            } else {
                if (!_stackString.isEmpty()) {
                    String s = _stackString.pop();
                    System.out.println(s);
                    treeItem = new TreeItem<String>(s);
                    treeItem.setExpanded(true);
                }
            }

        return treeItem;*/
    }
}



