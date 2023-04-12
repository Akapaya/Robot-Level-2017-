using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrSetas : MonoBehaviour {
    public Animator anim;
    public bool Ligado = false;
	// Use this for initialization
	void Start () {
		
	}
    void on()
    {
        if(Ligado == false)
        {
            anim.SetInteger("situacao", 0);
        }
        if (Ligado == true)
        {
            anim.SetInteger("situacao", 1);
        }
    }
	// Update is called once per frame
	void Update () {
        on();
	}
}
