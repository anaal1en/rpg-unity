using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCreature : Interectable
{
    protected override void Interact()
    {
        base.Interact();
        Debug.Log("Hi stranger, where are you from?");
        
    }
}
