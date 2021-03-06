using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    public Animator anim;
    PlayerInputController playerInputController;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        playerInputController = GetComponent<PlayerInputController>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Mathf.Abs(playerInputController.VerticalInput)>=Mathf.Epsilon || Mathf.Abs(playerInputController.HorizontalInput) >= Mathf.Epsilon)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);

        }*/

        bool isShooting = anim.GetBool("isShooting");


        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("isRunning", true);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("isRunning", false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("backRunning", true);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("backRunning", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("rightRun", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("rightRun", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("leftRun", true);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("leftRun", false);
        }
        if (Input.GetMouseButton(0))
        {
            anim.SetBool("isShooting", true);
            if (isShooting)
            {
                anim.SetBool("refill", true);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("isShooting", false);
           
        }



    }
}
