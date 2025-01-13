using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatePositionSystem : IExecuteSystem
{
    private GameContext contexts;
    public UpdatePositionSystem(Contexts context)
    {
        contexts = context.game;
    }
    public void Execute()
    {
        GameEntity[] entities = contexts.GetEntities(GameMatcher.AllOf(GameMatcher.Position, GameMatcher.Renderer));

        foreach (GameEntity entity in entities)
        {
            entity.renderer.gameObject.transform.position = entity.position.Value;
        }
    }
}
