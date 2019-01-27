using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    float moveSpeed = 2f;
    public Animator move;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        { 
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
            move.SetBool("WalkingUp", true);
            move.SetBool("WasMovingUp", false);
            move.SetBool("WasMovingDown", false);
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            move.SetBool("WasMovingUp", true);
            move.SetBool("WalkingUp", false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector2.up * moveSpeed * Time.deltaTime);//Change 2 is Down
            move.SetBool("MovingDown", true);
            move.SetBool("WasMovingDown", false);
            move.SetBool("WasMovingUp", false);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            move.SetBool("WasMovingDown", true);
            move.SetBool("MovingDown", false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);//Change 3 is right
            move.SetBool("Moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            move.SetBool("WasMovingUp", false);
            move.SetBool("WasMovingDown", false);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            move.SetBool("Moving", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime); //Messed up. Change4 is A on the other script, this is going to the right.
            move.SetBool("Moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            move.SetBool("WasMovingDown", false);
            move.SetBool("WasMovingUp", false);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            move.SetBool("Moving", false);
        }

        if (!Input.anyKey || Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            move.SetBool("Moving", false);
            move.SetBool("MovingDown", false);
            move.SetBool("WalkingUp", false);
        }
  }
}