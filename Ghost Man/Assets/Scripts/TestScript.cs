using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") *.3f,0,0));
        transform.Translate(new Vector3(0, Input.GetAxisRaw("Vertical") * .3f, 0));
    }
}
