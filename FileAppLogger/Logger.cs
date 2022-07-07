using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAppLogger
{
    public class Logger
    {
        private static string _logFilePath = @"D:\TempLog\MyFileAppLogs.log";

        public static void LogToFile(string message)
        {
            try
            {
                File.AppendAllText(_logFilePath, $"{DateTime.Now.ToShortDateString()}--{DateTime.Now.ToShortTimeString()}--\t {message} \n\n");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
