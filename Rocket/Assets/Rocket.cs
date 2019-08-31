using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    Rigidbody rdb;
    public int SPEEDFACTOR = 4000;
    public int ORIGINE = 1;

	// Use this for initialization
	void Start () {
        rdb = gameObject.GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxis("Jump") != 0)
        {
            rdb.AddRelativeForce(new Vector3(Input.GetAxis("Jump") * SPEEDFACTOR * Time.deltaTime, 0,0));
        }

        print(Input.GetAxis("Jump"));

        if (Input.GetAxis("Horizontal") != 0)
        {
            rdb.AddForceAtPosition(new Vector3(Input.GetAxis("Horizontal") * SPEEDFACTOR * Time.deltaTime, 0, 0), new Vector3(0, ORIGINE, 0));
        }

    }
}
