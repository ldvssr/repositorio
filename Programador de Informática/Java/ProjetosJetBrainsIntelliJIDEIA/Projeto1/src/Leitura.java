import java.util.Scanner;

public class Leitura
{
    public String ler()
    {
        Scanner scans = new Scanner(System.in);  // Create a Scanner object
        String validation = scans.nextLine();  // Read user input
        System.out.println("Username is: " + validation);  // Output user input
        scans.close();
        return validation;
    }
}
