using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
  
  public List<Dialogue_info> lis=new List<Dialogue_info>();
  private Renderer rend ;
  public int lis_orisize=0;
  void Start(){
    lis_orisize=lis.Count;
  }
  public void Trigger(Dialogue_info info){
      var sys=FindObjectOfType<Dialogue>();
      sys.Begin(info);
  }
  public void TriggerAgain(){
   
      if (lis.Count<1 ){
        Debug.Log(lis.Count);
        gameObject.GetComponentInParent<Dialogue_activate>().Activate=false;
        gameObject.SetActive(false);
        
        return;
        
      }
       Trigger(lis[0]);
       lis.Remove(lis[0]);
  }
  public void TriggerStart(){
      if(lis.Count==lis_orisize){
        TriggerAgain();
      }
  }
}
