using UnityEngine;
using UnityEngine.Events;

public class TickMono_OnCollisionWithAny : MonoBehaviour
{
    [Tooltip("Specify which layers should trigger the event.")]
    public LayerMask m_layerMask= ~0; 

    public bool m_useCollision = true;
    public bool m_useTrigger = true;

    public UnityEvent m_onTick;

    private void OnCollisionEnter(Collision collision)
    {
        if (m_useCollision && IsInLayerMask(collision.rigidbody.gameObject))
        {
            m_onTick?.Invoke();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (m_useTrigger && IsInLayerMask(other.attachedRigidbody.gameObject))
        {
            m_onTick?.Invoke();
        }
    }

    private bool IsInLayerMask(GameObject obj)
    {
        return (m_layerMask.value & (1 << obj.layer)) != 0;
    }
}
