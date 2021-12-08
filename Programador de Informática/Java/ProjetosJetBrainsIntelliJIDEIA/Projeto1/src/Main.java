import java.util.Objects;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        String validation;
        String username = "abc";
        Escrita esc = new Escrita();
        Leitura lei = new Leitura();
        int repetir = 1;
        while (repetir == 1)
        {
            esc.escrever();
            /*
            esc.escrever();
            validation = lei.ler();
            if (Objects.equals(validation, username))
            {
                System.out.println("Username Match");
            }
            else
            {
                System.out.println("Username Mismatch");
            }
            System.out.println("Deseja repetir? 0 - Não / 1 - Sim");

            Scanner scan = new Scanner(System.in);  // Create a Scanner object
            int controlo;
            controlo = (scan.nextInt()); // Read user input
            //scans.close();

            if (controlo == 1)
            {
                repetir = 1;
            }
            else
            {
                repetir = 0;
            }
             */
        }
    }
}