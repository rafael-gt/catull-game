using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiss : MonoBehaviour
{
    public int multiplier = 1;

    public AudioSource audio_source; 

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
            audio_source.Play();
            Debug.Log("You currently have " + hearts.totalHearts + " Tokens.");

            //Destroy heart
            StartCoroutine(DoAfterDelay(1));

        }
    }

    IEnumerator DoAfterDelay(float time)
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        transform.position = new Vector3(-1000, -1000, -1000);

        //yield on a new YieldInstruction that waits for "time" seconds.
        yield return new WaitForSeconds(time);

        // Destroy heart
        Destroy(gameObject);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}
