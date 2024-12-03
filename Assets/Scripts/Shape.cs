using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;


    public void init(string newName)
    {
        shapeName = newName;
    }


    public abstract float CalculateArea { get; }

    public virtual void Resize()
    {
        Debug.Log("Resize...");
    }

    public virtual void Draw()
    {
        Debug.Log("Drawing...");
    }


}
