using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthObject : HealthObject
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Die()
    {
        Debug.Log("PLAYER LOST ALL HEALTH");
    }
}
