using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpell : Spell
{
    private void Start()
    {
        Cast("Casting a New Spell! Kick the enemy!");
        Cast("Casting a spell on target: Slime!");
        Cast("NewSpell", 10);
        NewTypeOfCast();
    }

    public void NewTypeOfCast()
    {
        Cast("Casting a New Spell! Punch the enemy!");
    }
}
