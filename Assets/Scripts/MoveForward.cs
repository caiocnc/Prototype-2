using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Move o objeto para frente
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
