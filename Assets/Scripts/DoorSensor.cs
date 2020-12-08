using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSensor : MonoBehaviour
{
    public DoorCtrl OpenDoor;
    public bool AutoClose;
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        OpenDoor?.SetOpen(true);
    }
    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        if(AutoClose) OpenDoor?.SetOpen(false);
    }
}
