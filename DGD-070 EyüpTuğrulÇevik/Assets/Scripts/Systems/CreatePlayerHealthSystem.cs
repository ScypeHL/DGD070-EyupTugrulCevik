using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using System;

public class CreatePlayerHealthSystem : IInitializeSystem
{
    private GameContext gameContext;

    public CreatePlayerHealthSystem(Contexts context)
    {
        gameContext = context.game;
    }
    public void Initialize()
    {
        CreateEntity();
    }

    private void CreateEntity()
    {
        GameEntity entity = gameContext.CreateEntity();
        entity.AddPlayerHealth(100);
        entity.isPlayerDamaged = false;
        entity.isPlayerHealed = false;
    }
}
