using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldMan : MonoBehaviour
{
    float count = 0;
    bool b  = false;
    bool flag = false;

    [SerializeField]
    Transform oldman;

    new Vector3 target_pos;
    const float speed = 1.5F;
    const float rotation_speed = 50.0F;

    void Start()
    {
        target_pos = new Vector3(oldman.position.x, 500, 100);
    }

    // Update is called once per frame
    void Update()
    {
        if (hearts.totalHearts >= 3300)
            flag = true;

        if (flag)
            flyAway();
    }

    void flyAway()
    {
        Debug.Log(rotation_speed);

        count += rotation_speed * Time.deltaTime;
            
        transform.eulerAngles = new Vector3(0, 0, count);

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target_pos, step);
        if(transform.position == target_pos)
        {
            flag = false;
        }
    }
}
