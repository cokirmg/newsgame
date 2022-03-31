using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public GameObject phone;
    public AudioSource au;
    public AudioClip clip;

    
    public void PlayGame()
    {
        //phone.SetActive(true);
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
        au.PlayOneShot(clip);
    }
    public void SetVolume(float volume)
    {
        Debug.Log(volume);
        audioMixer.SetFloat("volume", volume);
    }
    public void GoToMenu()
    {
        Debug.Log("UWUUUUU");
        SceneManager.LoadScene("Menu");
    }

    public void CambiarEscena(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void sonido()
    {
        Debug.Log("llega aqui");
        au.PlayOneShot(clip);
    }
}
