using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private bool isMuted;
    // Start is called before the first frame update
    void Start()
    {
        isMuted = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SoundOn()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
        Debug.Log("Sound on");
    }
    public void SoundOff()
    {
        isMuted = true;
        AudioListener.pause = !isMuted;
        Debug.Log("Sound off");
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("StartGameScene");
    }
}
