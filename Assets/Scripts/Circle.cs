using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    private float raidus;

    private void Start()
    {
        init("Circle");
        raidus = 2.5f;
        Draw();
        Debug.Log($"{shapeName} Size {raidus}.");
        Resize();
        Debug.Log($"== {shapeName} calculate result is {CalculateArea}.");
    }


    public override float CalculateArea
    {
        get
        {
            return (float)(3.14 * raidus * raidus);
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
