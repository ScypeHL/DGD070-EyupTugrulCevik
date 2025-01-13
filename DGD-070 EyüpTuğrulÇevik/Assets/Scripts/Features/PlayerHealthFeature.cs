using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class PlayerHealthFeature : Feature
{
    Contexts contexts;
    public PlayerHealthFeature(Contexts context)
    {
        contexts = context;

        Add(new CreatePlayerHealthSystem(contexts));
        Add(new ChangePlayerHealthSystem(contexts));
        Add(new CheckPlayerHealthSystem(contexts));
        Add(new CreatePlayerSystem(contexts));
    }
}
