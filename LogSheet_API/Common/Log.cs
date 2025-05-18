namespace LogSheet_API.Common
{
    public class Log
    {

        public Log() { }

        public static void WriteLog(string fromModule, string fromMethod,string errorSource,string errMesssage)
        {
            try
            {

                string sDate = DateTime.Now.ToString("yyyyMMdd");
                string sTime = DateTime.Now.Date.Ticks.ToString();

                FileStream logFile = new FileStream("./ErrorLogs/" + sDate + ".Log", FileMode.Append, FileAccess.Write);

                StreamWriter sw = new StreamWriter(logFile);

                sw.BaseStream.Seek(0, SeekOrigin.End);
                sw.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                sw.Write("LogTime: ");
                sw.WriteLine("{0} {1} ", DateTime.Now.ToLongDateString(),"");
                sw.WriteLine("FromModule: " + fromModule);
                sw.WriteLine("FromMethod: " + fromMethod);
                sw.WriteLine("ErrorSource: " + errorSource);    
                sw.WriteLine("ErrorMessage: " + errMesssage);

                try
                {
                    sw.WriteLine("User Name : " + Convert.ToString("User Name"));    
                }
                catch (IOException ioEx)
                {
                    sw.WriteLine("Machine: ()");
                    sw.WriteLine("");
                    sw.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    sw.Flush();
                    sw.Close();
                    sw.WriteLine("IO Error in writing log: " + ioEx.Message);
                }
                catch (Exception ex)
                {
                    sw.WriteLine("Machine: ()");
                    sw.WriteLine("");
                    sw.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    sw.Flush();
                    sw.Close();
                    sw.WriteLine("Error in writing log: " + ex.Message);
                }
                finally
                {
                    sw.Close();
                    logFile.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to log: {ex.Message}");
            }
        }
    }
}
