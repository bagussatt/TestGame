using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject rocket;

    private Vector3 offset = new Vector3(0, 0.416f, -2.5f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = rocket.transform.position + offset;
    }
}
