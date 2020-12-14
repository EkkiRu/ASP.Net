package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	// ax+b = 0

        System.out.println("Enter a: ");
        Scanner NumA = new Scanner(System.in);
        double a = NumA.nextDouble();

        System.out.println("Enter b: ");
        Scanner NumB = new Scanner(System.in);
        double b = NumB.nextDouble();

        Equation(a, b);
    }

    public static void Equation(double a, double b){
        //ax+b = 0

        if(a != 0) {
            double x = -b/a;
            System.out.println("result is " +x);
        } else {s
            System.out.println("result is infinity");
        }

    }
}
