using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField]
    public float speed = 0.01f;

    // Update is called once per frame
    void Update()
    {
        Animator characterAnimator = this.GetComponent<Animator>();

        if (Input.GetKeyDown(KeyCode.J))
        {
            characterAnimator.SetTrigger("jumpTrigger");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            characterAnimator.SetBool("isRunForward", true);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, speed);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            characterAnimator.SetBool("isRunForward", false);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            characterAnimator.SetBool("isRunBackward", true);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -speed);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            characterAnimator.SetBool("isRunBackward", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            characterAnimator.SetBool("isRunLeft", true);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            characterAnimator.SetBool("isRunLeft", false);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            characterAnimator.SetBool("isRunRight", true);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            characterAnimator.SetBool("isRunRight", false);
        }
    }
}
