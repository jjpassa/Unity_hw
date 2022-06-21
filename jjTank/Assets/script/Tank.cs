using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public GameObject _ball;
    public GameObject _muzzle;
    public GameObject _head;
    public GameObject _bullet;
    public float _speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame 
    void Update()
    {
        Move();
        Fire();

       // _ball.transform.position += head.transform.
    }

    private void Move()
    {
        // w
        if (Input.GetKey(KeyCode.W))
        {
            Quaternion q = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.1f);
            transform.rotation = q;
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }
        // s
        if (Input.GetKey(KeyCode.S))
        {
            Quaternion q = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.1f);
            transform.rotation = q;
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }
        // a
        if (Input.GetKey(KeyCode.A))
        {
            Quaternion q = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.1f);
            transform.rotation = q; 
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }
        // d
        if (Input.GetKey(KeyCode.D))
        {
            Quaternion q = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.1f);
            transform.rotation = q;
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);

        }
    }

    private void Fire()
    {
        if(Input.GetMouseButtonUp(0))
        {
            _bullet.transform.position = _muzzle.transform.position;
        }
    }
}
