using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    private void Start()
    {
        Cast("Casting a Fireball Spell! Burn them all!");
        Cast("FireSpell", 5);
    }
}
