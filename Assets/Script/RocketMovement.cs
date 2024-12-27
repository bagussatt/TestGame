using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    public float yspeed = 2.0f;
    public float xspeed = 0.0f;
    public float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * yspeed);

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * xspeed * horizontalInput * Time.deltaTime);
    }
}
