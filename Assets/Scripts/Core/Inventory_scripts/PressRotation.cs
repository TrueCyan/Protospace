using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressRotation : MonoBehaviour
{   Transform cam;
    public GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        cam=Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(transform.position+cam.rotation*Vector3.forward,cam.rotation*Vector3.up);
        if(key.activeSelf==false){
            gameObject.SetActive(false);
        }
    }
}
