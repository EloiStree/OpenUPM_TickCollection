
using UnityEngine;
using UnityEngine.Events;

public class TickMono_AbstractDefault : MonoBehaviour
{
    public UnityEvent m_onTick;

    [ContextMenu("Invoke the action tick")]
    public void TriggerTick()
    {
        m_onTick.Invoke();
        ChildrenAdditionalInvoke();
    }

    public virtual void ChildrenAdditionalInvoke(){}
}
