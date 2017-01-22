using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {
    public GameObject start, options, exit;
    public GameObject leftTarget, rightTarget;
    public int transitionSpeed;

    private int current;
    private bool readyLeft, readyRight, done;
    private string outFrame, toFrame;

	// Use this for initialization
	void Start ()
    {
        options.transform.position = rightTarget.transform.position;
        exit.transform.position = rightTarget.transform.position;
        current = 0;
        readyLeft = false;
        readyRight = false;
        done = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKey(KeyCode.A) && done)
        {
            switch(current)
            {
                case 0:
                    {
                        outFrame = start.name;
                        toFrame = options.name;
                        readyLeft = true;
                        done = false;
                        current = 1;
                        break;
                    }
                case 1:
                    {
                        outFrame = options.name;
                        toFrame = exit.name;
                        readyLeft = true;
                        done = false;
                        current = 2;
                        break;
                    }
            }
        }
        if (Input.GetKey(KeyCode.D) && done)
        {
            switch (current)
            {
                case 1:
                    {
                        outFrame = options.name;
                        toFrame = start.name;
                        readyRight = true;
                        done = false;
                        current = 0;
                        break;
                    }
                case 2:
                    {
                        outFrame = exit.name;
                        toFrame = options.name;
                        readyRight = true;
                        done = false;
                        current = 1;
                        break;
                    }
            }
        }

        if (readyLeft)
        {
            Transform to = GameObject.Find(toFrame).GetComponent<Transform>();
            Transform ouT = GameObject.Find(outFrame).GetComponent<Transform>();

            ouT.position = Vector3.MoveTowards(ouT.position, leftTarget.transform.position, transitionSpeed * Time.deltaTime);
            to.position = Vector3.MoveTowards(to.position, leftTarget.transform.position, transitionSpeed * Time.deltaTime);

            if(ouT.transform.position.Equals(leftTarget.transform.position))
            {
                readyLeft = false;
                done = true;
            }
        }
        if (readyRight)
        {
            Transform to = GameObject.Find(toFrame).GetComponent<Transform>();
            Transform ouT = GameObject.Find(outFrame).GetComponent<Transform>();

            ouT.position = Vector3.MoveTowards(ouT.position, rightTarget.transform.position, transitionSpeed * Time.deltaTime);
            to.position = Vector3.MoveTowards(to.position, rightTarget.transform.position, transitionSpeed * Time.deltaTime);

            if (ouT.transform.position.Equals(rightTarget.transform.position))
            {
                readyRight = false;
                done = true;
            }
        }
    }
}
