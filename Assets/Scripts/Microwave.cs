using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Microwave : MonoBehaviour
{
    Animator animator;
    AudioSource audioSource;
    bool isMicrowaveOpen;
    public AudioClip closeMicrowaveSound;
    public AudioClip openMicrowaveSound;

    void Start() {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        isMicrowaveOpen = false;
    }
    public void openMicrowave() {
        if (isMicrowaveOpen == false) {
            Debug.Log("test open");
            animator.SetTrigger("Open Microwave"); 
            audioSource.PlayOneShot(openMicrowaveSound);
            isMicrowaveOpen = true;
        } else {
            Debug.Log("test open");
            animator.SetTrigger("Close Microwave"); 
            audioSource.PlayOneShot(closeMicrowaveSound);
            isMicrowaveOpen = false;
        }
    }
}