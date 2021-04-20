using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private InputMaster.Inputs controls;
    private Vector2 move;

    private void Awake()
    {
        controls = new InputMaster.Inputs();
        controls.Player.Jump.performed += ctx => Jump();
        controls.Player.Shoot.performed += ctx => Shoot();

        controls.Player.Movement.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Player.Movement.canceled += ctx => move = Vector2.zero;
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void Update()
    {
        Vector2 m = new Vector2(move.x, move.y) * Time.deltaTime;
        transform.Translate(m, Space.World);
    }

    private void Jump()
    {
        Debug.Log("Jump Button Pressed");
    }

    private void Shoot()
    {
        Debug.Log("Shoot Button Pressed");
    }
}
