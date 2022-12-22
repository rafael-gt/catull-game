using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        collider.transform.position = new Vector3((float)15.4, 1, 1);
        hearts.totalHearts = 0;
    }
}
