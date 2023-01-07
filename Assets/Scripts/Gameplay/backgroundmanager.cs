using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class backgroundmanager : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject lvl3past;
    [SerializeField]
    private Transform player;
    void Start()
    { 
        lvl3past = GameObject.Find("candidisoles");

    }

    // Update is called once per frame
    void Update()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        switch(currentSceneIndex)
        {
            case 1:
                break;

            case 3:
                if (player.position.x < 33)
                {
                    lvl3past.GetComponent<Renderer>().enabled = true;
                }
                else
                {
                    lvl3past.GetComponent<Renderer>().enabled = false;
                }
                break;

            default:
                break;
        }

    }
}
