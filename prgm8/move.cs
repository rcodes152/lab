using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;

public class move : MonoBehaviour
{
    public VideoPlayer videoPlayer;
  public RawImage raw;
    Animator anim;
    AudioSource  audi;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        anim=GetComponent<Animator>();
        audi=GetComponent<AudioSource>();
        raw.enabled=false;
        videoPlayer.stop();
    }

    // Update is called once per frame
    public void Move()
    {
        anim.SetTrigger("move");
        audi.Play();
        raw.enabled=true;
        videoPlayer.Play();
        
    }
}
