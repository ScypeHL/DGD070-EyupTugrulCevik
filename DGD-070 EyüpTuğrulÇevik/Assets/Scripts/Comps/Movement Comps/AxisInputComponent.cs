using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Unique, Input]
public class AxisInputComponent : IComponent
{
    public Vector3 Value;
}
