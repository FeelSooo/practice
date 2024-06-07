using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Реализация управления с помощью InputSystem
     
    [SerializeField] private float moveSpeed = 1f;

    private PlayerControls playerControls;
    private Vector2 movement; // вектор для хранения направления движения
    private Rigidbody2D rb; // ссылка на компонент Rigidbody2D, которая юзается для управления физикой объекта 

    private void Awake()  // метод вызывается при инициализации скрипта, создается объект для управления вводом
    {
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable() // метод вызывается при активации объекта, включается система управления вводом
    {
        playerControls.Enable();
    }
    private void Update() // обработка ввода игрока, зависим от фпс
    {
        PlayerInput();
    }

    private void FixedUpdate() // вызывается с фиксированной частотой кадров, синхронизированным с физ.движком, происходит реальное перемещение объекта
    {                          // не зависим от фпс
        Move();
    }

    private void PlayerInput() // считывает ввод игрока, получает значение вектора из схемы ввода
    {
        movement = playerControls.Movement.Move.ReadValue<Vector2>();
    }

    private void Move() // отвечает за перемещение объекта
    {                   // перемещает Rigidbody2D в новое положение на основе текущей позиции, направления движения и скорости
        rb.MovePosition(rb.position + movement * (moveSpeed * Time.fixedDeltaTime));
    }
}
