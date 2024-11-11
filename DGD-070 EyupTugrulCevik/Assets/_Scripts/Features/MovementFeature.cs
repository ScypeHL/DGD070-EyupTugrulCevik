using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFeature : Feature
{
    Contexts contexts;
    public MovementFeature(Contexts context) 
    { 
        contexts = context;

        Add(new MovementSystem(context));
    }
    void Start()
    {
        
    }
}
