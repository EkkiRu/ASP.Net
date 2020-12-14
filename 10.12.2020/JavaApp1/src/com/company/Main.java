package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	// write your code here
        System.out.println("Enter A:");
        Scanner NumA = new Scanner(System.in);
        double a = NumA.nextDouble();

        System.out.println("Enter B:");
        Scanner NumB = new Scanner(System.in);
        double b = NumB.nextDouble();

        if (b != 0){
            System.out.println("Остаток от деления: " + (a % b));
        }
        else {
            System.out.println("B = 0");
        }
    }
}
