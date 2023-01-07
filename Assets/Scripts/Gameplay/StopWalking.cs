using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWalking : MonoBehaviour
{
    public bool walk_or_not = false;

    void OnTriggerEnter2D(Collider2D c2d)
    {
        //Destroy the coin if Object tagged Player comes in contact with it
        if (c2d.CompareTag("Player"))
        {
            WalkAlley.walk = walk_or_not;
        }
    }
}
