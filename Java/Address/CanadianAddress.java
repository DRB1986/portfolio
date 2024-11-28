import java.util.Scanner;

public class CanadianAddress {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Please enter a Canadian address in the format \"180 Main Street, Winnipeg, MB, R3C 1A6\":");

        String address = scanner.nextLine();

        // Validate
        if (!address.matches("[a-zA-Z0-9, ]+")) {
            System.out.println("Error: Address contains invalid characters.");
        } else {
        // Extract
            String[] components = address.split(",\\s*");
            
            if (components.length != 4) {
                System.out.println("Error: Address format is incorrect.");
            } else {
                String streetAndNumber = components[0].trim();
                String city = components[1].trim();
                String province = components[2].trim();
                String postalCode = components[3].trim();

        // Separate house number and street name
                String[] streetComponents = streetAndNumber.split(" ", 2);
                if (streetComponents.length != 2) {
                    System.out.println("Error: Street address format is incorrect.");
                } else {
                    String houseNumber = streetComponents[0].trim();
                    String streetName = streetComponents[1].trim();

        // Print 
                    System.out.println("House Number: " + houseNumber);
                    System.out.println("Street Name: " + streetName);
                    System.out.println("City: " + city);
                    System.out.println("Province: " + province);
                    System.out.println("Postal Code: " + postalCode);
                }
            }
        }

        scanner.close();
    }
}
