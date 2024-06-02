using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public GameObject center;
    public float angle = 20f;

    // Update is called once per frame
    void Update()
    {
        Transform transform = this.transform;

        if (Input.GetKey(KeyCode.H))
        {
            transform.RotateAround(center.transform.position, Vector3.up, angle * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.RotateAround(center.transform.position, Vector3.down, angle * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.RotateAround(center.transform.position, Vector3.left, -angle * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.RotateAround(center.transform.position, Vector3.right, -angle * Time.deltaTime);
        }
    }
}