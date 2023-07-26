using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public GameObject player,cam;
    [SerializeField] bool check = false;
    private void OnTriggerEnter(Collider other)
    {
        if (this.name == "teleporter1")
        {
            Vector3 telPos = player.transform.position;
            telPos.x = player.transform.position.x - 195;
            cam.transform.position = telPos;
            player.transform.position = telPos;
        }
        if (this.name == "teleporter2")
        {
            Vector3 telPos = player.transform.position;
            telPos.x = player.transform.position.x + 195;
            telPos.z = player.transform.position.z + 120;
            cam.transform.position = telPos;
            player.transform.position = telPos;
        }
        if (this.name == "teleporter3")
        {
            if (check == true)
            {
                Vector3 telPos = player.transform.position;
                telPos.x = 74;
                telPos.z = -10;
                cam.transform.position = telPos;
                player.transform.position = telPos;
                check = false;
                return;
            }
            check = true;
        }
    }
}
