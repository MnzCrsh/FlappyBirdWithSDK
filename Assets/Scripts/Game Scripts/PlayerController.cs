using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rg;

    public float jumpForce = 1000f;
    public Animator jumpAnimation;

    private void Start()
    {
        _rg = GetComponent<Rigidbody2D>();
        jumpAnimation = GetComponent<Animator>();
        jumpAnimation.StopPlayback();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    private void Jump()
    {
        jumpAnimation.Play(0);
        _rg.AddForce(transform.up *  jumpForce);
        jumpAnimation.StopPlayback();
    }
}
