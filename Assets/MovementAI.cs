using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAI : MonoBehaviour {

    // Use this for initialization

    public float speed;
    public GameObject a;
    private Rigidbody2D r;

    void Start () {
        r = GetComponent<Rigidbody2D>();
	}
	

    void Ai()
    {
        Rigidbody2D b = a.GetComponent<Rigidbody2D>();
        if (r.position.y < b.position.y)
        {
            Vector2 tmp = new Vector2(0, speed);
            r.AddForce(tmp);
        }
        else
        {
            Vector2 tmp = new Vector2(0, -speed);
            r.AddForce(tmp);
        }
    }


	// Update is called once per frame
	void Update () {
        Ai();
	}
}
