using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle_Controller : MonoBehaviour
{
    
    public GameObject[] roads;
    private bool instDone;
    public int scoreTotal;
    int max_arrelem;
    void Start()
    {
        instDone = true;
        scoreTotal = 0;
    }

    void Update()
    {
        
        if (transform.position.y < -5)
        {
            Debug.Log("Game Over");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("instantiate") && instDone)
        {
            int randInt = Random.Range(0, max_arrelem);
            Vector3 pos = new Vector3(0,0,this.gameObject.transform.position.z+180);
            Instantiate(roads[randInt], pos, Quaternion.Euler(0, 90, 0));
            instDone = false;
            scoreTotal += 5;
        }
        else if (other.gameObject.CompareTag("delete"))
        {
            instDone = true;
        }
        
    }
}
