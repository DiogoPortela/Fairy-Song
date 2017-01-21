using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreesSpawn : MonoBehaviour
{

    // Use this for initialization


    private int rnd;
    public int numSelectors; // size of the array
    private List<GameObject> selectorArr;
    public GameObject selector; //selected in the editor

    void Start()
    {

        selectorArr = new List<GameObject>(numSelectors);
        for (int i = 0; i < numSelectors; i++)
        {
            rnd = Random.Range(15, 50);
            selectorArr.Add(GameObject.Instantiate(selector));

            selectorArr[i].transform.localScale = new Vector3(5, rnd, 1);
            selectorArr[i].transform.position = new Vector3(-10 + i * 5f, -4.5f, 1);

            Vector2 a = new Vector2(-150, 0);
            selectorArr[i].GetComponent<Rigidbody2D>().AddForce(a);



        }
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < numSelectors; i++)
        {
            if (selectorArr[i].GetComponent<Rigidbody2D>().position.x < -20)
            {
                /*Destroy(selectorArr[i]);
                selectorArr.RemoveAt(i);
                s
                numSelectors--;*/


                rnd = Random.Range(15, 50);
                selectorArr[i].transform.localScale = new Vector3(5, rnd, 1);
                selectorArr[i].GetComponent<Rigidbody2D>().transform.position = new Vector3(20, -4.5f, 1);
            }   
        }
    }
}