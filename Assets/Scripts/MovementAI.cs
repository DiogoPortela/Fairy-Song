using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAI : MonoBehaviour {

    // Use this for initialization

    public float speed;
    public float b_speed;
    public GameObject player;
    public GameObject bulletSpawnPoint;
    public GameObject bullet;

    private bool isRunning;

    private Rigidbody2D r;

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

        if (!isRunning)
        {
            StartCoroutine(Bullet());
        }



    }

    void Shoot()
    {
        var onebullet = Instantiate(bullet, bulletSpawnPoint.transform.position, new Quaternion(), this.transform);
        Vector2 tmp = Vector2.left * b_speed;
        
        //onebullet.GetComponent<Rigidbody2D>().transform.position = new Vector3(this.GetComponent<Rigidbody2D>().position.x, this.GetComponent<Rigidbody2D>().position.y, 1);
        onebullet.GetComponent<Rigidbody2D>().AddForce(tmp);
    }

   IEnumerator Bullet()
    {
        isRunning = true;
        Shoot();
        yield return new WaitForSecondsRealtime(3f);
        isRunning = false;
    }
}
