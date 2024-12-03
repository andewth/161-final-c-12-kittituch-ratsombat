using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    private void Start()
    {
        Cast("Casting a Ice shard spell Freeze the enemy!");
        Cast("Casting a spell on target: Gonlin!");
        Cast("IceSpell", 4);
    }
}
