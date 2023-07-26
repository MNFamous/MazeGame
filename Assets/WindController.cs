using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindController : MonoBehaviour
{
    AudioSource wind;
    void Start()
    {
        wind = this.GetComponent<AudioSource>();
        StartCoroutine(PlayWind());
    }
    IEnumerator PlayWind()
    {
        yield return new WaitForSeconds(60);
        wind.Play();
        StartCoroutine(PlayWind());
    }


}
