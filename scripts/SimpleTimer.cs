using Godot;

namespace gdlib
{
    public class SimpleTimer
    {
        public ulong? startTime;
        public double duration = 0.0;
        public double elapsedTime = 0.0;

        public SimpleTimer(double duration = 0.0)
        {
            this.duration = duration;
        }

        public void start()
        {
            startTime = Time.GetTicksMsec();
        }

        public double elapsed()
        {
            ulong now = Time.GetTicksMsec();
            double elapsed = (double)(now - startTime) / 1000;

            elapsedTime = elapsed;
            return elapsed;
        }

        public bool expired()
        {
            ulong now = Time.GetTicksMsec();
            double elapsed = (double)(now - startTime) / 1000;

            elapsedTime = elapsed;
            return elapsed >= duration;
        }
    }
}
