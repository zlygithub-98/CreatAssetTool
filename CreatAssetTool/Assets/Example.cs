using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    public PrefabAsset asset; 
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(asset.prefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
