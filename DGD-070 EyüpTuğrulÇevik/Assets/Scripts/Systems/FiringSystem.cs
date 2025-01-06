using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringSystem : ReactiveSystem<InputEntity>
{
    InputContext contexts;
    public FiringSystem(Contexts context) : base(context.input)
    {
        contexts = context.input;
    }
    protected override bool Filter(InputEntity entity)
    {
        return (entity.hasMouseInput && entity.mouseInput.Button == 0);
    }

    protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
    {
        return context.CreateCollector(InputMatcher.MouseInput.Added());
    }
    protected override void Execute(List<InputEntity> entities)
    {
        Debug.Log("Say");
        foreach (InputEntity entity in entities)
        {
            entity.Destroy();
        }
    }
}
