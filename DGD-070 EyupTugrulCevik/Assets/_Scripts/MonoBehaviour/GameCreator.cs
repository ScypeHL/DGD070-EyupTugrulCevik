using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCreator : MonoBehaviour
{
    private GameContext gameContext;
    private GameEntity entity1;
    // private MovementFeature movementFeature;
    // private MovementSystem movementSystem;
    void Start()
    {
        // movementFeature = new MovementFeature();
        gameContext = Contexts.sharedInstance.game;
        
        entity1 = gameContext.CreateEntity();
        entity1.AddPosition(new Vector3(0, 0, 0));
        entity1.AddSpeed(new Vector3(1, 1, 1));
        entity1.isMoving = true;
    }

    void Update()
    {
        #region inputRegion
        entity1.ReplaceSpeed(new Vector3(Input.GetAxis("Vertical") / 10, 0, 0));
        if (entity1.isMoving)
        {
            entity1.position.Value = entity1.position.Value + entity1.speed.Value;
        }

        if (Input.GetKeyDown("space")) {
            entity1.isMoving = !entity1.isMoving;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {

        }
        #endregion
    }
}
