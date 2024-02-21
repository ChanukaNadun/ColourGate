using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacals : MonoBehaviour
{
    public float speed = 3.0f;
    public float outBound = -7.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
        if (transform.position.y < outBound)
        {
            Destroy(gameObject);
        }
    }
}
