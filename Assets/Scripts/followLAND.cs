using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followLAND : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 50, 180);
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
