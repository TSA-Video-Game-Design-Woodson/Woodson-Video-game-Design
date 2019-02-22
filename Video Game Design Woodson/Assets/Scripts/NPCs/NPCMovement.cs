using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public float moveSpeed = 2f;

    Rigidbody rb;

    bool Moving = false;

    float walkTime = 1;
    float walk;
    float waitTime = 3;
    float wait;

    int action;
    int prevAction;

    GameObject self;
    Animator NPCAnim;

    // Start is called before the first frame update
    void Start()
    {
        walk = walkTime;
        wait = waitTime;
        rb = gameObject.GetComponent<Rigidbody>();
        self = gameObject;
        NPCAnim = self.GetComponent<Animator>();
        chooseAction();

    }

    // Update is called once per frame
    void Update()
    {
        switch (action)
        {
            case 0:
                transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
                NPCAnim.SetBool("MovingLeftRight", true);
                NPCAnim.SetBool("Moving", false);
                NPCAnim.SetBool("MovingUp", false);
                NPCAnim.SetBool("Idle", false);
                NPCAnim.SetBool("WasMovingLeft/Right", false);
                NPCAnim.SetBool("WasMovingUp", false);
                self.GetComponent<SpriteRenderer>().flipX = false;
                prevAction = 0;
                break;

            case 1:
                transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
                NPCAnim.SetBool("MovingLeftRight", true);
                NPCAnim.SetBool("Moving", false);
                NPCAnim.SetBool("MovingUp", false);
                NPCAnim.SetBool("Idle", false);
                NPCAnim.SetBool("WasMovingLeft/Right", false);
                NPCAnim.SetBool("WasMovingUp", false);
                self.GetComponent<SpriteRenderer>().flipX = true;
                prevAction = 1;
                break;

            case 2:
                transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
                NPCAnim.SetBool("MovingUp", true);
                NPCAnim.SetBool("Moving", false);
                NPCAnim.SetBool("MovingLeftRight", false);
                NPCAnim.SetBool("Idle", false);
                NPCAnim.SetBool("WasMovingLeft/Right", false);
                NPCAnim.SetBool("WasMovingUp", false);
                prevAction = 2;
                break;


            case 3:
                transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
                NPCAnim.SetBool("Moving", true);
                NPCAnim.SetBool("MovingLeftRight", false);
                NPCAnim.SetBool("MovingUp", false);
                NPCAnim.SetBool("Idle", false);
                NPCAnim.SetBool("WasMovingLeft/Right", false);
                NPCAnim.SetBool("WasMovingUp", false);
                prevAction = 3;
                break;

            case 4:
                NPCAnim.SetBool("Idle", true);
                prevAction = 4;
                switch (prevAction)
                {
                    case 0:
                        NPCAnim.SetBool("WasMovingLeft/Right", true);
                        self.GetComponent<SpriteRenderer>().flipX = false;
                        break;

                    case 1:
                        NPCAnim.SetBool("WasMovingLeft/Right", true);
                        self.GetComponent<SpriteRenderer>().flipX = true;
                        break;

                    case 2:
                        NPCAnim.SetBool("WasMovingUp", true);
                        break;

                    case 3:
                        NPCAnim.SetBool("Idle", true);
                        break;

                }
                break;
        }

        if (Moving)
        {
            walk -= Time.deltaTime;

            if (walk < 0)
            {
                Moving = false;
                wait = waitTime;
            }
        }
        else
        {
            wait -= Time.deltaTime;

            if (wait < 0)
            {
                chooseAction();
            }
        }



    }

    public void chooseAction()
    {
        action = Random.Range(0, 5);
        Moving = true;
        walk = walkTime;
    }
}
