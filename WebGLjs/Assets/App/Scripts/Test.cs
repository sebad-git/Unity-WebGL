using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public Animate character;

    void Start() {
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKey(KeyCode.W)){ character.GetComponent<Animate>().Wave(); }
        if(Input.GetKey(KeyCode.R)){ character.GetComponent<Animate>().Run(); }
        if(Input.GetKey(KeyCode.D)){ character.GetComponent<Animate>().Dance(); }
        if(Input.GetKey(KeyCode.I)){ character.GetComponent<Animate>().Idle(); }
    
    }
}
