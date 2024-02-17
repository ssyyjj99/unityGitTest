using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlenderCtrl : MonoBehaviour
{
    Animator Anim;
    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
        Anim.SetBool("isClicked",false);
    }

    public void PlayAnim(){
        
        StartCoroutine(PlayAndReset());     
    }

    IEnumerator PlayAndReset()
    {
        Anim.SetBool("isClicked",true);
        yield return new WaitForSeconds(5.5f);
        Anim.SetBool("isClicked",false);

    }
}
