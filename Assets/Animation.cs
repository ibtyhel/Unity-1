using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    float speed = 200f;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(20f, 200f);
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); // Vector3(0, 1, 0)


    }
}
