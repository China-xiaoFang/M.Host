using System;
using System.IO;

namespace M.Helper.Log
{
    /// <summary>
    /// 日志服务
    /// </summary>
    public class LogHelper
    {
        // 在程序根目录下创建日志记录（bin>debug>logs）
        public static string path = AppDomain.CurrentDomain.BaseDirectory + "logs";

        // 死锁
        public static object logLock = new object();

        public static void Debug(string type, string content)
        {
            WriteLog("Debug_" + type, content);
        }

        public static void Info(string type, string content)
        {
            WriteLog("Info_" + type, content);
        }

        public static void Error(string type, string content)
        {
            WriteLog("Error_" + type, content);
        }

        protected static void WriteLog(string type, string contene)
        {
            lock (logLock)
            {
                // 判断日志目录是否存在
                if (!Directory.Exists(path))
                {
                    // 创建日志目录
                    Directory.CreateDirectory(path);
                }
                // 获取当前系统时间
                string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff");
                // 用日期对日志文件命名
                string fileName = path + "/" + DateTime.Now.ToString("yyyy-MM-dd") + ".log";
                // 创建或打开日志，向日志文件末尾追加记录
                StreamWriter streamWriter = File.AppendText(fileName);
                // 向日志文件写入内容
                string writeContext = time + " " + type + "：" + contene;
                streamWriter.WriteLine(writeContext);
                // 关闭日志文件
                streamWriter.Close();
            }
        }
    }
}