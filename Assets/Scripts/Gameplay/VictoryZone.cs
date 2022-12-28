using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        //collider.transform.position = new Vector3(0, 0, 0);
        hearts.totalHearts = 9999;

        StartCoroutine(DoAfterDelay(2)); 
    }

    IEnumerator DoAfterDelay(float time)
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(time);

        int index =  SceneManager.GetActiveScene().buildIndex;

        index = (index + 1) % 3;

        SceneManager.LoadScene(index);
        
        hearts.totalHearts = 0;

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}
