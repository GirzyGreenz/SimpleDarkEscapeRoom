using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    AudioSource audioSource;
    public Player player;
    public AudioClip keySound;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void keyPickup() {
        audioSource.PlayOneShot(keySound);

        //gameObject.SetAtive(false);
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        
        player.hasKey = true;
    }

}
