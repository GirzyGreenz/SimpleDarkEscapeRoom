using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    public Player player;
    AudioSource audioSource;
    Animator animator;
    public Text text;
    public AudioClip dooropeningsound;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

     public void doorOpens() {
        Debug.Log("test door function");

        if (player.hasKey == false) {
            text.text = "You need a key";
            text.enabled = true;
            StartCoroutine(textGone());  
        } else {
            audioSource.PlayOneShot(dooropeningsound);
            animator.SetTrigger("Keyopens"); 
        }    
    }

    IEnumerator textGone() {
        yield return new WaitForSeconds(3);
        text.enabled = false;
    }

}
