import java.time.LocalDate;
import java.util.Scanner;

public class AgeCalculator {
    public static void main(String[] args) {
        try (Scanner scanner = new Scanner(System.in)) {
            System.out.println("Please enter your birth date.");
            System.out.print("Month: ");
            int birthMonth = scanner.nextInt();
            
            System.out.print("Day: ");
            int birthDay = scanner.nextInt();
            
            System.out.print("Year: ");
            int birthYear = scanner.nextInt();
            
            LocalDate currentDate = LocalDate.now();
            int currentDay = currentDate.getDayOfMonth();
            int currentMonth = currentDate.getMonthValue();
            int currentYear = currentDate.getYear();
            
            int age = currentYear - birthYear;
            
            // Check if the birthday has passed this year
            if (currentMonth < birthMonth || (currentMonth == birthMonth && currentDay < birthDay)) {
                age--;
            }
            
            System.out.println("You are " + age + " years old!");
        }
    }
}
