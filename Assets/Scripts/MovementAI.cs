using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAI : MonoBehaviour {

    // Use this for initialization

    public float speed;
    public GameObject player;
    public GameObject bullet;
    public int numBullets;

    private int o;

    private Rigidbody2D r;
    private List<GameObject> bullets;

    void Start () {
        r = GetComponent<Rigidbody2D>();
        
    }
	

    void Ai()
    {
        Rigidbody2D b = player.GetComponent<Rigidbody2D>();
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
        StartCoroutine(Bullet());
    }

    void Shoot()
    {
        var onebullet = Instantiate(bullet);
        Vector2 tmp = new Vector2(-11, 0);
        
        onebullet.GetComponent<Rigidbody2D>().transform.position = new Vector3(this.GetComponent<Rigidbody2D>().position.x, this.GetComponent<Rigidbody2D>().position.y, 1);
        onebullet.GetComponent<Rigidbody2D>().AddForce(tmp);
    }

   IEnumerator Bullet()
    {
        Shoot();
        yield return new WaitForSecondsRealtime(3f);
        
    }
}
