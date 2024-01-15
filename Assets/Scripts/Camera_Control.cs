using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 6.47f, -11.6f);
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
