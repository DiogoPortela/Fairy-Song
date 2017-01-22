using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dilcos : MonoBehaviour {

    // Use this for initialization

    public GameObject[] dildos;

	void Start () {
	}
	
    void random()
    {
        int rnd = Random.Range(0, 2);
        var dildo = Instantiate(dildos[rnd]);
    }



	// Update is called once per frame
	void Update () {
		
	}
}
