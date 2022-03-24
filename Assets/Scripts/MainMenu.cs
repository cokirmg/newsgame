using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public GameObject phone;

    public void PlayGame()
    {
        phone.SetActive(true);
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void SetVolume(float volume)
    {
        Debug.Log(volume);
        audioMixer.SetFloat("volume", volume);
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
