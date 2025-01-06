using Entitas;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerHealthSystem : IExecuteSystem
{
    private Contexts contexts;
    private bool Dpressed;
    private bool Hpressed;
    private bool Qpressed;

    public ChangePlayerHealthSystem(Contexts context)
    {
        contexts = context;
    }

    public void Execute()
    {
        // Dpressed = Input.GetKeyDown(KeyCode.D);
        // Hpressed = Input.GetKeyDown(KeyCode.H);
        // Qpressed = Input.GetKey(KeyCode.Q);

        GameEntity[] entities = contexts.game.GetEntities(GameMatcher.AllOf(GameMatcher.PlayerHealth));

        foreach (GameEntity entity in entities)
        {
            if (Dpressed) { entity.isPlayerDamaged = true; entity.isPlayerHealed = false; } 
            if (Hpressed) { entity.isPlayerHealed = true; entity.isPlayerDamaged = false; }
            if (Qpressed) { entity.isPlayerHealed = false; entity.isPlayerDamaged = false; }
        }
    }
}
