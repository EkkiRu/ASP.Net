package com.company;
import java.util.Scanner;
import java.lang.String;

public class Main {

    public static void main(String[] args) {
	// программа определяющая S круга
        System.out.println("Введите диаметр круга: ");
        Scanner DScan = new Scanner(System.in);
        double diameter = DScan.nextDouble();

        Square(diameter);

    }

    public static void Square(double diameter){
        // S = d^2 : 4 * pi
        final double pi = 3.14159265;

        double S = Math.pow(diameter, 2) / 4 * pi;

        System.out.println("Площадь круга равна: "+S);
    }
}
