using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Pet
{
    private void Start()
    {
        
    }
    public override void MakeNoise()
    {
        PlaySound("Meow");
    }
    public override void GivePets()
    {
        base.GivePets();
        PlaySound("Purr");
    }

    void PlaySound(string name)
    {

    }
}
