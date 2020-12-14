package com.company;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        System.out.println("Enter: ");
        Scanner Operation1 = new Scanner(System.in);
        int Num1 = Operation1.nextInt();

        FirstOperation(Num1);

        System.out.println("");

        System.out.println("Enter: ");
        Scanner NaturalNums = new Scanner(System.in);
        int Num2 = NaturalNums.nextInt();

        NaturalNum(Num2);

        System.out.println("");

        СounterOperation();


    }

    public static void FirstOperation(int Num1) {
        System.out.print("Output: ");
        for(int i = 1; i <= Num1; i++){
            System.out.print(i + " ");
        }
    }
    public static void NaturalNum(int Num2 ){

        if (Num2 % 2 == 0){
            System.out.print("Output: ");
            for(int i = Num2; i >= 2; i -= 2){
                System.out.print(i + " ");
            }
        }
        else{
            int num2 = Num2 - 1;
            System.out.print("Output: ");
            for(int i = num2; i >= 2; i -= 2){
                System.out.print(i + " ");
            }
        }
    }
    public static void СounterOperation(){
        int j = 10;
        System.out.print("Output: ");
            for (int i = 1; i <= 19; i++ ){
                if (i <10){
                    System.out.print(i + " ");
                }
                else{
                    System.out.print(j-- + " ");
                }
            }

    }
}
