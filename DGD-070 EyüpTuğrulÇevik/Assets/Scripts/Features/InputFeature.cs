using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class InputFeature : Feature
{
    InputContext contexts;
    public InputFeature(Contexts context)
    {
        contexts = context.input;

        Add(new InputConverterSystem(context));
    }
}
