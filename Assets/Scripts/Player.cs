using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;

    private Vector2 _moveDirection;

    private Rigidbody rb;

    void Start()
    {
        InputManager.Init(myPlayer: this);
        InputManager.SetGameControls();
    }

    // Update is called once per frame
    void Update()
    {
       transform.position += (Vector3)(speed * Time.deltaTime * _moveDirection);

    }

    public void SetMovmentDirection(Vector2 currentDirection )
    {
        _moveDirection = currentDirection;
    }
}
