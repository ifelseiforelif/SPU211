using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;


namespace Lesson_25_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Info("Первая запись в лог файле");
            logger.Warn("Была небольшая ошибка");
        }
    }
}
