using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{

    public GameObject platfromDestructionPoint;

    // Start is called before the first frame update
    void Start()
    {
        platfromDestructionPoint = GameObject.Find("PlatformDestructionPoint");    
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < platfromDestructionPoint.transform.position.x)
        {
            Destroy (gameObject);
        }
    }
}
