import java.util.Scanner;

public class ShapeGenerator {

    public static void main(String[] args) {
        try (Scanner scanner = new Scanner(System.in)) {
            int choice;

            do {
                System.out.println("Menu:");
                System.out.println("1. Exit");
                System.out.println("2. Draw a line");
                System.out.println("3. Draw a rectangle");
                System.out.println("4. Draw a triangle");
                System.out.print("Enter your choice: ");
                choice = scanner.nextInt();

                switch (choice) {
                    case 1 -> System.out.println("Exiting...");
                    case 2 -> {
                        System.out.print("Enter the length of the line: ");
                        int length = scanner.nextInt();
                        drawLine(length);
                    }
                    case 3 -> {
                        System.out.print("Enter the length of the rectangle: ");
                        int rectangleLength = scanner.nextInt();
                        System.out.print("Enter the width of the rectangle: ");
                        int rectangleWidth = scanner.nextInt();
                        drawRectangle(rectangleLength, rectangleWidth);
                    }
                    case 4 -> {
                        System.out.print("Enter the side length of the triangle: ");
                        int triangleSideLength = scanner.nextInt();
                        drawTriangle(triangleSideLength);
                    }
                    default -> System.out.println("Invalid choice!");
                }
            } while (choice != 1);
        }
    }

    public static void drawLine(int length) {
        for (int i = 0; i < length; i++) {
            System.out.print("#");
        }
        System.out.println();
    }

    public static void drawRectangle(int length, int width) {
        for (int i = 0; i < width; i++) {
            drawLine(length);
        }
    }

    public static void drawTriangle(int sideLength) {
        for (int i = 1; i <= sideLength; i++) {
            drawLine(i);
        }
    }
}
