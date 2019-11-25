package ted;
import java.util.*;
public class AdivinaActualizado {

	public static void main(String[] args) {
		Scanner sc=new Scanner(System.in);
		
		int numero;
		int contador=0;
		int aleatorio;
		
		aleatorio=(int)(Math.random()*100)+1;
		
		System.out.println(aleatorio);
		
		
		do {
			System.out.println("Introduce un numero ");
			numero=sc.nextInt();
		if (aleatorio<numero) {
			System.out.println("Introduciste un numero que es mayor");
		}
		else if (aleatorio==numero) {
			System.out.println("Enhorabuena adivinaste el numero ");
		}
		else {
			System.out.println("Introduciste un numero menor ");
		}
		
	   }while (numero!= aleatorio);
		

	}

}
