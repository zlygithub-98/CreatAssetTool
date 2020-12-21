using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class MyBaseAsset : ScriptableObject
{
    public AssetType assetType { get;  }

}
[System.Serializable]
public enum AssetType
{
    Sprites,
    Prefabs 
}