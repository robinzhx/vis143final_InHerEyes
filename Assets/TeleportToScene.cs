using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class TeleportToScene : MonoBehaviour {

    public string checkName = "[CameraRig]";
    public SteamVR_ScenesLoader triggerScene;


    void OnCollisionEnter(Collision col)
    {
        print("entered collider " + col.gameObject.name);
        if (col.gameObject.name == checkName && triggerScene != null)
        {
            triggerScene.LoadingScene(1);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
