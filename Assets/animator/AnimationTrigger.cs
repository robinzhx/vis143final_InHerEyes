using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour {

    public GameObject[] animatedObjects;
    public AnimationClip anim;

	// Use this for initialization
	void Start () {
        print("start animation");
        for (int i = 0; i < animatedObjects.Length; i++)
        {
            if (animatedObjects[i].GetComponent<Animation>() != null)
            {
                animatedObjects[i].GetComponent<Animation>().Play(anim.name);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider Other)
    {
        
    }
}
