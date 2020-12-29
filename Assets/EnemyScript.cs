using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    float speed = 200f;
    public float min = 1f;
    public float max = 3f;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(min, max);


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); // Vector3(0, 1, 0);
        transform.LookAt(Camera.main.transform);


    }
}