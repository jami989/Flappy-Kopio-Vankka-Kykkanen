using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuteManager : MonoBehaviour
{
    private bool isMuted;

    // Start is called before the first frame update
    void Start()
    {
        isMuted = false;
    }
    // Start is called before the first frame update
    public void SoundOn()
    {
        isMuted = !isMuted;
        AudioListener.pause =! isMuted;
        Debug.Log("Sound on");
    }
    public void SoundOff()
    {
        isMuted = true;
        AudioListener.pause = isMuted;
        Debug.Log("Sound off");
    }
}
