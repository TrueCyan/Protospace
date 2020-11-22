using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_trigger : MonoBehaviour
{  public GameObject press ;
    void OnTriggerStay(Collider col){
        
        if(col.gameObject.tag=="key"){
             press.transform.position=

            if(Input.GetKey(KeyCode.Space)){
               var key_info=col.gameObject.GetComponent<Inventory_key>().info;
                Trigger(key_info);
                 Debug.Log("Done");
            }
        }
    }

    public void Trigger(Inventory_class info){
        var sys=FindObjectOfType<Inventory>();
            sys.Activation(info);
    }
}
