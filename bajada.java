package escalera;
import java.util.Scanner;
public class bajada {

	public static void main(String[] args) {
		Scanner sc=new Scanner(System.in);
			int altura;
			  System.out.println("Introduzca la altura");
			  altura=sc.nextInt();
				for (int numeroasteriscos=altura;numeroasteriscos>0;numeroasteriscos--){
					//Este bucle pinta los asteriscos de cada fila
					for (int i=numeroasteriscos;i>0;i--) {
						System.out.print("*");
						
					}
					    System.out.println("");
				}

	}

}
