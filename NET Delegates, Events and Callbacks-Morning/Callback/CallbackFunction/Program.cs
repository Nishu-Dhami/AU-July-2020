using System;

namespace CallbackFunction
{
    public delegate void TaskCompleted(string taskResult);
    public class CallBack
    {
        public void StartNewTask(TaskCompleted taskCompleted)
        {
            Console.WriteLine("Initializing the task...");
            if (taskCompleted != null)
                taskCompleted("Task Finished!!!");
        }
    }
    public class CallBackTest
    {
        public void Test()
        {
            TaskCompleted callback = TestCallBack;
            CallBack testCallBack = new CallBack();
            testCallBack.StartNewTask(callback);
        }
        public void TestCallBack(string result)
        {
            Console.WriteLine(result);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CallBackTest callBackTest = new CallBackTest();
            callBackTest.Test();
            Console.ReadLine();
        }
    }
}
