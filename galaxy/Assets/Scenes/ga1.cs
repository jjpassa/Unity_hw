using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ga1 : MonoBehaviour
{
    [SerializeField]
    private float _speed = 30.0f;
    private float _angleX = 0.0f;
    private float _angleY = 0.0f;
    private float _angleZ = 0.0f;

    private float _xDistance = 0.0f;
    private float _yDistance = 0.0f;
    private float _zDistance = 0.0f;

   // private float rotateAngle = 0f;
  //  private float selfRotateAngle = 0f;
   // public static float selfRotateSpeed = 1000f;
   // private float rotateSpeed = selfRotateSpeed / 365.26f;
   // private float rotateRadius = 1.0f;

    void Start()
    {

       // rotateRadius = transform.localPosition.x;

       transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _zDistance += Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            _zDistance -= Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            _xDistance += Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _xDistance += Time.deltaTime * _speed;
        }
        transform.Translate(new Vector3(_xDistance, 0, _zDistance));

        // Scaling
        if (Input.GetKey(KeyCode.O))
            transform.localScale += Vector3.one * Time.deltaTime;
        if (Input.GetKey(KeyCode.P))
            transform.localScale -= Vector3.one * Time.deltaTime;
        // Rotation
        _angleX += Time.deltaTime * _speed;
        _angleY += Time.deltaTime * _speed;
        _angleZ += Time.deltaTime * _speed;
        // y√‡
       // if (Input.GetKey(KeyCode.Z))
            transform.rotation = Quaternion.Euler(new Vector3(0, _angleY, 0));
        // x√‡
        if (Input.GetKey(KeyCode.X))
            transform.rotation = Quaternion.Euler(new Vector3(_angleX, 0, 0));
        // z√‡
        if (Input.GetKey(KeyCode.X))
            transform.rotation = Quaternion.Euler(new Vector3(0, 0,_angleZ));
    }
}
 