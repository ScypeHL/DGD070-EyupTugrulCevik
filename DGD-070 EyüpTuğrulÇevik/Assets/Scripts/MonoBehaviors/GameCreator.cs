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
    private RenderDisplayFeature renderFeature;
    private void Start()
    {
        contexts = Contexts.sharedInstance;

        combatFeature = new CombatFeature(contexts);
        inputFeature = new InputFeature(contexts);
        playerHealthFeature = new PlayerHealthFeature(contexts);
        movementFeature = new MovementFeature(contexts);
        renderFeature = new RenderDisplayFeature(contexts);

        combatFeature.Initialize();
        inputFeature.Initialize();
        playerHealthFeature.Initialize();
        movementFeature.Initialize();
        renderFeature.Initialize();
    }
    private void Update()
    {
        playerHealthFeature.Execute();
        movementFeature.Execute();
        renderFeature.Execute();
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
        renderFeature.Cleanup();
    }
}
