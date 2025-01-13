using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class CreatePlayerSystem : IInitializeSystem
{
    GameContext contexts;
    public CreatePlayerSystem(Contexts context)
    {
        contexts = context.game;
    }
    public void Initialize()
    {
        GameEntity player = contexts.CreateEntity();
        player.AddPosition(new Vector3(0, 0, 0));
        player.AddSpeed(12);
        player.isPinned = false;
        player.isPlayer = true;
        player.isSpawnPlayer = true;
    }
}
