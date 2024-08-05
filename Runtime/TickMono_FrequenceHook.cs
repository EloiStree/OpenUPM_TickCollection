using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TickMono_FrequenceHook : MonoBehaviour
{
    public UnityEvent m_onEveryTenTimePerSeconds;
    public UnityEvent m_onEveryHalfSeconds;
    public UnityEvent m_onEvery1Seconds;
    public UnityEvent m_onEvery5Seconds;
    public UnityEvent m_onEvery10Seconds;
    public UnityEvent m_onEvery30Seconds;
    public UnityEvent m_onEvery60Seconds;
    public UnityEvent m_onEvery120Seconds;

    private void OnEnable()
    {
        StartCoroutine(EveryTenTimePerSeconds());
        StartCoroutine(EveryHaldSeconds());
        StartCoroutine(Every1Seconds());
        StartCoroutine(Every5Seconds());
        StartCoroutine(Every10Seconds());
        StartCoroutine(Every30Seconds());
        StartCoroutine(Every60Seconds());
        StartCoroutine(Every120Seconds());
    }


    public IEnumerator EveryTenTimePerSeconds() { return EverySeconds(0.1f, m_onEveryTenTimePerSeconds); }
    public IEnumerator EveryHaldSeconds() { return EverySeconds(0.5f, m_onEveryHalfSeconds); }
    public IEnumerator Every1Seconds() { return EverySeconds(1, m_onEvery1Seconds); }
    public IEnumerator Every5Seconds() { return EverySeconds(5, m_onEvery5Seconds); }
    public IEnumerator Every10Seconds() { return EverySeconds(10, m_onEvery10Seconds); }
    public IEnumerator Every30Seconds() { return EverySeconds(30, m_onEvery30Seconds); }
    public IEnumerator Every60Seconds() { return EverySeconds(60, m_onEvery60Seconds); }
    public IEnumerator Every120Seconds() { return EverySeconds(120, m_onEvery120Seconds); }




    IEnumerator EverySeconds(float secondsToWait, UnityEvent actionToCall)
    {

        while (true)
        {
            yield return new WaitForSeconds(secondsToWait);
            actionToCall.Invoke();
        }
    }

}
