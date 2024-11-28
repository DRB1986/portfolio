import java.util.Scanner;

public class sapv {
    public static void main(String[] args) {
    
        Scanner scanner = new Scanner(System.in);

        // Tell the user to enter the side length
        System.out.print("Please enter the side length: ");
        double sideLength = scanner.nextDouble();

        // Calculate the area
        double area = Math.pow(sideLength, 2);

        // Calculate the perimeter
        double perimeter = 4 * sideLength;

        // Calculate the volume of the cube
        double volume = Math.pow(sideLength, 3);

        // Print results
        System.out.println("Area: " + area);
        System.out.println("Perimeter: " + perimeter);
        System.out.println("Volume: " + volume);

    
        scanner.close();
    }
}
