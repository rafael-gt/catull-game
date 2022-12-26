using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Sun : MonoBehaviour
{
    [SerializeField]
    protected Transform trackingTarget;

    public GameObject sun_object;

    float xOffset = 0f;
    float yOffset = 0f;
    int Radius = 20;
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

        if(trackingTarget.position.x < length/2 + 20)
            sun_object.GetComponent<Renderer>().enabled = true;
        else
            sun_object.GetComponent<Renderer>().enabled = false;

        /*if (trackingTarget.position.x < 2*Radius && trackingTarget.position.x >=0)
        {
            yOffset = (float)(Math.Pow((Math.Pow(Radius, 2) - Math.Pow(trackingTarget.position.x - Radius, 2)), 0.5) / (Radius / 5));
        }
        else
        {
            yOffset = -70;
        }*/

        yOffset = (float)(Alt * Math.Sin(2 * Math.PI * trackingTarget.position.x / (length)));



        transform.position = new Vector3(trackingTarget.position.x + xOffset, yOffset, transform.position.z);
    }
}
