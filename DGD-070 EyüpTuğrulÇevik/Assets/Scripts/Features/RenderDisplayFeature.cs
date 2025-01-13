using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class RenderDisplayFeature : Feature
{
    private Contexts contexts;
    public RenderDisplayFeature(Contexts context)
    {
        contexts = context;

        Add(new SpawnPlayerSystem(contexts));
        Add(new UpdatePositionSystem(contexts));
    }
}
