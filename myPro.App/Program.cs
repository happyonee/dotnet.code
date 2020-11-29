using System;
using StackExchange.Redis;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;

namespace myPro.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("192.168.202.129:6379");

            IDatabase db = redis.GetDatabase();

            var batch = db.CreateBatch();
            Task t1 = batch.StringSetAsync("name", "bob");
            Task t2 = batch.StringSetAsync("age", 100);
            batch.Execute();
            Task.WaitAll(t1, t2);
            Console.WriteLine("Age:" + db.StringGet("age"));
            Console.WriteLine("Name:" + db.StringGet("name"));
        }
    }
}
