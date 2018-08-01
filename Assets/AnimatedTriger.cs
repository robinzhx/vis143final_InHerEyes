using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedTriger : MonoBehaviour {

    public bool starttwist = true;
    public float x = -0.005f, y = 0.0f, z = 0.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (starttwist)
        {
            this.gameObject.transform.Rotate(new Vector3(x, y, z));
        }
	}
}
