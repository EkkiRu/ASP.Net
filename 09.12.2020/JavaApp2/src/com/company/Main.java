package com.company;
import java.util.Scanner;

public class Main {



    public static void main(String[] args) {
	// Капитал прожиточного минимума
        System.out.println("Введите сумму стартового капитала: ");
        Scanner StartCapital = new Scanner(System.in);
        int startCapital = StartCapital.nextInt();

        System.out.println("Введите процентную ставку: ");
        Scanner InterestRate = new Scanner(System.in);
        double interestRate = InterestRate.nextDouble();

        SavingsDeposit(startCapital, interestRate);

    }

    public static void SavingsDeposit(int startCapital, double interestRate)
    {
        // startCapital*(1+interestRate*time)
        final int time = 3;
        double finalCapital = startCapital*(1+(interestRate/100)*time);
        System.out.println(finalCapital);
    }
}
