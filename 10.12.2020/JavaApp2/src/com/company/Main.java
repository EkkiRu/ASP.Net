package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	// write your code here
        System.out.println("Enter A:");
        Scanner NumA = new Scanner(System.in);
        double a = NumA.nextDouble();

        System.out.println("1: " + (a*2));
        System.out.println("2: " + (a*4));
        System.out.println("3: " + (a*32));
    }
}
