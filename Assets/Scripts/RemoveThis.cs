using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveThis : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(this.GetComponent<Rigidbody2D>().position.x < -15)
        {
            DestroyObject(this.gameObject);
        }
	}
}
