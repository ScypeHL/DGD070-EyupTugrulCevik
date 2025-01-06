using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCreator : MonoBehaviour
{
    Contexts contexts;
    private CombatFeature combatFeature;
    private InputFeature inputFeature;
    private PlayerHealthFeature playerHealthFeature;
    private MovementFeature movementFeature;
    private void Start()
    {
        contexts = Contexts.sharedInstance;

        combatFeature = new CombatFeature(contexts);
        inputFeature = new InputFeature(contexts);
        playerHealthFeature = new PlayerHealthFeature(contexts);
        movementFeature = new MovementFeature(contexts);

        combatFeature.Initialize();
        inputFeature.Initialize();
        playerHealthFeature.Initialize();
        movementFeature.Initialize();
    }
    private void Update()
    {
        playerHealthFeature.Execute();
        movementFeature.Execute();
    }

    private void FixedUpdate()
    {
        combatFeature.Execute();
        inputFeature.Execute();
    }

    private void LateUpdate()
    {
        combatFeature.Cleanup();
        inputFeature.Cleanup();
        playerHealthFeature.Cleanup();
        movementFeature.Cleanup();
    }
}
