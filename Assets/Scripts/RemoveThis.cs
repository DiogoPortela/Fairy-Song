using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveThis : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.GetComponent<Rigidbody2D>().rotation += 25;

		if(this.GetComponent<Rigidbody2D>().position.x < -15)
        {
            DestroyObject(this.gameObject);
        }
	}
}
