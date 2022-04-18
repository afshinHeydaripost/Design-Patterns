using Microsoft.AspNetCore.Mvc;
using RPCoreLib;
using RPCoreLib.Security;

namespace Design_Patterns.Class
{
    public sealed class SingelTon
    {
        private static volatile SingelTon instance;
        private static object _lock = new object();


        private SingelTon() { }

        public static SingelTon GetInstance()
        {
            if (instance is null)
            {
                lock (_lock)
                {
                    if (instance is null)
                        instance = new SingelTon();
                }
            }
            return instance;
        }


        public int grti()
        {
            return 5 + 5;
        }
    }
}