using UnityEngine;
using UnityEngine.Events;

public class TickMono_IsTwoPointsCloseEnough : MonoBehaviour
{

    public Transform m_pointA;
    public Transform m_pointB;
    public float m_distance = 0.1f;
    public bool m_isCloseEnough = false;
    
    public UnityEvent<bool> m_onIsCloseEnough= null;
    public UnityEvent m_onIsCloseEnoughTrueChanged = null;
    public UnityEvent m_onIsCloseEnoughFalseChanged = null;
    public UnityEvent m_onUpdateTrue;
    public UnityEvent m_onUpdateFalse;
    public UnityEvent<bool> m_onUpdate;

    public void Update()
    {
        if (m_pointA == null || m_pointB == null)
            return;

        bool isCloseEnough = Vector3.Distance(m_pointA.position, m_pointB.position) < m_distance;
        if (m_isCloseEnough != isCloseEnough)
        {
            m_isCloseEnough = isCloseEnough;
            m_onIsCloseEnough?.Invoke(m_isCloseEnough);
            if (m_isCloseEnough)
                m_onIsCloseEnoughTrueChanged?.Invoke();
            else
                m_onIsCloseEnoughFalseChanged?.Invoke();


        }
        m_onUpdate?.Invoke(m_isCloseEnough);
        if (m_isCloseEnough)
            m_onUpdateTrue?.Invoke();
        else
            m_onUpdateFalse?.Invoke();
    }

}
