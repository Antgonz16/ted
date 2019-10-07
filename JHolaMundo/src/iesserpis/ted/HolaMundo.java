package iesserpis.ted;

import java.io.InputStream;
import java.util.Scanner;

public class HolaMundo {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("Introduce tu nombre; ");
		String nombre= scanner.nextLine();
		
		System.out.print("Introduce tu edad" );
		int edad= scanner.nextInt();
		
		System.out.println("Hola " + nombre + " desde el año que viene tendrás " + (edad + 1));

	}
	}


