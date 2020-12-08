using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCtrl : MonoBehaviour
{
    public int Size = 4;
    public List<ItemInfo> Inventory = new List<ItemInfo>();
    public InventoryDisplayer Displayer;

    // Start is called before the first frame update
    void Start()
    {
        Displayer.Create(Size);
        Displayer.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F))
        {
            var item = other.GetComponent<Item>();
            if (item)
            {
                var info = item.Get();
                Inventory.Add(info);
                Displayer.ImageUpdate(Inventory);
                return;
            }

            var door = other.GetComponent<DoorCtrl>();
            if (door)
            {
                for (var i = 0; i < Inventory.Count; i++)
                {
                    var info = Inventory[i];
                    if (info.ItemType == Item.Type.key)
                    {
                        var success = door.TryOpen(info.ItemColor);
                        if (success)
                        {
                            Inventory.RemoveAt(i);
                            Displayer.ImageUpdate(Inventory);
                            return;
                        }
                    }
                }
            }
        }
    }
}
