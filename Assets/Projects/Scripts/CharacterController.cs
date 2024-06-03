using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField]
    public float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        Animator characterAnimator = this.GetComponent<Animator>();

        KeyCode forwardKey = KeyCode.UpArrow;
        KeyCode backwardKey = KeyCode.DownArrow;
        KeyCode leftKey = KeyCode.LeftArrow;
        KeyCode rightKey = KeyCode.RightArrow;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            characterAnimator.SetTrigger("jumpTrigger");
        }

        if (Input.GetKey(forwardKey) || Input.GetKey(backwardKey) || Input.GetKey(leftKey) || Input.GetKey(rightKey))
        {
            characterAnimator.SetBool("isRunForward", true);
            if(Input.GetKey(forwardKey) && Input.GetKey(leftKey) || Input.GetKey(backwardKey) && Input.GetKey(rightKey))
            {
                characterAnimator.SetBool("isRunLeft", true);
            }
            else
            {
                characterAnimator.SetBool("isRunLeft", false);
            }
            if (Input.GetKey(forwardKey) && Input.GetKey(rightKey) || Input.GetKey(backwardKey) && Input.GetKey(leftKey))
            {
                characterAnimator.SetBool("isRunRight", true);
            }
            else
            {
                characterAnimator.SetBool("isRunRight", false);
            }
        }
        else
        {
            characterAnimator.SetBool("isRunForward", false);
        }

        move(forwardKey, backwardKey, leftKey, rightKey);


        if (Input.GetKeyDown(KeyCode.L))
        {
            //this.transform.localEulerAngles = new Vector3(this.transform.localEulerAngles.x, cameraTransform.localEulerAngles.y, this.transform.localEulerAngles.z);
        }
    }

    public void move(KeyCode forwardKey,KeyCode backwardKey,KeyCode leftKey,KeyCode rightKey)
    {
        Transform characterParentTransform = this.transform.parent.transform;

        if (Input.GetKey(forwardKey))
        {
            characterParentTransform.Translate(0, 0, speed);
            this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        if (Input.GetKey(backwardKey))
        {
            characterParentTransform.Translate(0, 0, -speed);
            this.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        if (Input.GetKey(leftKey))
        {
            characterParentTransform.Translate(-speed, 0, 0);
            this.transform.rotation = Quaternion.Euler(0f, 270f, 0f);
        }
        if (Input.GetKey(rightKey))
        {
            characterParentTransform.Translate(speed, 0, 0);
            this.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }
    }
}
