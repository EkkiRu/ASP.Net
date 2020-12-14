package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        int quantity = 0;
        Scanner Number = new Scanner(System.in);
        int num;
        int min = Integer.MIN_VALUE;
        int max = Integer.MAX_VALUE;


        do{
            System.out.print("Введите число " + (quantity++) + " :");
            num = Number.nextInt();




        }
        while(num != 0);

        System.out.print("Вы ввели "+ quantity + " числа!");

    }

    public static void MaxMin(int num){

    }
}
