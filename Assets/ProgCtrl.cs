using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgCtrl : MonoBehaviour
{
    Animator Anim;
    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
    }

    public void PlayAnim(){
        Anim.SetBool("isClicked",true);
    }
}
