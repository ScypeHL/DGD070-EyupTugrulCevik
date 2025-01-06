using Entitas;
using UnityEngine;

internal class MovementFeature : Feature
{
    Contexts contexts;
    public MovementFeature(Contexts context)
    {
        contexts = context;

        Add(new MovementSystem(context));
    }
}