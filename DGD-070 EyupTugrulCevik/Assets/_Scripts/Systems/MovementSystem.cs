using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSystem : IExecuteSystem
{
    Contexts contexts;

    public MovementSystem(Contexts context)
    {
        contexts = context;
    }
    public void Execute()
    {
        Debug.Log("UwU");
    }
}