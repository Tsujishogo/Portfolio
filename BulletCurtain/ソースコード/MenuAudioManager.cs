using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAudioManager : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip decide;
    [SerializeField] AudioClip select;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.time = 0.1f;
    }

    // Update is called once per frame
    public void Onclick()
    {
        audioSource.PlayOneShot(decide);
    }
    

}
