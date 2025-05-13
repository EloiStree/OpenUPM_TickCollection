namespace Eloi.Tick
{
    public class TickMono_OnPauseStop : TickMono_AbstractDefault
    {
        
        void OnApplicationPause(bool pause)
        {
            if (!pause)
            {
                base.TriggerTick();
            }
        }
    }

}