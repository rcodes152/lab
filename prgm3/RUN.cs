using UnityEngine;

public class RUN : MonoBehaviour
{


    Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Animator lion;
    void Start()
    {
        anim =GetComponent<Animator>();
        lion=GetComponent<Animator>();
    }

    // Update is called once per frame
    public void run()
    {
        anim.SetTrigger("run");
        
    }
    public void walk()
    {
        anim.SetTrigger("walk");
        
    }
}
