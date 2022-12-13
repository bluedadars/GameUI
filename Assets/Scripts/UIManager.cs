using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void onPlay()
    {
        Debug.Log("Play Button Clicked");
    }
    public void Exit()
    {
        Debug.Log("Game Exit");
        Application.Quit();
    }
    public void OnShop()
    {
        Debug.Log("Shop Button Clicked");
    }
    public void onPlant()
    {
        Debug.Log("Plant Button Clicked");
    }
    public void onMusicChange(float value)
    {
        Debug.Log(value);
    }


    public void onGameSoundChange(float value)
    {
        Debug.Log(value);
    }



}

