using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZonelvl3 : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    private bool checkpoint = false;
    void Start()
    {
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            if (player.position.x > 40)
            {
                checkpoint = true;
            }
            if (!checkpoint)
            {
                collider.transform.position = new Vector3(0, 0, 0);
            }
            else
            {
                collider.transform.position = new Vector3(40, 0, 0);
            }
            hearts.totalHearts = 0;
        }
    }
}
