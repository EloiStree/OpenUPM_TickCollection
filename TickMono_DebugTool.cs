using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TickMono_DebugTool : MonoBehaviour
{

    public UnityEvent<Color> m_onRandomColor;
    public void DisplayMessageInLog(string message) { 
    
        Debug.Log(message);
    }

    [ContextMenu("Invoke Random Color")]
    public void PushRandomColor() { 
    

        Color randomColor = new Color(Random.value, Random.value, Random.value);
        m_onRandomColor.Invoke(randomColor);
    }
}
