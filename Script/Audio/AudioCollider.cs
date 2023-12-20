using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AudioCollider : MonoBehaviour
{
    [SerializeField] private UnityEvent audioSetting;


    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player")
        {
            audioSetting.Invoke();
            Debug.Log("ColliderHasBeenTriggered");
        }    
    }
}
