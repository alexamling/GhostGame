using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CharacterInfo script = gameObject.GetComponent<CharacterInfo>();
        script.enabled = false;
    }
}
