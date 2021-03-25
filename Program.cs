using System;

namespace SetLogonAsService
{
    class Program
    {
        static void Main(string[] args)
        {
            String userName = args[0];
            try
            {
                LsaWrapper lsaUtility = new LsaWrapper();
            
                lsaUtility.SetRight(userName, "SeServiceLogonRight");
            
                Console.WriteLine("Logon as a Service right is granted successfully to " + userName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
