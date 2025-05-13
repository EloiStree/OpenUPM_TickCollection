namespace Eloi.Tick
{
    public class TickMono_OnPauseStart : TickMono_AbstractDefault
    {
      
        void OnApplicationPause(bool pause)
        {
            if (pause)
            {
                base.TriggerTick();
            }
        }
    }

}