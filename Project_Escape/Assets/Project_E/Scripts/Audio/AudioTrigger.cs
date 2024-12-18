using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioClip audioClip;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(audioClip != null) 
                AudioManager.Instance.PlaySFX(audioClip);

            gameObject.SetActive(false);
        }
    }
}