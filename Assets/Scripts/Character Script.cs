using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField]
    Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            animator.SetTrigger("jumpTrigger");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetBool("isRunForward", true);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            animator.SetBool("isRunForward", false);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetBool("isRunBackward", true);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            animator.SetBool("isRunBackward", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.SetBool("isRunLeft", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("isRunLeft", false);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetBool("isRunRight", true);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetBool("isRunRight", false);
        }
    }
}
