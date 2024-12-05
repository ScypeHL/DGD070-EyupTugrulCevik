using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class NewBehaviourScript : MonoBehaviour
{
    private Contexts contexts;
    private PlayerHealthFeature playerHealthFeature;

    void Start()
    {
        contexts = Contexts.sharedInstance;

        playerHealthFeature = new PlayerHealthFeature(contexts);
        playerHealthFeature.Initialize();
    }

    void Update()
    {
        playerHealthFeature.Execute();
    }
}
