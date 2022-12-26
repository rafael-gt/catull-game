using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        //collider.transform.position = new Vector3(0, 0, 0);
        hearts.totalHearts = 9999;
    }
}
