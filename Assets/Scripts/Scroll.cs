using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    public float b2_speed;
    public float b3_speed;
    public float b4_speed;

	// Use this for initialization
	void Start () {
        Vector2 b2 = Vector2.left * b2_speed;
        Vector2 b3 = Vector2.left * b2_speed;
        Vector2 b4 = Vector2.left * b2_speed;

        if (this.GetComponentInChildren<GameObject>().name.Equals("back_2"))
        {
            Debug.Log("OK");
        }


    }

    // Update is called once per frame
    void Update () {
        
    }
}
