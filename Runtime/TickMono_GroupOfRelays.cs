using System.Collections.Generic;
namespace Eloi.Tick
{

public class TickMono_GroupOfRelays : TickMono_AbstractDefault
{

    public override void ChildrenAdditionalInvoke()
    {
        RelayAll();
    }
    public List<TickMono_Relay> m_relayList;
    private void RelayAll()
    {
        foreach (var item in m_relayList)
        {
            if (item)
                item.TriggerTick();
        }
    }
}

}