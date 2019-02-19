package com.example.lab9;

import android.net.Uri;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import com.google.android.gms.appindexing.Action;
import com.google.android.gms.appindexing.AppIndex;
import com.google.android.gms.appindexing.Thing;
import com.google.android.gms.common.api.GoogleApiClient;

import java.util.Stack;

public class MainActivity extends AppCompatActivity {
    private EditText edit;
    String number = "";
    Stack<Double> numbers = new Stack<Double>();
    Stack<String> operators = new Stack<String>();
    double x;
    String op;
    /**
     * ATTENTION: This was auto-generated to implement the App Indexing API.
     * See https://g.co/AppIndexing/AndroidStudio for more information.
     */
    private GoogleApiClient client;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        edit = (EditText) findViewById(R.id.editText3);
    }

    public void zero(View view) {
        number += "0";
        edit.setText(number, TextView.BufferType.EDITABLE);
    }

    public void one(View view) {
        number += "1";
        edit.setText(number, TextView.BufferType.EDITABLE);
    }

    public void two(View view) {
        number += "2";
        edit.setText(number, TextView.BufferType.EDITABLE);
    }

    public void three(View view) {
        number += "3";
        edit.setText(number, TextView.BufferType.EDITABLE);
    }

    public void four(View view) {
        number += "4";
        edit.setText(number, TextView.BufferType.EDITABLE);
    }

    public void five(View view) {
        number += "5";
        edit.setText(number, TextView.BufferType.EDITABLE);
    }

    public void six(View view) {
        number += "6";
        edit.setText(number, TextView.BufferType.EDITABLE);
    }

    public void seven(View view) {
        number += "7";
        edit.setText(number, TextView.BufferType.EDITABLE);
    }

    public void eight(View view) {
        number += "8";
        edit.setText(number, TextView.BufferType.EDITABLE);
    }

    public void nine(View view) {
        number += "9";
        edit.setText(number, TextView.BufferType.EDITABLE);
    }

    public void dot(View view) {
        number += ".";
        edit.setText(number, TextView.BufferType.EDITABLE);
    }

    public void summ(View view) {
        if (number == null) {
            number = edit.getText().toString();
        }
        double a = Double.parseDouble(number);
        number="";
        if(operators.size()==0)
        {
          numbers.push(a);
            operators.push("+");
        }
        else
        {
          selectOperator(a,"+");
        }
    }

    private void selectOperator(double a, String operator) {
        switch (operators.pop()) {
            case "+":
                a = numbers.pop() + a;
                String s = "";
                s += a;
                edit.setText(s, TextView.BufferType.EDITABLE);
                numbers.push(a);
                operators.push(operator);
                break;
            case "-":
                a = numbers.pop() - a;
                s = "";
                s += a;
                edit.setText(s, TextView.BufferType.EDITABLE);
                numbers.push(a);
                operators.push(operator);
                break;
            case "*":
                a = numbers.pop() * a;
                s = "";
                s += a;
                edit.setText(s, TextView.BufferType.EDITABLE);
                numbers.push(a);
                operators.push(operator);
                break;
            case "/":
                if (a != 0) {
                    a = numbers.pop() / a;
                    s = "";
                    s += a;
                    edit.setText(s, TextView.BufferType.EDITABLE);
                    numbers.push(a);
                    operators.push(operator);
                } else {
                    edit.setText("Деление на ноль", TextView.BufferType.EDITABLE);
                    numbers.pop();
                }
                break;
            default:
                s = "";
                edit.setText("Это не оператор", TextView.BufferType.EDITABLE);
        }
    }

    public void substract(View view) {
        if (number == null) {
            number = edit.getText().toString();
        }
        double a = Double.parseDouble(number);
        number = "";
        if(operators.size()==0)
        {
            numbers.push(a);
            operators.push("-");
        }
        else
        {
            selectOperator(a,"-");
        }

    }

    public void division(View view) {
        if (number == null) {
            number = edit.getText().toString();
        }
        double a = Double.parseDouble(number);
        number="";
        if(operators.size()==0)
        {
            numbers.push(a);
            operators.push("/");
        }
        else {
            selectOperator(a, "/");
        }

    }

    public void multiply(View view) {
        if (number == null) {
            number = edit.getText().toString();
        }
        double a = Double.parseDouble(number);
        number = "";
        if(operators.size()==0)
        {
          numbers.push(a);
            operators.push("*");
        }
        else {
            selectOperator(a, "*");
        }
    }

    public void sqrt(View view) {
        if (number == null) {
            number = edit.getText().toString();
        }
        double a = Double.parseDouble(number);
        number = "";
        if(operators.size()==0)
        {
         if(a>0)
         {
             a=Math.sqrt(a);
             String s = "";
             s += a;
             edit.setText(s, TextView.BufferType.EDITABLE);
             numbers.push(a);
         }
        }
        else
        {
            if(a>0) {
                switch (operators.pop()) {
                    case "+":
                        a = numbers.pop() + Math.sqrt(a);

                        String s = "";
                        s += a;
                        edit.setText(s, TextView.BufferType.EDITABLE);
                        numbers.push(a);
                        break;
                    case "-":
                        a = numbers.pop() - Math.sqrt(a);

                        s = "";
                        s += a;
                        edit.setText(s, TextView.BufferType.EDITABLE);
                        numbers.push(a);
                        break;
                    case "*":
                        a = numbers.pop() * Math.sqrt(a);

                        s = "";
                        s += a;
                        edit.setText(s, TextView.BufferType.EDITABLE);
                        numbers.push(a);
                        break;
                    case "/":
                        if (a != 0) {
                            a = numbers.pop() / Math.sqrt(a);
                            s = "";
                            s += a;
                            edit.setText(s, TextView.BufferType.EDITABLE);
                            numbers.push(a);
                        }
                        break;
                    default:
                        s = "";
                        edit.setText("Это не оператор", TextView.BufferType.EDITABLE);
                }

            }
            else
            {
                edit.setText("Корень из отрицательного числа", TextView.BufferType.EDITABLE);
            }
        }
    }

    public void clear(View view) {
        numbers.clear();
        operators.clear();
        number = "";
        edit.setText("0", TextView.BufferType.EDITABLE);
    }

    public void equal(View view) {
        if (number == null) {
            number = edit.getText().toString();
        }
        double a = Double.parseDouble(number);
        number = "";
        if(operators.size()==0)
        {
            String s = "";
            s += a;
            edit.setText(s, TextView.BufferType.EDITABLE);
        }
        else
        {
            op=operators.pop();
            switch(op)
            {
                    case "+":
                        a = numbers.pop() + a;
                        String s = "";
                        s += a;
                        edit.setText(s, TextView.BufferType.EDITABLE);
                        x = a;
                        numbers.push(a);
                        break;
                    case "-":
                        a = numbers.pop() - a;
                        s = "";
                        s += a;
                        edit.setText(s, TextView.BufferType.EDITABLE);
                        x = a;
                        numbers.push(a);
                        break;
                    case "*":
                        a = numbers.pop() * a;
                        s = "";
                        s += a;
                        edit.setText(s, TextView.BufferType.EDITABLE);
                        x = a;
                        numbers.push(a);
                        break;
                    case "/":
                        if (a != 0) {
                            a = numbers.pop() / a;
                            s = "";
                            s += a;
                            edit.setText(s, TextView.BufferType.EDITABLE);
                            x = a;
                            numbers.push(a);
                        } else {
                            edit.setText("Деление на ноль", TextView.BufferType.EDITABLE);
                            operators.pop();
                        }
                        break;
                case "=":a=a+x;
                    s = "";
                    s += a;
                    edit.setText(s, TextView.BufferType.EDITABLE);
                    numbers.push(a);
                    default:
                        s = "";
                        edit.setText("Это не оператор", TextView.BufferType.EDITABLE);
                }
            }
        }

    }
