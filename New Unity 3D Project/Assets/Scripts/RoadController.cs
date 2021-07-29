using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z + 100 < transform.position.z)
        {
            transform.Translate(new Vector3(0, 200, 0));
        }

    }
}
