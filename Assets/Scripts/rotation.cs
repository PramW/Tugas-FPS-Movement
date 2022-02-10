using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
float xrot = 0f;
    [SerializeField]
    private float mouseSensitifitas = 100f;

    // Update is called once per frame
    [SerializeField]
    private Transform Ptugas;
    
     void Start()
     {
         Cursor.lockState = CursorLockMode.Locked;
     }
    void Update()
    {
        float mousex = Input.GetAxis("Mouse X") * mouseSensitifitas * Time.deltaTime;
         float mousey = Input.GetAxis("Mouse Y") * mouseSensitifitas * Time.deltaTime;
         xrot -= mousey;
         xrot = Mathf.Clamp(xrot, -90f, 90f);

         transform.localRotation = Quaternion.Euler(xrot, 0f , 0f);
         Ptugas.Rotate(Vector3.up * mousex);
    }
}

