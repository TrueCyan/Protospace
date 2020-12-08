using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue_space : MonoBehaviour
{
    public GameObject talk;
    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag=="Player"){
            var sys =talk.gameObject.GetComponent<Dialogue_activate>();
            sys.Activate=true;
           gameObject.SetActive(false);
        }
    }
}
