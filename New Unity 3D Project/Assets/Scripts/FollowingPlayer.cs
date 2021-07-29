using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingPlayer : MonoBehaviour
{
    public GameObject player;

    public Vector3 Offset = new Vector3(0,8,-10);

    void LateUpdate()
    {
        transform.position = player.transform.position + Offset;
    }
}