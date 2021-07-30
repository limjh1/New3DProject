using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour
{
    public GameObject player;

    public GameObject[] obstacles;
    
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            obstacles[i].transform.position = new Vector3(Random.Range(-8, 9), obstacles[i].transform.position.y, obstacles[i].transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z + 200 < player.transform.position.z)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 400);
            for (int i = 0; i < 6; i++)
            {
                obstacles[i].transform.position = new Vector3(Random.Range(-8, 9), obstacles[i].transform.position.y, obstacles[i].transform.position.z);
            }
        }

    }
}
