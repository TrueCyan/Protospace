using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_trigger : MonoBehaviour
{  public GameObject press ;
   public int key_count=0;
    void OnTriggerStay(Collider col){
        
        if(col.gameObject.tag=="key"){
            press.SetActive(true);
             press.transform.position= new Vector3(col.transform.position.x,col.transform.position.y+2,col.transform.position.z);
             

            if(Input.GetKey(KeyCode.F)){
               var key_info=col.gameObject.GetComponent<Inventory_key>().info;
                Trigger(key_info);
                 key_count++;
                 press.SetActive(false);
            }
        }
        if(col.gameObject.tag=="door"){
            if(key_count<1){
                return;
            }
            if(Input.GetKey(KeyCode.F)){
             var door_info=col.gameObject.GetComponent<door_temp>().info;
             Open(door_info);
             key_count=key_count-1;

            }
        }
    }

    public void Trigger(Inventory_class info){
        var sys=FindObjectOfType<Inventory>();
            sys.Activation(info);
    }
    public void Open(Inventory_door info){
         var sys=FindObjectOfType<Inventory>();
         sys.deletion(info);
         
    }
}
