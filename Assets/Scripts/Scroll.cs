using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    public float b2_speed;
    public float b3_speed;
    public float b4_speed;

    public GameObject back2;
    public GameObject back3;
    public GameObject back4;

	// Use this for initialization
	void Start () {
        var back2_1 = Instantiate(back2);
        var back2_2 = Instantiate(back2);

        var back3_2 = Instantiate(back2);
        var back3_1 = Instantiate(back2);

        var back4_1 = Instantiate(back2);
        var back4_2 = Instantiate(back2);


        back2.GetComponent<Rigidbody2D>().AddForce(Vector2.left * b2_speed);
        back2_1.GetComponent<Rigidbody2D>().AddForce(Vector2.left * b2_speed);
        back2_2.GetComponent<Rigidbody2D>().AddForce(Vector2.left * b2_speed);

        
        back3.GetComponent<Rigidbody2D>().AddForce(Vector2.left * b2_speed);
        back3_1.GetComponent<Rigidbody2D>().AddForce(Vector2.left * b2_speed);
        back3_2.GetComponent<Rigidbody2D>().AddForce(Vector2.left * b2_speed);


        back4.GetComponent<Rigidbody2D>().AddForce(Vector2.left * b2_speed);
        back4_2.GetComponent<Rigidbody2D>().AddForce(Vector2.left * b2_speed);
        back4_1.GetComponent<Rigidbody2D>().AddForce(Vector2.left * b2_speed);
    }

    // Update is called once per frame
    void Update ()
    {

    }
}
