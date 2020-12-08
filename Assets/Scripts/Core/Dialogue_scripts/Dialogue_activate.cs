using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue_activate : MonoBehaviour
{
    public bool Activate =false;
    public GameObject child;
    void Start(){
        child.SetActive(false);
    }
    void Update(){
        if(Activate==true && child.activeSelf==false){
            child.SetActive(true);
            child.GetComponent<DialogueTrigger>().TriggerAgain();
        }
    }
}
