using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private static readonly int Run = Animator.StringToHash("Run");
    private static readonly int Attack1 = Animator.StringToHash("Attack");
    
    [SerializeField] float _rollSpeed = 10f;
    [SerializeField] private float speed = 3f;
    


    // Start is called before the first frame update
    void Start()
    {
        //_animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Attack();
        
        Vector3 moveVector = GetMoveVector();
        bool isMove = moveVector != Vector3.zero;

        if (isMove)
        {
            //_animator.SetBool(Run, true);
            Move(moveVector);
        }
        // else
        // {
        //     _animator.SetBool(Run, false);
        // }
        
        //Quaternion lookRotation = Quaternion.LookRotation(new Vector3(moveVector.x, 0f, moveVector.z));
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, Time.deltaTime * _rollSpeed);
    }
    
    private Vector3 GetMoveVector()
    {
        Vector3 moveVector = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            moveVector += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            moveVector += Vector3.back;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            moveVector += Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            moveVector += Vector3.right;
        }
        return moveVector.normalized;
    }

    void Move(Vector3 moveVector)
    {
        // 移動処理
        Vector3 moveDelta;
        moveDelta = moveVector * Time.deltaTime * speed;
        transform.position += moveDelta;
    }

    void Attack()
    {
        int attackState =_animator.GetInteger(Attack1);
        if (Input.GetMouseButtonDown(0))
        {
            switch (attackState)
            {
                case 0:
                    _animator.SetInteger(Attack1, 1);
                    break;
                case 1:
                    _animator.SetInteger(Attack1, 2);
                    break;
                case 2:
                    _animator.SetInteger(Attack1, 3);
                    break;
                case 3:
                    _animator.SetInteger(Attack1, 0);
                    break;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Destroy(other.gameObject);
        }
    }
}
