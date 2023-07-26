using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextEvents : MonoBehaviour
{
    public GameObject textObj;
    public GameObject eventObject,finalInfo,finalInfoObject,end,pressE;
    public TextMeshProUGUI balls;
    bool gullible = false, keep = false, silly = false, tip = false, pipe = false, info = false, far = false, inside = false;
    [SerializeField]static int counter = 0;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&& inside == true)
        {
            if (textObj != null)
            {
                textObj.SetActive(false);
            }
            if (eventObject != null)
            {
                eventObject.SetActive(false);
            }
            pressE.SetActive(false);
            if(counter == 7)
            {
                finalInfo.SetActive(true);
                finalInfoObject.SetActive(true);
                end.SetActive(true);
            }
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        inside = true;
        switch (this.name)
        {
            case "gullible":
                textObj.SetActive(true);
                eventObject.SetActive(true);
                pressE.SetActive(true);
                if(gullible == false)
                {
                    counter++;
                    balls.text = counter.ToString();
                    gullible = true;
                }
                break;
            case "keep":
                textObj.SetActive(true);
                pressE.SetActive(true);
                if (keep == false)
                {
                    counter++;
                    balls.text = counter.ToString();
                    keep = true;
                }
                break;
            case "silly":
                textObj.SetActive(true);
                eventObject.SetActive(true);
                pressE.SetActive(true);
                if (silly == false)
                {
                    counter++;
                    balls.text = counter.ToString();
                    silly = true;
                }
                break;
            case "tip":
                textObj.SetActive(true);
                eventObject.SetActive(true);
                pressE.SetActive (true);
                if (tip == false)
                {
                    counter++;
                    balls.text = counter.ToString();
                    tip = true;
                }
                break;
            case "pipe":
                textObj.SetActive(true);
                eventObject.SetActive(true);
                pressE.SetActive(true);
                if (pipe == false)
                {
                    counter++;
                    balls.text = counter.ToString();
                    pipe = true;
                }
                break;
            case "info":
                textObj.SetActive(true);
                eventObject.SetActive(true);
                pressE.SetActive(true);
                if (info == false)
                {
                    counter++;
                    balls.text = counter.ToString();
                    info = true;
                }
                break;
            case "far":
                textObj.SetActive(true);
                eventObject.SetActive(true);
                pressE.SetActive(true);
                if (far == false)
                {
                    counter++;
                    balls.text = counter.ToString();
                    far = true;
                }
                break;
            case "end":
                textObj.SetActive(true);
                eventObject.SetActive(true);
                break;
            default:
                break;
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        inside = false;
        switch (this.name)
        {
            case "gullible":
                textObj.SetActive(false);
                pressE.SetActive(false);
                if (eventObject != null)
                {
                    eventObject.SetActive(false);
                }
                if(counter == 7)
                {
                    finalInfo.SetActive(true);
                    finalInfoObject.SetActive(true);
                    end.SetActive(true);
                }
                break;
            case "keep":
                textObj.SetActive(false);
                pressE.SetActive(false);
                if (counter == 7)
                {
                    finalInfo.SetActive(true);
                    finalInfoObject.SetActive(true);
                    end.SetActive(true);
                }
                break;
            case "silly":
                textObj.SetActive(false);
                eventObject.SetActive(false);
                pressE.SetActive(false);
                if (counter == 7)
                {
                    finalInfo.SetActive(true);
                    finalInfoObject.SetActive(true);
                    end.SetActive(true);
                }
                break;
            case "tip":
                textObj.SetActive(false);
                eventObject.SetActive(false);
                pressE.SetActive(false);
                if (counter == 7)
                {
                    finalInfo.SetActive(true);
                    finalInfoObject.SetActive(true);
                    end.SetActive(true);
                }
                break;
            case "pipe":
                textObj.SetActive(false);
                eventObject.SetActive(false);
                pressE.SetActive(false);
                if (counter == 7)
                {
                    finalInfo.SetActive(true);
                    finalInfoObject.SetActive(true);
                    end.SetActive(true);
                }
                break;
            case "info":
                textObj.SetActive(false);
                eventObject.SetActive(false);
                pressE.SetActive(false);
                if (counter == 7)
                {
                    finalInfo.SetActive(true);
                    finalInfoObject.SetActive(true);
                    end.SetActive(true);
                }
                break;
            case "far":
                textObj.SetActive(false);
                eventObject.SetActive(false);
                pressE.SetActive(false);
                if (counter == 7)
                {
                    finalInfo.SetActive(true);
                    finalInfoObject.SetActive(true);
                    end.SetActive(true);
                }
                break;
            case "end":
                textObj.SetActive(false);
                eventObject.SetActive(false);
                break;
            default:
                break;
        }
    }
}
