using System.Timers;
namespace BeatService
{
    public class BeatHelp
    {
        private readonly System.Timers.Timer _timer;
        public BeatHelp()
        {
            _timer=new System.Timers.Timer(1000){AutoReset=true};
            _timer.Elapsed+=TimerElapsed;
        }
        private void TimerElapsed(object sender, ElapsedEventArgs args)
        {
            string[] lines=new string[]{DateTime.Now.ToString()};
            // System.IO.File.AppendAllLines(@"C:\Temp\beater.txt",lines);
            Console.WriteLine(DateTime.Now.ToString());
        }   
        public void Start()
        {
            _timer.Start();
        }
        public void Stop()
        {
            _timer.Stop();
        }
    }
}