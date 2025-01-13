using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.Unity;

public class SpawnPlayerSystem : ReactiveSystem<GameEntity>
{
    private GameContext contexts;

    public SpawnPlayerSystem(Contexts context) : base(context.game)
    {
        contexts = context.game;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (GameEntity entity in entities)
        {
            GameObject playerObject = Object.Instantiate(PrefabReference.instance.prefab);
            Vector3 position = entity.position.Value;
            playerObject.transform.position = position;

            entity.AddRenderer(playerObject);
            playerObject.Link(entity);
        }
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.SpawnPlayer);
    }
}
