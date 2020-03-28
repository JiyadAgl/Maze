using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{



    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    //to set volume
    public AudioMixer audioMixer;
    public void setVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    //rate button
    public void rateButton()
    {
        string myAppUrl = "https://play.google.com/store/apps/details?id=com.JAGames.TheaMAZingGame";
         Application.OpenURL(myAppUrl);
    }

}
