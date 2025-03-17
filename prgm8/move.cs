using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;

public class move : MonoBehaviour
{
    public VideoPlayer videoPlayer;
  public GameObject videoUI;
    Animator anim;
    AudioSource  audi;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        videoUI.SetActive(false);
        anim=GetComponent<Animator>();
        audi=GetComponent<AudioSource>();
        videoPlayer=GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    public void Move()
    {
        anim.SetTrigger("move");
        audi.Play();
        videoUI.SetActive(true);
        videoPlayer.Play();
        
    }
}
