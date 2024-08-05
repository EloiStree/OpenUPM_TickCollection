using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

[CustomEditor(typeof(TickMono_AbstractDefault) )]
public class TickMono_AbstractDefaultEditor : Editor
{
    public override void OnInspectorGUI()
    {
        if (GUILayout.Button("Tick")) {
            TickMono_AbstractDefault tickTarget = (TickMono_AbstractDefault)this.target;
            tickTarget.TriggerTick();
        }
        base.OnInspectorGUI();
    }
}
