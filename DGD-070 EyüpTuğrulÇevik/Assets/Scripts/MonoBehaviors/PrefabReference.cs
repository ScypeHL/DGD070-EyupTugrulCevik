using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabReference : MonoBehaviour
{
    public GameObject prefab;
    
    public static PrefabReference instance;

    private void Awake()
    {
        instance = this;
    }
}
