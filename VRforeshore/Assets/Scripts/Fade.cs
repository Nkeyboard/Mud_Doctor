using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    public Material mat;

    void Start()
    {
        StartCoroutine("RunFade");        
    }

    IEnumerator RunFade()
    {
        yield return new WaitForSeconds(2.0f);
        Color color = mat.color;
        while(color.a > 0.0f)
        {
            color.a -= 0.01f;
            mat.color = color;
            yield return new WaitForSeconds(0.2f);
        }
    }
    
}
