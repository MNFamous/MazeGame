using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DayNNight : MonoBehaviour
{

    public GameObject sun;
    public float speed;

    void Update()
    {
        if (sun.transform.rotation.eulerAngles.x < 180)
        {
            Vector3 rotationx = sun.transform.position;
            rotationx.x = speed;
            sun.transform.Rotate(rotationx * Time.deltaTime);
        }
        if(sun.transform.rotation.eulerAngles.x >= 180 && sun.gameObject.activeSelf == true)
        {
            sun.gameObject.SetActive(false);
            StartCoroutine(SunSet());
        }
    }
    IEnumerator SunSet()
    {
        yield return new WaitForSeconds(10);
        sun.transform.eulerAngles = new Vector3(20,110,0);
        sun.gameObject.SetActive(true);
    }

}
