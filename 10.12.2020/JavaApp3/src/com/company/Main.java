package com.company;
import java.util.Scanner;
import java.lang.String;

public class Main {

    public static void main(String[] args) {
	    System.out.println("Введите IP-адрес 1:");

        Scanner IPAdres11 = new Scanner(System.in);
        int IP11 = IPAdres11.nextInt();

        Scanner IPAdres12 = new Scanner(System.in);
        int IP12 = IPAdres12.nextInt();

        Scanner IPAdres13 = new Scanner(System.in);
        int IP13 = IPAdres13.nextInt();

        Scanner IPAdres14 = new Scanner(System.in);
        int IP14 = IPAdres14.nextInt();


        System.out.println("Введите IP-адрес 2:");

        Scanner IPAdres21 = new Scanner(System.in);
        int IP21 = IPAdres21.nextInt();

        Scanner IPAdres22 = new Scanner(System.in);
        int IP22 = IPAdres22.nextInt();

        Scanner IPAdres23 = new Scanner(System.in);
        int IP23 = IPAdres23.nextInt();

        Scanner IPAdres24 = new Scanner(System.in);
        int IP24 = IPAdres24.nextInt();


        System.out.println("Введите маску подсети:");

        Scanner Mask1 = new Scanner(System.in);
        int mask1 = Mask1.nextInt();

        Scanner Mask2 = new Scanner(System.in);
        int mask2 = Mask2.nextInt();

        Scanner Mask3 = new Scanner(System.in);
        int mask3 = Mask3.nextInt();

        Scanner Mask4 = new Scanner(System.in);
        int mask4 = Mask4.nextInt();

        System.out.println("IP-1: "+IP11+"."+IP12+"."+IP13+"."+IP14);

        System.out.println("IP-2: "+IP21+"."+IP22+"."+IP23+"."+IP24);

        System.out.print("Mask: "+mask1+"."+mask2+"."+mask3+"."+mask4);

    }
}
