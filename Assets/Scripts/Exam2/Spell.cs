using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    private void Start()
    {
        Cast();
    }

    public virtual void Cast() 
    {
        Debug.Log("Spell-Casting Simulation Started!");
        Debug.Log("Casting a generic spell!");
    }

    public void Cast(string textSpell) 
    {
        Debug.Log(textSpell);
    }

    public void Cast(string newTarget, int numTarget)
    {
        Debug.Log($"Casting a spell on {newTarget}! with power level: {numTarget}");
    }
}
