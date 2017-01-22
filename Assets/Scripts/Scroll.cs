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

    // Update is called once per frame
    void Update () {
        back2.transform.position = back2.transform.position + Vector3.left * b2_speed * Time.deltaTime;
        back3.transform.position = back3.transform.position + Vector3.left * b3_speed * Time.deltaTime;
        back4.transform.position = back4.transform.position + Vector3.left * b4_speed * Time.deltaTime;

        if (back2.transform.position.x < -16)
        {
            Instantiate(back2, back2.transform.position + Vector3.right * (back2.GetComponent<RectTransform>().sizeDelta.x / 2), new Quaternion(), this.transform);
        }
    }
}
