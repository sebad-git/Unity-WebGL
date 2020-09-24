using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour {


    private Animator animator;
    void Start() {
        this.animator=GetComponent<Animator>();
        this.animator.applyRootMotion=false;
    }

    public void Idle(){ this.animator.SetInteger("state",0); }
    
    public void Run(){ this.animator.SetInteger("state",1); }

    public void Wave(){ this.animator.SetInteger("state",2); }
    
    public void Dance(){ this.animator.SetInteger("state",3); }
    
}
