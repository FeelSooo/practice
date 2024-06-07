using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // ���������� ���������� � ������� InputSystem
     
    [SerializeField] private float moveSpeed = 1f;

    private PlayerControls playerControls;
    private Vector2 movement; // ������ ��� �������� ����������� ��������
    private Rigidbody2D rb; // ������ �� ��������� Rigidbody2D, ������� ������� ��� ���������� ������� ������� 

    private void Awake()  // ����� ���������� ��� ������������� �������, ��������� ������ ��� ���������� ������
    {
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable() // ����� ���������� ��� ��������� �������, ���������� ������� ���������� ������
    {
        playerControls.Enable();
    }
    private void Update() // ��������� ����� ������, ������� �� ���
    {
        PlayerInput();
    }

    private void FixedUpdate() // ���������� � ������������� �������� ������, ������������������ � ���.�������, ���������� �������� ����������� �������
    {                          // �� ������� �� ���
        Move();
    }

    private void PlayerInput() // ��������� ���� ������, �������� �������� ������� �� ����� �����
    {
        movement = playerControls.Movement.Move.ReadValue<Vector2>();
    }

    private void Move() // �������� �� ����������� �������
    {                   // ���������� Rigidbody2D � ����� ��������� �� ������ ������� �������, ����������� �������� � ��������
        rb.MovePosition(rb.position + movement * (moveSpeed * Time.fixedDeltaTime));
    }
}
