using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueLesbia : MonoBehaviour
{
    [SerializeField]
    protected Transform trackingTarget;

    [SerializeField]
    protected Transform speechbubble1;

    [SerializeField]
    protected Transform speechbubble2;

    const float speed = 5.0F;

    new Vector3 target_pos;
    
    public static bool walk = false;

    public static bool kill = false;
    
    // Start is called before the first frame update
    void Start()
    {
        target_pos = new Vector3(16, 0, 0);

        StartCoroutine(DoAfterDelay(8)); 
    }

    // Update is called once per frame
    void Update()
    {
        if(walk)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target_pos, step);  
        }
        
        if(trackingTarget.position.x > 15)
        {
            Debug.Log("killing Lesbia");
            transform.position = new Vector3(0, -100, 0);
        }
    }

    IEnumerator DoAfterDelay(float time)
    {
        yield return new WaitForSeconds(time);
        
        walk = true;
        speechbubble1.transform.position =  new Vector3(0, -100, 0);
        speechbubble2.transform.position =  new Vector3(0, -100, 0);
    }
}
