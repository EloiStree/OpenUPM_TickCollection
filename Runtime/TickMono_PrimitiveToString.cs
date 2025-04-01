using Microsoft.SqlServer.Server;
using UnityEngine;
using UnityEngine.Events;

namespace Eloi.Tick { 


    public class TickMono_PrimitiveToString : MonoBehaviour
    {   
        public string m_lastParsed;
        public string m_format = "{0}";
        public UnityEvent<string> m_onParsed;
        public void PushIn(string value)
        {
            m_lastParsed = value;
            m_onParsed.Invoke(value);
        }
        public void PushIn(bool value) => PushIn(string.Format(m_format, value));
        public void PushIn(int value) => PushIn(string.Format(m_format, value));
        public void PushIn(float value) => PushIn(string.Format(m_format, value));
        public void PushIn(double value) => PushIn(string.Format(m_format, value));
        public void PushIn(Vector2 value) => PushIn(string.Format(m_format, value));
        public void PushIn(Vector3 value) => PushIn(string.Format(m_format, value));
        public void PushIn(ushort value) => PushIn(string.Format(m_format, value));
        public void PushIn(uint value) => PushIn(string.Format(m_format, value));
        public void PushIn(ulong value) => PushIn(string.Format(m_format, value));
        public void PushIn(short value) => PushIn(string.Format(m_format, value));
        public void PushIn(byte value) => PushIn(string.Format(m_format, value));
        public void PushIn(sbyte value) => PushIn(string.Format(m_format, value));
        public void PushIn(char value) => PushIn(string.Format(m_format, value));
        public void PushIn(decimal value) => PushIn(string.Format(m_format, value));
        public void PushIn(long value) => PushIn(string.Format(m_format, value));
        public void PushIn(Quaternion value) => PushIn(string.Format(m_format, value));
        public void PushIn(Color value) => PushIn(string.Format(m_format, value));
        public void PushIn(Color32 value) => PushIn(string.Format(m_format, value));

    }

}