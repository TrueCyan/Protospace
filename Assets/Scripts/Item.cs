using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

[ExecuteInEditMode]
public class Item : MonoBehaviour
{
    public enum Type
    {
        key,
        other
    }
    public Sprite ItemImage;
    public Type ItemType;
    public Color ItemColor;
    public GameObject ItemObj;
    public Material DefaultMat;
    public float FloatPeriod = 1;
    public float FloatAmp = 0.2f;
    public float RotateSpeed = 30f;
    private float _time;
    private Renderer _renderer;
    private Material _keyMat;

    private void Start()
    {
        _renderer = ItemObj.GetComponent<Renderer>();
        _keyMat = new Material(DefaultMat);
        _renderer.material = _keyMat;
    }

    private void Update()
    {
        if (_keyMat.color != ItemColor)
        {
            _keyMat.color = ItemColor;
        }

        if (Application.isPlaying)
        {
            _time += Time.deltaTime;
            if (_time > FloatPeriod) _time -= FloatPeriod;
            ItemObj.transform.localPosition = new Vector3(0, FloatAmp * Mathf.Sin(_time / FloatPeriod * Mathf.PI * 2), 0);
            ItemObj.transform.Rotate(Vector3.up, RotateSpeed * Time.deltaTime);
        }
    }

    public ItemInfo Get()
    {
        var info = new ItemInfo(ItemImage, ItemType, ItemColor);
        gameObject.SetActive(false);
        return info;
    }
}

public class ItemInfo
{
    public Sprite ItemImage;
    public Item.Type ItemType;
    public Color ItemColor;

    public ItemInfo(Sprite img, Item.Type type, Color col)
    {
        ItemImage = img;
        ItemType = type;
        ItemColor = col;
    }
}
