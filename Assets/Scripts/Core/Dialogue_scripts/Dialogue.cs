using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{   
    public Text txtName;
    public Text txtSentence;
    Queue <string> sentences =new Queue<string>();
    public void Begin(Dialogue_info info){
       sentences.Clear();
    txtName.text=info.name;
       foreach(var sentence in info.sentences){
           sentences.Enqueue(sentence);

       }
       Next();
    }
    public void Next(){
        if(sentences.Count==0){
            finish();
            return;
        }
        txtSentence.text=sentences.Dequeue();
       
    }
    public void finish(){
        txtSentence.text=string.Empty;
        txtName.text=string.Empty;
        var systrigger=FindObjectOfType<DialogueTrigger>();
        
       
            systrigger.TriggerAgain();
        
        
    }
}
