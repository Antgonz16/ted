package ted;

import java.util.Scanner;

public class JAdivina {



    public static void main(String[] args) {
       Scanner sc= new Scanner(System.in);
       //Declaramos variables
       int vidas=6;
       int num=1;
       int aleatorio;
       //Ponemos la variable que genera números aleatorios.
       aleatorio=(int)(Math.random()*100);
       //Creamos la primera condición
       //Mientras vidas mayor que 0 y numero distinto a aleatorio, realizar operación.
       while (vidas>0 && num!=aleatorio);
       {
    	System.out.println("Introduzca un numero");
    	num=sc.nextInt();
       }
       if (num==aleatorio) {
    	 System.out.println("Acertaste el numero");  
       }
       //Si no se cumple la condición
       else if (num!=aleatorio)
       {
    	   //Creamos otra condición más
    	if (num>aleatorio) {
    	 System.out.println("Demasiado alto, intentelo de nuevo");
    	 vidas--;
    	} else if(num<aleatorio)
    	{
    		System.out.println("Demasiado bajo, intentelo de nuevo");
    		vidas--;
    	}
       }
            if (vidas==0);
            {
            System.out.println("Perdiste el numero aleatorio es " + aleatorio);	
            }
    }

}