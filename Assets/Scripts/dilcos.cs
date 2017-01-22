using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dilcos : MonoBehaviour {

    // Use this for initialization

    public GameObject[] dildos;

    private GameObject dildo;
    private int rnd;
    private bool running;
    

	void Start ()
    {
    }

    IEnumerator RandomDildos()
    {
        running = true;
        int i = rnd;
        do
        {
            rnd = Random.Range(0, 3);
            
        }while (i == rnd);
        dildo = (GameObject) Instantiate(dildos[rnd], this.transform);
        if(rnd == 0)
        {
            int alt = Random.Range(0, 2);
            if(alt == 0)
            {
                dildo.transform.position = new Vector3(12, -3, 1);
            }
            else if(alt == 1)
            {
                dildo.transform.position = new Vector3(12, 3, 1);
                dildo.transform.Rotate(new Vector3(0, 0, 180));
            }
            
        }
        else if(rnd == 1)
        {
            int alt = Random.Range(0, 1);
            if (alt == 0)
            {
                dildo.transform.position = new Vector3(12, -4.3f, 1);
                dildo.transform.Rotate(new Vector3(0, 0, 180));
            }
            else if (alt == 1)
            {
                dildo.transform.position = new Vector3(12, 4.5f, 1);
            }
            
        }
        else if(rnd == 2)
        {
            int alt = Random.Range(0, 1);
            if(alt == 0)
            {
                dildo.transform.position = new Vector3(12, -4.5f, 1);
            }
            else if(alt == 1)
            {
                dildo.transform.position = new Vector3(12,  4.5f, 1);
                dildo.transform.Rotate(new Vector3(0, 0, 180));
            }
            
        }
        dildo.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 100);
        dildo.GetComponent<Rigidbody2D>();
        yield return new WaitForSecondsRealtime(4f);    
        running = false;

    }



	// Update is called once per frame
	void Update ()
    {
	    if(!running)
        {
            StartCoroutine(RandomDildos());
        }
        
	}
}
