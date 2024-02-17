using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureCtrl : MonoBehaviour
{
    public Texture[] textures;
    public int textureNum;
    
    
    
    void Start()
    {
        
    }

    void Update(){
        // Renderer myRenderer = GetComponent<Renderer>();
        // Texture myMainTexture = myRenderer.material.mainTexture;
        // myMainTexture = textures[textureNum];
        // myRenderer.material.SetTexture("_MainTex", myMainTexture);
        Renderer myRenderer = GetComponent<Renderer>();
        myRenderer.material.mainTexture = textures[textureNum];
    }

    public void playTexture()
    {
        
        StartCoroutine(textureChange());
        
    }

    IEnumerator textureChange()
    {
        textureNum = 0;
        yield return new WaitForSeconds(0.5f);
        textureNum = 0;
        yield return new WaitForSeconds(2f);
        textureNum = 1;
        yield return new WaitForSeconds(0.5f);
        textureNum = 2;
        yield return new WaitForSeconds(3f);
        textureNum = 0;
    }
}
