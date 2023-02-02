using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public AudioSource audio_source; 

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            audio_source.Play();
            
            collider.transform.position = new Vector3(0, 0, 0);
            hearts.totalHearts = 0;
        }
    }
}
