namespace PSP_BruteForce;

using System;
using System.IO;


public class BruteForce
{
    public string FindPassword(string filePath, string targetHash)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("El archivo passwords.txt no se encuentra");
        }
        
        string[] passwords = File.ReadAllLines(filePath);
        foreach (string password in passwords)
        {
            string hashedPassword = Encrypt.ComputeHash(password);
            Console.WriteLine($"Probando contraseña: {password} -> Hash: {hashedPassword}");


            if (hashedPassword == targetHash)
            {
                return password;
            }
        }

        return "No se ha encontrado ninguna coincidencia";
    }
    
}