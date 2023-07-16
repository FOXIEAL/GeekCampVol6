using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{
    [SerializeField] private AudioClip se1;
    [SerializeField] private AudioClip se2;
    [SerializeField] private AudioClip se3;

    public void OnCubeEnter() {
        GetComponent<AudioSource>().PlayOneShot(se1);
    }
    
    public void OnStarEnter() {
        GetComponent<AudioSource>().PlayOneShot(se2);
    }
    
    public void OnHeartEnter() {
        GetComponent<AudioSource>().PlayOneShot(se3);
    }
}
