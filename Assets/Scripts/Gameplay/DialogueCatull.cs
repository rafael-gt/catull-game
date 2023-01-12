using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueCatull : MonoBehaviour
{
    new Vector3 target_pos;

    bool enable_controls = false;

    // Start is called before the first frame update
    void Start()
    {
        target_pos = new Vector3(0, (float)0.2, 0);

        StartCoroutine(DoAfterDelay(12)); 
    }

    // Update is called once per frame
    void Update()
    {
        if(!enable_controls)
            transform.position = Vector3.MoveTowards(transform.position, target_pos, 1);  
    }

    IEnumerator DoAfterDelay(float time)
    {
        yield return new WaitForSeconds(time);
        
        enable_controls = true;
    }
}
