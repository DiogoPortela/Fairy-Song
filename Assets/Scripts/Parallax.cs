using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {

    public float speed;
    private Renderer r;

    private void Start()
    {
        r = GetComponent<Renderer>();
    }

    void Update () {
        r.material.mainTextureOffset = new Vector2(Time.time * speed, 0);
	}
}
