using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillLesbia : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
       DialogueLesbia.walk = false;
       DialogueLesbia.kill = true;

    }
}
