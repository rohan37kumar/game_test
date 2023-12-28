using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle_Controller : MonoBehaviour
{
    public float HorInp;
    public float ForInp;
    public GameObject[] roads;
    private bool instDone;
    public int scoreTotal;
    // Start is called before the first frame update
    void Start()
    {
        instDone = true;
        scoreTotal = 0;

    }

    // Update is called once per frame
    void Update()
    {
        //player movement
        HorInp = Input.GetAxis("Horizontal");
        ForInp = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * ForInp * 25);
        transform.Rotate(Vector3.up, Time.deltaTime * HorInp * 45);



        if (this.gameObject.transform.position.y < -5)
        {
            print("Game Over");
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("instantiate") && instDone)
        {
            int randInt = Random.Range(0, 5);
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
