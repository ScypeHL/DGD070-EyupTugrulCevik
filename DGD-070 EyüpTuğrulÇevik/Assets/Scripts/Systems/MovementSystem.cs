using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class MovementSystem : IExecuteSystem
{
    Contexts contexts;
    Vector3 applyInput;
    public MovementSystem(Contexts context)
    {
        contexts = context;
    }

    public void Execute()
    {
        GameEntity[] entities = contexts.game.GetEntities(GameMatcher.AllOf(GameMatcher.Position, GameMatcher.Speed).NoneOf(GameMatcher.Pinned));
        InputEntity[] inputEntities = contexts.input.GetEntities(InputMatcher.AxisInput);
        
        foreach (InputEntity inputs in inputEntities)
        {
            applyInput = inputs.axisInput.Value;
        }
        
        foreach (GameEntity entity in entities)
        {
            Vector3 positionChance = entity.position.Value + (applyInput * entity.speed.Value) * Time.deltaTime;
            entity.ReplacePosition(positionChance);


        }
    }

}
