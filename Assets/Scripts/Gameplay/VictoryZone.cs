using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryZone : MonoBehaviour
{
    private System.Random rnd = new System.Random();

    void OnTriggerEnter2D(Collider2D collider)
    {
        //collider.transform.position = new Vector3(0, 0, 0);
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            hearts.totalHearts = rnd.Next(1, 100000);
        }
        

        StartCoroutine(DoAfterDelay(2)); 
    }

    IEnumerator DoAfterDelay(float time)
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            hearts.totalHearts = rnd.Next(1, 100000);
        }

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(time);

        int index =  SceneManager.GetActiveScene().buildIndex;

        index = (index + 1) % 4;

        SceneManager.LoadScene(index);
        
        hearts.totalHearts = 0;

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}
