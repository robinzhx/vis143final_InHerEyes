using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class TeleportToObj : MonoBehaviour {

    public string checkName = "[CameraRig]";
    public GameObject teleportToObj;
    public GameObject CameraRigClone;


    void OnCollisionEnter(Collision col)
    {
        print("entered collider " + col.gameObject.name);
        if (col.gameObject.name == checkName && teleportToObj != null)
        {
            if (col.gameObject.name == "[CameraRig]")
            {
                col.gameObject.transform.position = teleportToObj.transform.position;
            } else
            {
                GameObject.Find("[CameraRig]").transform.position = teleportToObj.transform.position;
            }
            
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
