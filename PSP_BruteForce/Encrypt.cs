namespace PSP_BruteForce;

using System;
using System.Security.Cryptography;
using System.Text;


public class Encrypt
{
    public static string PickHash(string[] args)
    {
        try
        {
            string filePath = "password.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("El archivo password.txt no se encuentra");
            }

            string[] passwords = File.ReadAllLines(filePath);
            if (passwords.Length == 0)
            {
                Console.WriteLine("El archivo password.txt no tiene nada");
            }
            
            Random random = new Random();
            int randomIndex = random.Next(passwords.Length);
            string randomPassword = passwords[randomIndex];
            string hashedPassword = ComputeHash(randomPassword);
            Console.WriteLine($"Contraseña elegida al azar: {randomPassword}");
            Console.WriteLine($"Hash generado: {hashedPassword}");
            return hashedPassword;
            
        } catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
            return "";
        }
    }
    
    
    private static string ComputeHash(string input)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder builder = new StringBuilder();

            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }

            return builder.ToString();
        }
    }
    
}