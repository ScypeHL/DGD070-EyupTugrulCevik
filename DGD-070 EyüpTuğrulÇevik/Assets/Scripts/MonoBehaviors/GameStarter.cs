using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    GameContext contexts;

    public GameStarter(Contexts context)
    {
        contexts = context.game;
    }
    private void Start()
    {
        contexts = Contexts.sharedInstance.game;
        
        GameEntity player = contexts.CreateEntity();
        player.AddPosition(new Vector3(0, 0, 0));
        player.AddSpeed(1);
        player.isPinned = false;
    }
    private void Update()
    {

    }

}
