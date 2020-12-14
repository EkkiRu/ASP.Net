package com.company;

public class Main {

    public static void main(String[] args) {
        int i, j, k;
        k = 0;
        for (i = 1; i < 10; i = i + 1)k = k + i;
        System.out.println("Значение k: " + k);
        k = 0;
        for (i = 2; i < 10; i = i + 2)k = k + i;
        System.out.println("Значение k: " + k);
        k = 0;
        for (i = 1, j = 5; (i < 5) && (j > 1); i++, j--) k = k + i * j;
        System.out.println("Значение k: " + k);
        k = 0;
        for (i = 1; i < 5; i++)
        {
            if (i == 3) continue;
            k = k + i;
        }
        System.out.println("Значение k: " + k);
        k = 0;
        for (i = 1; i < 10; i++)
        {
            k = k + i;
            if (i == 6) break;
        }
        System.out.println("Значение k: " + k);

        PyramidForm();
    }

    public static void PyramidForm(){
        int x = 0;
        for (int i = 10; i >= x; i--){
            for(int j= 10 ;j >= i; j--){
                System.out.print(j + " ");
            }
            System.out.println();
        }
    }
}
