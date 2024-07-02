using System;
using System.Linq;
using UnityEngine;
using UnityEditor;
using System.Reflection;

[CustomEditor(typeof(MonoBehaviour), true)]
public class ButtonAttributeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        var mono = target as MonoBehaviour;

        var methods = mono.GetType()
            .GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
            .Where(m => Attribute.IsDefined(m, typeof(ButtonAttribute)));

        foreach (var method in methods)
        {
            var attr = (ButtonAttribute)Attribute.GetCustomAttribute(method, typeof(ButtonAttribute));
            if (GUILayout.Button(attr.ButtonName))
            {
                method.Invoke(mono, null);
            }
        }
    }
}