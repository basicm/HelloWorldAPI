using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI
{
    public abstract class WriteData : IWriteData
    {
        private ConcurrentQueue<string> concurrentQueue = new ConcurrentQueue<string>();
        private Object locker = new Object();


        public abstract bool Write(string content);

        public async Task<bool> WriteAsync(string content)
        {
            int count = 10;
            concurrentQueue.Enqueue(content);

            while (concurrentQueue.Count > 0)
            {
                lock (locker)
                {
                    Task _task = Task.Run(() => WriteQueueData(count));
                    try
                    {
                        Task.WaitAll(new Task[] {_task});
                    }
                    catch (AggregateException ae)
                    {
                        throw ae.Flatten();
                    }
                }
            }
            return true;
        }

        private async Task WriteQueueData(int count)
        {
            string result;
            int inCount = 0;
            while (concurrentQueue.TryDequeue(out result) && (inCount++) <= count)
            {
                Write(result);
            }

        }
    }
}
