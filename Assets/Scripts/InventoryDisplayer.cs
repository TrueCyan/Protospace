using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryDisplayer : MonoBehaviour
{
    public GameObject SlotPrefab;

    private Image _slotImage;

    private List<Image> _slots = new List<Image>();

    public void Create(int slotNum)
    {
        _slotImage = SlotPrefab.GetComponent<Image>();
        var width = _slotImage.rectTransform.rect.width;

        float startPos = -width * (slotNum - 1) / 2;

        for(var i = 0; i < slotNum; i++)
        {
            var obj = Instantiate(SlotPrefab, transform);
            var rect = obj.GetComponent<RectTransform>();
            rect.anchoredPosition = new Vector2(startPos + i * width, rect.anchoredPosition.y);
            _slots.Add(obj.transform.GetChild(0).GetComponent<Image>());
        }
    }

    public void ImageUpdate(List<ItemInfo> info)
    {
        Clear();
        for (var i = 0; i < Mathf.Min(_slots.Count, info.Count); i++)
        {
            _slots[i].sprite = info[i].ItemImage;
            _slots[i].color = info[i].ItemColor;
        }
    }

    public void Clear()
    {
        foreach (var slot in _slots)
        {
            slot.sprite = null;
            slot.color = Color.clear;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
