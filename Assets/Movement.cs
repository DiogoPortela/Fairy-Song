using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    // Use this for initialization
    public float speed;
    private Rigidbody2D r;


            
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
    }

    void Update()
    { 
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector2 v = new Vector2(0, speed);
            r.AddForce(v * speed);
        }
        else if( Input.GetKey(KeyCode.DownArrow))
        {
            Vector2 v = new Vector2(0, -speed);
            r.AddForce(v * speed);
        }
        else
        {
            r.Sleep();
        }
    }


    void OnTriggerEnter(Collider a)
    {
        if (a.gameObject.name == "Player")
        {
            Debug.Log("Works");
        }
    }

}
