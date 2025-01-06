using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class CombatFeature : Feature
{
    InputContext contexts;
    public CombatFeature(Contexts context)
    {
        contexts = context.input;

        Add(new FiringSystem(context));
    }
}