using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracker : MonoBehaviour
{
    [SerializeField]
    protected Transform trackingTarget;

    int xOffset = 0;
    int yOffset = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = new Vector3(trackingTarget.position.x + xOffset, 
        trackingTarget.position.y + yOffset, transform.position.z);
    }
}