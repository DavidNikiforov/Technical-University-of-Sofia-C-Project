using System;
using System.IO;

namespace UserLogin
{
    public class Logger
    {
        private static readonly string LogFilePath = "log.txt";

        public static void LogActivity(string activity)
        {
            string logEntry = $"{DateTime.Now}: {activity}";

            // Записваме лога в текстов файл
            using (StreamWriter writer = new StreamWriter(LogFilePath, true))
            {
                writer.WriteLine(logEntry);
            }

            // Извеждаме лога и на конзолата
            Console.WriteLine(logEntry);
        }
    }
}
