using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 8, -10);
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
