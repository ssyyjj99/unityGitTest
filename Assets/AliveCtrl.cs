using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliveCtrl : MonoBehaviour
{
    public GameObject Splash;
    public GameObject UI1;
    public GameObject UI2;
    public GameObject parti1;
    public GameObject parti2;
    void Start()
    {
        // Ensure the object is initially disabled
        Splash.SetActive(false);
        UI1.SetActive(false);
        UI2.SetActive(false);
        parti1.SetActive(false);
        parti1.SetActive(false);
    }

    public  void LetsSplash(){
        StartCoroutine(ActivateAndDisableAfterDelay());
    }

    IEnumerator ActivateAndDisableAfterDelay()
    {
        UI1.SetActive(true);
        UI2.SetActive(true);
        yield return new WaitForSeconds(1f);
        // Enable the object
        Splash.SetActive(true);
        

        // Wait for 5 seconds again
        yield return new WaitForSeconds(4.5f);
        parti1.SetActive(true);
        parti1.SetActive(true);

        // Disable the object after the second 5 seconds
        Splash.SetActive(false);
        UI1.SetActive(false);
        UI2.SetActive(false);

        yield return new WaitForSeconds(4f);
        parti1.SetActive(false);
        parti1.SetActive(false);
    }
}
