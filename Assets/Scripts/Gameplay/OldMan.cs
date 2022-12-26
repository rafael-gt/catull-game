using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldMan : MonoBehaviour
{
    int count = 0;
    bool b  = false;

    [SerializeField]
    Transform oldman;


    // Update is called once per frame
    void Update()
    {
        if(hearts.totalHearts >= 3300)
            flyAway();
    }

    private void flyAway()
    {
        if(b == false)
            count++;
            
        b  = !b;
        
        transform.eulerAngles = new Vector3(0, 0, count);
        transform.position = new Vector3(oldman.position.x, count/50, oldman.position.z);
    }
}
