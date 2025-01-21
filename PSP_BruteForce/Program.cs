namespace PSP_BruteForce;

using System;


public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            string hashTarget = Encrypt.PickHash(args);
            if (string.IsNullOrEmpty(hashTarget))
            {
                Console.WriteLine("Error: No se pudo generar un hashTarget");
                return;
            }
            
            string filePath = "../../../passwords.txt";
            BruteForce bruteForce = new BruteForce();
            string resultado = bruteForce.FindPassword(filePath, hashTarget);
            
            Console.WriteLine($"Resultado del ataque de fuerza bruta: {resultado}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    
}