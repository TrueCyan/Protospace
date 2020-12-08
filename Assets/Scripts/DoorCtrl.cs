using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

[ExecuteInEditMode]
public class DoorCtrl : MonoBehaviour
{
    public Color DoorColor;
    public Transform DoorLeft;
    public Transform DoorRight;
    public float OpenWidth;
    public float OpenTime; //second
    public Material DefaultMat;
    private float _openRatio;
    [SerializeField]private bool _open;

    private List<Renderer> _doorRenderer = new List<Renderer>();
    private Material _doorMat;

    // Start is called before the first frame update
    void Start()
    {
        _doorRenderer.AddRange(DoorLeft.GetComponentsInChildren<Renderer>());
        _doorRenderer.AddRange(DoorRight.GetComponentsInChildren<Renderer>());
        _doorMat = new Material(DefaultMat);
        foreach (var renderer in _doorRenderer)
        {
            renderer.material = _doorMat;
        }

        _doorMat.color = DoorColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (_doorMat.color != DoorColor)
        {
            _doorMat.color = DoorColor;
        }

        if (Application.isPlaying)
        {
            if (_open && _openRatio < 1)
            {
                _openRatio += 1 / OpenTime * Time.deltaTime;
                if (_openRatio > 1) _openRatio = 1;
            }
            else if (!_open && _openRatio > 0)
            {
                _openRatio -= 1 / OpenTime * Time.deltaTime;
                if (_openRatio < 0) _openRatio = 0;
            }

            DoorLeft.localPosition = new Vector3(-OpenWidth / 2 * _openRatio, 0);
            DoorRight.localPosition = new Vector3(OpenWidth / 2 * _openRatio, 0);
        }
        
    }

    public void SetOpen(bool state)
    {
        _open = state;
    }

    public bool TryOpen(Color color)
    {
        if (DoorColor.Equals(color))
        {
            SetOpen(true);
            return true;
        }

        return false;
    }
}
