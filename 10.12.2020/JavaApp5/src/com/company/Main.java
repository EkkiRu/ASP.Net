package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        System.out.println("Number: ");
	    Scanner Number = new Scanner(System.in);
	    int day = Number.nextInt();

        System.out.println("Month");
        Scanner Month = new Scanner(System.in);
        int month = Month.nextInt();

        System.out.println("Year");
        Scanner Year = new Scanner(System.in);
        int year = Year.nextInt();

        if (day < 1 || month < 1 || month > 12 || (year < 1)) {
            System.out.println("Неверная дата");
        }
        else if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10) && (day > 31)) {
            System.out.println("Неверная дата. В месяце 31 день.");
        }
        else if ((month == 2) && ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) && (day > 29)) {
            System.out.println("Неверная дата. Год високосный. В месяце 29 дней.");
        }
        else if ((month == 2) && ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) && (day > 28)) {
            System.out.println("Неверная дата. В месяце 28 дней.");
        }
        else if ((month == 4 || month == 6 || month == 9 || month == 11) && (day > 30)) {
            System.out.println("Неверная дата. В месяце 30 дней.");
        }
        else {
            if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10) && (day == 31)) {
                day = 1;
                month++;
            }
            else if ((month == 4 || month == 6 || month == 9 || month == 11) && (day == 30)) {
                day = 1;
                month++;
            }
            else if (month == 12 && day == 31){
                year++;
                day = 1;
                month = 1;
            }
            else {
                day++;
            }
        }

        if (day < 10 && month < 10) {
            System.out.printf("0%d.0%d.%d", day, month, year);
        } else if (day < 10){
            System.out.printf("0%d.%d.%d", day, month, year);
        } else if (month < 10) {
            System.out.printf("%d.0%d.%d", day, month, year);
        } else {
            System.out.printf("%d.%d.%d", day, month, year);
        }

    }
}
