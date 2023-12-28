using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followSKY : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(-2.5f, 1.76f, 196.3f);
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
