using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LockCursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Cursor.lockState= CursorLockMode.Locked;
        UnityEngine.Cursor.visible = false;
        
    }


    private void OnApplicationFocus(bool focus)
    {
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        UnityEngine.Cursor.visible = false;

    }
}
