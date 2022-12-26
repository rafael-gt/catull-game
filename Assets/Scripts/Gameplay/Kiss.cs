using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiss : MonoBehaviour
{
    public int multiplier = 1;

    void Awake()
    {
        //Make Collider2D as trigger 
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        //Destroy the coin if Object tagged Player comes in contact with it
        if (c2d.CompareTag("Player"))
        {
            //Add coin to counter
            hearts.totalHearts += multiplier;
            //Test: Print total number of coins
            Debug.Log("You currently have " + hearts.totalHearts + " Tokens.");
            //Destroy coin
            Destroy(gameObject);
        }
    }
}
