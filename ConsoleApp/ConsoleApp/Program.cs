using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Client newClient = new Client();
            Client newClient2 = new Client();
            Client newClient3 = new Client();

            // Create Directory
            string path = @"C:\test_client";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            // Create a txt file in created directory
            string newFilePath = @"C:\test_client\test_client.txt";
            FileInfo newFile = new FileInfo(newFilePath);
            if (!newFile.Exists)
            {
                newFile.Create();
            }

            // Read that txt file line by line
            using (StreamReader sr = new StreamReader(newFilePath))
            {
                // First Client
                string firstLine = sr.ReadLine();

                string[] str = firstLine.Split(';');

                foreach (string s in str)
                {
                    newClient.ID = str[0];
                    newClient.passport_ID = str[1];
                    newClient.DebtSum = str[2];
                    Console.WriteLine($"{newClient.ID}, {newClient.passport_ID}, {newClient.DebtSum}");
                    break;
                }
                
                // Second Client
                string secondLine = sr.ReadLine();

                string[] str2 = secondLine.Split(';');

                foreach (string s in str2)
                {
                    newClient2.ID = str2[0];
                    newClient2.passport_ID = str2[1];
                    newClient2.DebtSum = str2[2];
                    Console.WriteLine($"{newClient2.ID}, {newClient2.passport_ID}, {newClient2.DebtSum}");
                    break;
                }

                // Third Client
                string thirdLine = sr.ReadLine();

                string[] str3 = thirdLine.Split(';');

                foreach (string s in str3)
                {
                    newClient3.ID = str3[0];
                    newClient3.passport_ID = str3[1];
                    newClient3.DebtSum = str3[2];
                    Console.WriteLine($"{newClient3.ID}, {newClient3.passport_ID}, {newClient3.DebtSum}");
                    break;
                }
            }

            // Change debt from txt file
            newClient.DebtSum = "58,75";
            newClient2.DebtSum = "19,50";
            newClient3.DebtSum = "42,00";
            string n1 = $"{newClient.ID}; {newClient.passport_ID}; {newClient.DebtSum}";
            string n2 = $"{newClient2.ID}; {newClient2.passport_ID}; {newClient2.DebtSum}";
            string n3 = $"{newClient3.ID}; {newClient3.passport_ID}; {newClient3.DebtSum}";

            // Create a new txt file
            string newFilePath2 = @"C:\test_client\test_client_changed.txt";
            FileInfo newFile2 = new FileInfo(newFilePath2);
            if (!newFile2.Exists)
            {
                newFile2.Create();
            }

            // Write changed info into new txt file
            using (StreamWriter sw = new StreamWriter(newFilePath2, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(n1);
                sw.WriteLine(n2);
                sw.WriteLine(n3);
            }
            
            Console.ReadKey();
        }
    }
}
