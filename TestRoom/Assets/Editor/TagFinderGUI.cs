using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TagObjectFinder))]
public class TagFinderGUI : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        TagObjectFinder finder = (TagObjectFinder)target;
        
        if(GUILayout.Button("Find Tag Object"))
        {
            finder.FindObjects();
        }
    }
}
