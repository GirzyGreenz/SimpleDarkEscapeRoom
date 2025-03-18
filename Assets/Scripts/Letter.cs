using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letter : MonoBehaviour
{
    AudioSource audioSource;
    public Text text;

    public AudioClip letterPickUpSound;

    void Start() {
        audioSource = GetComponent<AudioSource>();

    }

    public void readLetter() {
        audioSource.PlayOneShot(letterPickUpSound);

        text.text = "My dear BIG BOY,\n\nThere is something interesting for you in the Microwave.\n\nXXX\nYour papa";
        text.enabled = true;

        StartCoroutine(textGone());
    }

    IEnumerator textGone() {
        yield return new WaitForSeconds(3);
        text.enabled = false;
    }
}
