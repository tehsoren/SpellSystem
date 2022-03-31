using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speedMod = .5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
	}

    void Movement()
    {
        this.transform.position += new Vector3(1,0,0)*Input.GetAxis("Horizontal")*speedMod;
        this.transform.position += new Vector3(0, 0, 1) * Input.GetAxis("Vertical")*speedMod;
    }
}
