using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;

    CharacterController controller;
    void Start()
    {
       controller = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal"); 
        float v = Input.GetAxisRaw("Vertical");

        Vector3 movimiento = new Vector3(h, 0, v ).normalized;

        controller.Move(movimiento * velocidadMovimiento * Time.deltaTime);
        

    }
}
