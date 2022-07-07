using System;

namespace GarbageCollector
{
    class Program
    {

        public static void Main()
        {

            // Disposed Event
            /*
            Test test = new Test();
            GC.Collect();
            test.Dispose();
            Console.ReadLine();
             */


            // Using param keyword for a class that returns params [] numbers summarized value 
            /*
            ParamKeyword pk = new ParamKeyword(1,1,3);
            var result = pk.result;
             */

        }




        class Test : IDisposable
        {
            protected virtual void Dispose(bool disposing) // can override
            {
                    if (disposing)
                    {
                          //managed code
                         //new keyworded objects
                    }
                    //unmanager codes
            }

            ~Test()
            {
                Dispose(false);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }
        }
    }
}
