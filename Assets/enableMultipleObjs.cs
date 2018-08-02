using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableMultipleObjs : MonoBehaviour {

    private float secondsCount;
    public float timeLength;
    public GameObject[] objToEnable;
    public int loopIndex;

	// Use this for initialization
	void Start () {
        for (int a = 0; a < objToEnable.Length; a++)
        {
            if (objToEnable[loopIndex] != null)
            {
                objToEnable[loopIndex].SetActive(false);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        secondsCount += Time.deltaTime;
        if (secondsCount > timeLength && loopIndex < objToEnable.Length)
        {
            secondsCount = 0;
            if (objToEnable[loopIndex] != null )
            {
                objToEnable[loopIndex].SetActive(true);
            }
            loopIndex++;
        }
    }
}
