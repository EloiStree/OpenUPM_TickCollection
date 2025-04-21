using System.Collections;
using System.Collections.Generic;
using Eloi.Tick;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TickMono_AbstractDefault),true)]
public class TickMono_AbstractDefaultEditor : Editor
{
    public override void OnInspectorGUI()
    {
        if (GUILayout.Button("Tick"))
        {
            TickMono_AbstractDefault tickTarget = (TickMono_AbstractDefault)this.target;
            tickTarget.TriggerTick();
        }
        base.OnInspectorGUI();
    }
}
