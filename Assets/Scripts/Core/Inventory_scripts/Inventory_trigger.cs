using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_trigger : MonoBehaviour
{  public GameObject press ;
    void OnTriggerStay(Collider col){
        
        if(col.gameObject.tag=="key"){
            press.SetActive(true);
             press.transform.position= new Vector3(col.transform.position.x,col.transform.position.y+2,col.transform.position.z);
             

            if(Input.GetKey(KeyCode.F)){
               var key_info=col.gameObject.GetComponent<Inventory_key>().info;
                Trigger(key_info);
                 Debug.Log("Done");
                 press.SetActive(false);
            }
        }
    }

    public void Trigger(Inventory_class info){
        var sys=FindObjectOfType<Inventory>();
            sys.Activation(info);
    }
}
