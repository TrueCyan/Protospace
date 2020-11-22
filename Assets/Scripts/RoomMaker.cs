using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[ExecuteInEditMode]
public class RoomMaker : MonoBehaviour
{
    public float Thickness = 0.1f;

    public Transform XPlus;
    public Transform XMinus;
    public Transform YPlus;
    public Transform YMinus;
    public Transform ZPlus;
    public Transform ZMinus;

    // Update is called once per frame
    void Update()
    {
        var scale = transform.localScale;

        /*

        var xpdelta = XPlus.localPosition.x - (0.5f - (Thickness / scale.x / 2));
        var xmdelta = XMinus.localPosition.x + (0.5f - (Thickness / scale.x / 2));
        var ypdelta = YPlus.localPosition.y - (0.5f - (Thickness / scale.y / 2));
        var ymdelta = YMinus.localPosition.y + (0.5f - (Thickness / scale.y / 2));
        var zpdelta = ZPlus.localPosition.z - (0.5f - (Thickness / scale.z / 2));
        var zmdelta = ZMinus.localPosition.z + (0.5f - (Thickness / scale.z / 2));

        var delta = new Vector3((xpdelta + xmdelta) / scale.x, (ypdelta + ymdelta) / scale.y,
            (zpdelta + zmdelta) / scale.z) / 2;
        */
        //transform.position += delta;
        

        if (XPlus) XPlus.localPosition = new Vector3(0.5f - (Thickness / scale.x / 2), 0, 0);
        if (XMinus) XMinus.localPosition = -new Vector3(0.5f - (Thickness / scale.x / 2), 0, 0);
        if (YPlus) YPlus.localPosition = new Vector3(0, 0.5f - (Thickness / scale.y / 2), 0);
        if (YMinus) YMinus.localPosition = -new Vector3(0, 0.5f - (Thickness / scale.y / 2), 0);
        if (ZPlus) ZPlus.localPosition = new Vector3(0, 0, 0.5f - (Thickness / scale.z / 2));
        if (ZMinus) ZMinus.localPosition = -new Vector3(0, 0, 0.5f - (Thickness / scale.z / 2));


        if (XPlus) XPlus.localScale = new Vector3(1, Thickness / scale.x, 1);
        if (XMinus) XMinus.localScale = new Vector3(1, Thickness / scale.x, 1);
        if (YPlus) YPlus.localScale = new Vector3(1, Thickness / scale.y, 1);
        if (YMinus) YMinus.localScale = new Vector3(1, Thickness / scale.y, 1);
        if (ZPlus) ZPlus.localScale = new Vector3(1, Thickness / scale.z, 1);
        if (ZMinus) ZMinus.localScale = new Vector3(1, Thickness / scale.z, 1);
    }
}
