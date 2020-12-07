using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
#if UNITY_EDITOR
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

    public Vector3 Size = Vector3.one;

    // Update is called once per frame
    void Update()
    {
        if (Size.Equals(Vector3.zero))
        {
            Size = new Vector3(XPlus.position.x - XMinus.position.x + Thickness * 2,
                YPlus.position.y - YMinus.position.y + Thickness * 2,
                ZPlus.position.z - ZMinus.position.z + Thickness * 2);
        }
        var scale = transform.localScale;
        if (!scale.Equals(Vector3.one))
        {
            return;
        }

        /*
        var scale = transform.localScale;

        if (!scale.Equals(Vector3.one))
        {

            Size = scale;

            var tempT = new List<Transform>();
            var tempP = new List<Vector3>();
            foreach (Transform t in transform)
            {
                if (t.parent == transform && t != XPlus && t != YPlus && t != ZPlus && t != XMinus && t != YMinus && t != ZMinus)
                {
                    t.parent = null;
                    tempT.Add(t);
                    tempP.Add(t.position);
                }
            }
            transform.localScale = Vector3.one;
            if (XPlus) XPlus.localRotation = Quaternion.identity;
            if (XMinus) XMinus.localRotation = Quaternion.identity;
            if (YPlus) YPlus.localRotation = Quaternion.identity;
            if (YMinus) YMinus.localRotation = Quaternion.identity;
            if (ZPlus) ZPlus.localRotation = Quaternion.identity;
            if (ZMinus) ZMinus.localRotation = Quaternion.identity;

            if (XPlus) XPlus.localScale = new Vector3(Thickness, Size.y, Size.z);
            if (XMinus) XMinus.localScale = new Vector3(Thickness, Size.y, Size.z);
            if (YPlus) YPlus.localScale = new Vector3(Size.x, Thickness, Size.z);
            if (YMinus) YMinus.localScale = new Vector3(Size.x, Thickness, Size.z);
            if (ZPlus) ZPlus.localScale = new Vector3(Size.x, Size.y, Thickness);
            if (ZMinus) ZMinus.localScale = new Vector3(Size.x, Size.y, Thickness);

            if (XPlus) XPlus.localPosition = new Vector3(scale.x - Thickness, 0, 0)/2;
            if (XMinus) XMinus.localPosition = -new Vector3(scale.x - Thickness, 0, 0)/2;
            if (YPlus) YPlus.localPosition = new Vector3(0, scale.y - Thickness, 0)/2;
            if (YMinus) YMinus.localPosition = -new Vector3(0, scale.y - Thickness, 0)/2;
            if (ZPlus) ZPlus.localPosition = new Vector3(0, 0, scale.z - Thickness)/2;
            if (ZMinus) ZMinus.localPosition = -new Vector3(0, 0, scale.z - Thickness)/2;


            for (var i = 0; i < tempT.Count; i++)
            {
                var t = tempT[i];
                t.parent = transform;
                t.position = tempP[i];
            }
        }
        */

        if (XPlus) XPlus.localScale = new Vector3(Thickness, Size.y, Size.z);
        if (XMinus) XMinus.localScale = new Vector3(Thickness, Size.y, Size.z);
        if (YPlus) YPlus.localScale = new Vector3(Size.x, Thickness, Size.z);
        if (YMinus) YMinus.localScale = new Vector3(Size.x, Thickness, Size.z);
        if (ZPlus) ZPlus.localScale = new Vector3(Size.x, Size.y, Thickness);
        if (ZMinus) ZMinus.localScale = new Vector3(Size.x, Size.y, Thickness);

        if (XPlus) XPlus.localPosition = new Vector3(Size.x - Thickness + 0.01f, 0, 0) / 2;
        if (XMinus) XMinus.localPosition = -new Vector3(Size.x - Thickness + 0.01f, 0, 0) / 2;
        if (YPlus) YPlus.localPosition = new Vector3(0, Size.y - Thickness + 0.01f, 0) / 2;
        if (YMinus) YMinus.localPosition = -new Vector3(0, Size.y - Thickness + 0.01f, 0) / 2;
        if (ZPlus) ZPlus.localPosition = new Vector3(0, 0, Size.z - Thickness + 0.01f) / 2;
        if (ZMinus) ZMinus.localPosition = -new Vector3(0, 0, Size.z - Thickness + 0.01f) / 2;
    }
}
#endif