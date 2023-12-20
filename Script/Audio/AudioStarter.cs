using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioStarter : MonoBehaviour
{
    [SerializeField] private AudioSource audioPlayer;


    public void audioActivate()
    {
        audioPlayer.Play();
        Debug.Log("INVOKED!");
    }
}
