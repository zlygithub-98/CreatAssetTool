using UnityEngine;
using UnityEditor;
using System.IO;
using System;

public class CreatAsset : Editor
{ 
    public static void Create(string objectName)
    { 
        Type type = Type.GetType(ScriptableObject.CreateInstance(typeof(MyBaseAsset)).GetType().Namespace + "." + objectName, true, true);
        ScriptableObject scriptable = ScriptableObject.CreateInstance(type);
        if (scriptable==null)
        {
            Debug.LogWarning("SpriteAsset is null!");
            return;
        } 
        // 自定义资源保存路径
        string path = Application.dataPath + "/MyAssets";
        // 如果项目总不包含该路径，创建一个 
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path); 
        }
      
        path = string.Format("Assets/MyAssets/{0}.asset", objectName.ToString());
        // 生成自定义资源到指定路径
        AssetDatabase.CreateAsset(scriptable, path);
    }
} 