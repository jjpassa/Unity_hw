using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecomp : MonoBehaviour
{
   [SerializeField]
    private float _speed = 30.0f;
        // Start is called before the first frame update
    void Start()
    {
       // transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()

        // deltatime : 시간변화량
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += Vector3.forward * Time.deltaTime * _speed;

        if (Input.GetKey(KeyCode.S))
            transform.position += Vector3.back * Time.deltaTime * _speed;

        if (Input.GetKey(KeyCode.A))
            transform.position += Vector3.left * Time.deltaTime * _speed;

        if (Input.GetKey(KeyCode.D))
            transform.position += Vector3.right * Time.deltaTime * _speed;

        // if (Input.GetKey(KeyCode.Z))
        // transform localScale += vector3.one;

        // if (Input.GetKey(KeyCode.X))
        //   scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
        if (Input.GetKey(KeyCode.O))
            transform.localScale += Vector3.one * Time.deltaTime;
        if (input.GetKey(KeyCode.P))
            transform.localScale -= Vector3.one * Time.deltaTime;
    }
}
