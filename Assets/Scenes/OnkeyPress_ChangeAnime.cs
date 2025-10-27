using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnkeyPress_ChangeAnime : MonoBehaviour
{
    public string redAnime = "";
    public string blueAnime = "";
    public string greenAnime = "";
    string nowMode = "";
    string oldMode = "";

    void Start()
    {
        nowMode = redAnime;
        oldMode = "";
    }

    void Update(){
        if(Input.GetKey("1")){
            nowMode = redAnime;
        }
        if(Input.GetKey("2")){
            nowMode = blueAnime;
        }
        if(Input.GetKey("3")){
            nowMode =greenAnime;
        }
    }

    void FixedUpdate()
    {
        if(nowMode != oldMode){
            oldMode = nowMode;
            Animator animator = this.GetComponent<Animator>();
            animator.Play(nowMode);
        }
    }
}
