package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        System.out.println("Введите фиксированную стоимость продукта: ");
        Scanner FixPrice = new Scanner(System.in);
        int fixPrice = FixPrice.nextInt();

        System.out.println("Введите стоимость продукта: ");
        Scanner ProductPrice = new Scanner(System.in);
        int productPrice = ProductPrice.nextInt();

        System.out.println("Введите стоимость производства для продукта: ");
        Scanner ExpensesPrice = new Scanner(System.in);
        int expensesPrice = ExpensesPrice.nextInt();

        System.out.println("Введите количество продукта: ");
        Scanner QuantityProduct = new Scanner(System.in);
        int quantityProduct = QuantityProduct.nextInt();

        ProfitCalculation(fixPrice, productPrice, expensesPrice, quantityProduct);

    }

    public static void ProfitCalculation(int fixPrice, int productPrice, int expensesPrice, int quantityProduct){

        double finalPrice = 0;

        for (int i = 0; i <  quantityProduct; i++){
            if (fixPrice >= expensesPrice){
                // выручка - себестоимость
                fixPrice -=expensesPrice;
                finalPrice += (productPrice - expensesPrice);
                fixPrice += finalPrice;
            }
            else{
                System.out.println("Стоимость производства превышает фиксированую стоимость(.");
                break;
            }
        }
        System.out.println("Прибыль: " + finalPrice);


    }
}
