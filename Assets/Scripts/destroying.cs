using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroying : MonoBehaviour
{
    private GameObject veh;
    private GameObject rd;
    void Start()
    {
        rd = this.gameObject;
        veh = GameObject.Find("vehicle");
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(veh.transform.position, rd.transform.position) >= 200)
        {
            Destroy(this.gameObject);

        }
    }
}
