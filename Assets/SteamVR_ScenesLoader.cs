using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamVR_ScenesLoader : MonoBehaviour {

    public int currLevel = 0;

    public string[] sceneName = new string[2] { "New Scene", "complete window" };

    public void LoadingScene(int index)
    {
        SteamVR_LoadLevel.Begin(sceneName[index], false, 1.0f);
    }
}
