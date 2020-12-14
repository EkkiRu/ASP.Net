package com.company;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        System.out.println("Введите первое число: ");
        Scanner Num1 = new Scanner(System.in);
        double num1 = Num1.nextDouble();

        System.out.println("Введите второе число: ");
        Scanner Num2 = new Scanner(System.in);
        double num2 = Num2.nextDouble();

        System.out.println("Введите третье число: ");
        Scanner Num3 = new Scanner(System.in);
        double num3 = Num3.nextDouble();

        double max = num1;
        double min = num1;



        if (num2 < min){
            min = num2;
        }
        if (num3 < min){
            min = num3;
        }

        if (num2 > max){
            max = num2;
        }
        if (num3 > max){
            max = num3;
        }

        System.out.println("max: "+max);
        System.out.println("min: "+min);


    }
}
