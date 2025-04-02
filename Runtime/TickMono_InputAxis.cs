using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
namespace Eloi.Tick
{

public class TickMono_InputAxis: MonoBehaviour
{
    public InputActionReference m_inputAction;
    public UnityEvent<float> m_onValueChanged = new UnityEvent<float>();
    public Events m_events = new Events();
    [System.Serializable]
    public class Events {

        [Header("Enter")]
        public UnityEvent m_onMinEnter =new UnityEvent();
        public UnityEvent m_onMaxEnter = new UnityEvent();
        public UnityEvent m_onDeathZoneEnter = new UnityEvent();
        [Header("Exit")]
        public UnityEvent m_onMinExit = new UnityEvent();
        public UnityEvent m_onMaxExit = new UnityEvent();
        public UnityEvent m_onDeathZoneExit = new UnityEvent();
    }

    public float m_borderRange=0.8f;
    public float m_deathZone=0.1f;
    [Header("Debug")]
    [Range(-1,1)]
    public float m_axisValue;

    public bool m_isMin;
    public bool m_isMax;
    public bool m_isInDeathZone;

    void OnEnable()
    {
        m_inputAction.action.Enable();
        m_inputAction.action.performed += ctx => Context(ctx);
        m_inputAction.action.started += ctx => Context(ctx);
        m_inputAction.action.canceled += ctx => Context(ctx);
    }

    private void Context(InputAction.CallbackContext ctx)
    {
        float value = ctx.ReadValue<float>();
        float current = m_axisValue;
        bool changed= value != current;
        if(changed)
        {
            m_axisValue = value;
            m_onValueChanged.Invoke(m_axisValue);
            
            bool ismax = m_axisValue > m_borderRange;
            bool isMin = m_axisValue < -m_borderRange;
            bool isInDeathZone = m_axisValue < m_deathZone && m_axisValue > -m_deathZone;
            
            if (ismax != m_isMax)
            {
                m_isMax = ismax;
                if (m_isMax)
                {
                    m_events.m_onMaxEnter.Invoke();
                }
                else
                {
                    m_events.m_onMaxExit.Invoke();
                }
            }
            if (isMin != m_isMin)
            {
                m_isMin = isMin;
                if (m_isMin)
                {
                    m_events.m_onMinEnter.Invoke();
                }
                else
                {
                    m_events.m_onMinExit.Invoke();
                }
            }
            if (isInDeathZone != m_isInDeathZone)
            {
                m_isInDeathZone = isInDeathZone;
                if (m_isInDeathZone)
                {
                    m_events.m_onDeathZoneEnter.Invoke();
                }
                else
                {
                    m_events.m_onDeathZoneExit.Invoke();
                }
            }
        }
        

    }

    private void OnDisable()
    {
        m_inputAction.action.Disable();
        m_inputAction.action.performed -= ctx => Context(ctx);
        m_inputAction.action.started -= ctx => Context(ctx);
        m_inputAction.action.canceled -= ctx => Context(ctx);
    
    }
    
}



}