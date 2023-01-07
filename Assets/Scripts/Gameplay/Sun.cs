using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class Sun : MonoBehaviour
{
    [SerializeField]
    public Transform trackingTarget;

    

    public GameObject sun_object;

    float xOffset = 0f;
    float yOffset = 0f;
    int length = 100;
    int Alt = 7;
    // Start is called before the first frame update
    void Start()
    {
        sun_object = GameObject.Find("sonnefin");
    }

    // Update is called once per frame
    void Update()
    {
        

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            yOffset = (float)(Alt * Math.Sin(2 * Math.PI * trackingTarget.position.x / (length)));
            if(trackingTarget.position.x < length/2 + 20)
                sun_object.GetComponent<Renderer>().enabled = true;
            else
                sun_object.GetComponent<Renderer>().enabled = false;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            if (trackingTarget.position.x < 32)
                sun_object.GetComponent<Renderer>().enabled = true;
            else
                sun_object.GetComponent<Renderer>().enabled = false;

            yOffset = 5;
        }




            transform.position = new Vector3(trackingTarget.position.x + xOffset, yOffset, transform.position.z);
    }
}
