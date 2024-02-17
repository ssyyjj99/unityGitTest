using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDisableObject : MonoBehaviour
{
    private GameObject UI1;
    private GameObject UI2;

    void Start()
    {
        UI1 = GameObject.Find("ProgressBar");
        UI2 = GameObject.Find("Indicate1");
        UI1.SetActive(false);
        UI2.SetActive(false);
            
    }

    // Public method to activate and disable the object
    public void ActivateAndDisable()
    {
        // Enable the object
        UI1.SetActive(true);
        UI2.SetActive(true);

        // Start the coroutine to disable the object after 5 seconds
        StartCoroutine(DisableAfterDelay());
    }

    IEnumerator DisableAfterDelay()
    {
        // Wait for 5 seconds
        yield return new WaitForSeconds(5f);

        // Disable the object after 5 seconds
        UI1.SetActive(false);
        UI2.SetActive(false);

    }
}
