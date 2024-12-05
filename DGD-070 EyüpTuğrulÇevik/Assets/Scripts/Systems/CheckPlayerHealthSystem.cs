using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using static UnityEngine.EventSystems.EventTrigger;

public class CheckPlayerHealthSystem : IExecuteSystem
{
    private Contexts contexts;
    int newHp = 100;
    int applyHp = 0;
    public CheckPlayerHealthSystem(Contexts context)
    {
        contexts = context;
    }

    public void Execute()
    {
        GameEntity[] entities = contexts.game.GetEntities(GameMatcher.AllOf(GameMatcher.PlayerHealth));

        foreach (GameEntity entity in entities)
        {
            int oldHp = entity.playerHealth.Get;

            if (entity.isPlayerDamaged) { applyHp = -10; entity.isPlayerDamaged = false; }
            if (entity.isPlayerHealed) { applyHp = 10; entity.isPlayerHealed = false; }

            newHp = oldHp + applyHp;
            applyHp = 0;

            oldHp = Math.Clamp(oldHp, 0, 100);
            newHp = Math.Clamp(newHp, 0, 100);
            entity.ReplacePlayerHealth(newHp);
        }
    }
}
