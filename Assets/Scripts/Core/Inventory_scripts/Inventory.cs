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
    public void Activation(Inventory_class info){
        info.key.SetActive(false);
        if(info.key_num ==1){
                item1.sprite=info.key_img;
        }
        if(info.key_num ==2){
                item2.sprite=info.key_img;
        }
        if(info.key_num ==3){
                item3.sprite=info.key_img;
        }
        if(info.key_num ==4){
                item4.sprite=info.key_img;
        }
        
    }
}
