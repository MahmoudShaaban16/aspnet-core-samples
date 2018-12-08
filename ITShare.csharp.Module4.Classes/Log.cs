using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITShare.csharp.Module4.Classes
{
    class Log
    {
        public  virtual void LogMessage(string msg)
        {
            // clear memory
            Console.WriteLine(msg);
        }
    }

    class FileLog:Log
    {
        public override void LogMessage(string mesg)
        {
            base.LogMessage(mesg);
            FileStream st = new FileStream(@"C:\log.txt", FileMode.Append);
            try
            {
                
                StreamWriter stWriter = new StreamWriter(st);
                stWriter.Write(mesg);
            }
            catch(IOException ex)
            {
                throw;
            }

            finally
            {
                st.Close();
            }
            

            
            /// any extra logic to write to the file
        }
    }
}
