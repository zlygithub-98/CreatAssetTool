using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;
using System;

[CustomEditor(typeof(EditorPanel))]
public class EditorPanel : EditorWindow
{ 
    [MenuItem("MyTools/CreatAsset")]
    public static void ConfigDialog()
    { 
        EditorWindow.GetWindow(typeof(EditorPanel));
    } 
    public UnityEngine.Object go = null; 
    void OnGUI()
    {
        //Label
        GUILayout.Label("CreatAsset", EditorStyles.boldLabel); 
        go = EditorGUILayout.ObjectField(go, typeof(UnityEngine.Object), true);
        //Button
        if (GUILayout.Button("Creat Asset"))
        {
            string className = go.name;
            CreatAsset.Create(className);
            go = null;
        }
    }
}
