using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace Eloi.Tick
{

public class TickMono_OnMouseDownUp : MonoBehaviour
{
    public UnityEvent m_onMouseDown;
    public UnityEvent m_onMouseUp;

    private void OnMouseDown()
    {
        m_onMouseDown.Invoke();
    }
    private void OnMouseUp()
    {
        m_onMouseUp.Invoke();
    }

}

}