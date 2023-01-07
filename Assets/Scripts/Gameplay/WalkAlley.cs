using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAlley : MonoBehaviour
{
    [SerializeField]
    protected Transform trackingTarget;
    
    public float speed = 10;

    //new Vector3 start_pos(-7.62, 4.62, 0);
    Vector3 target_pos = new Vector3((float)-4.66, 0, 0);

    public static bool walk = false;

    // Update is called once per frame
    void Update()
    {
        if(!walk)
            return;

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target_pos, step);

        //if(trackingTarget.position.y < 0.1)
            //walk = false;

        //Debug.Log(trackingTarget.position.y);
    }
}
