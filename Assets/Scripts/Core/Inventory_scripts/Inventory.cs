using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{   
    public Image item1;
    public Image item2;
    public Image item3;

    public Image item4;

    public List<bool> key_lis = new List<bool>();



    public void Activation(Inventory_class info){
        info.key.SetActive(false);
        if(info.key_num ==1){
                item1.sprite=info.key_img;
                key_lis[0]=true;
        }
        if(info.key_num ==2){
                item2.sprite=info.key_img;
                key_lis[1]=true;
        }
        if(info.key_num ==3){
                item3.sprite=info.key_img;
                key_lis[2]=true;
        }
        if(info.key_num ==4){
                item4.sprite=info.key_img;
                key_lis[3]=true;
        }
        
    }
    public void deletion(Inventory_door info){
           
            if(info.door_num==1 && key_lis[0]!=false){
                    item1.sprite= info.door_img; 
                    info.door_obj.SetActive(false);
            }
            if(info.door_num==2 && key_lis[1]!=false){
                    item2.sprite= info.door_img; 
                    info.door_obj.SetActive(false);
            }
            if(info.door_num==3 && key_lis[2]!=false){
                    item3.sprite= info.door_img; 
                    info.door_obj.SetActive(false);
            }
            if(info.door_num==4 && key_lis[3]!=false){
                    item4.sprite= info.door_img; 
                    info.door_obj.SetActive(false);
            }
            return;
           
    }
}
