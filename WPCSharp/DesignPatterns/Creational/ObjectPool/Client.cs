using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.ObjectPool
{
    public class Client
    {
        public static void Execute()
        {
            var objectPool = new ObjectPool<Item>(1000, () => new Item());
            while (true)
            {
                var item = objectPool.Acquire();
                if (item == null) { 
                    Thread.Sleep(1);
                    continue;
                }
                item.IsVisible = true;
                Task.Delay(1000).ContinueWith(x => { item.IsVisible = false; objectPool.Release(item); });
            }
        }
    }
}
