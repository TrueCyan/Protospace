using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_rotation : MonoBehaviour
{   Transform camera;
    // Start is called before the first frame update
    void Start()
    {
        camera=Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(transform.position+camera.rotation*Vector3.forward,camera.rotation*Vector3.up);
    }
}
