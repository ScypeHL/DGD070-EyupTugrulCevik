using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class InputConverterSystem : IExecuteSystem
{
    private float horizontalInput;
    private float verticalInput;
    InputContext contexts;

    public InputConverterSystem(Contexts context)
    {
        contexts = context.input;   
    }
    public void Execute()
    {
        verticalInput = Input.GetAxis("Vertical");
        contexts.ReplaceVerticalInput(verticalInput);

        horizontalInput = Input.GetAxis("Horizontal");
        contexts.ReplaceHorizontalInput(horizontalInput);

        contexts.ReplaceAxisInput(new Vector3(horizontalInput, 0, verticalInput));

        if (Input.GetMouseButtonDown(0))
        {
            InputEntity mouseClick = contexts.CreateEntity();
            mouseClick.AddMouseInput(0);
        }

        if (Input.GetMouseButtonDown(1))
        {
            InputEntity mouseClick = contexts.CreateEntity();
            mouseClick.AddMouseInput(1);
        }
    }
}
