using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private int side;

    private void Start()
    {
        side = 9;
        init("Square");
        Draw();
        Debug.Log($"{shapeName} Size {side}.");
        Resize();
        Debug.Log($"== {shapeName} calculate result is {CalculateArea}.");
    }

    public override float CalculateArea
    {
        get
        {
            return (int)(side * side);
        }
    }


    public override void Resize()
    {
        Debug.Log($"- {shapeName} is Resized.");
    }

    public override void Draw()
    {
        Debug.Log($"+ Drawing {shapeName}.");
    }

}
