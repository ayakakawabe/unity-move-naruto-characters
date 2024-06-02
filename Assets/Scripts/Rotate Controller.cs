using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField]
    public float speed = 20f;

    // Update is called once per frame
    void Update()
    {
        Transform transform = this.transform;
        GameObject center=transform.parent.GetChild(1).gameObject;

        transform.RotateAround(center.transform.position, Vector3.up, speed * Time.deltaTime);
    }

}
