using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    [SerializeField]
    private float _speed = 30.0f;
    private float _angleX = 0.0f;
    private float _angleY = 0.0f;
    private float _angleZ = 0.0f;

    private float _xDistance = 0.0f;
    private float _yDistance = 0.0f;
    private float _zDistance = 0.0f;

    void Start()
    {

    }

    
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, _angleY, 0));
    }
}
