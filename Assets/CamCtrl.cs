using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCtrl : MonoBehaviour
{
    Animator Anim;
    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
    }

    public void PlayAnim(){
        Anim.SetBool("isClicked",false);
        StartCoroutine(PlayAndReset());     
    }

    IEnumerator PlayAndReset()
    {
        Anim.SetBool("isClicked",true);
        yield return new WaitForSeconds(6.5f);
        Anim.SetBool("isClicked",false);

    }
}

