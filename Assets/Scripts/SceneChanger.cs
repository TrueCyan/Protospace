using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public DoorCtrl CloseDoor;
    public string LinkedScene;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        DontDestroyOnLoad(other.gameObject);
        CloseDoor?.SetOpen(false);
        StartCoroutine(WaitAndChange(CloseDoor.OpenTime));
    }

    IEnumerator WaitAndChange(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(LinkedScene);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
