using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    internal AudioController Audio;
    [SerializeField]
    internal InputController Input;
    [SerializeField]
    internal PhysicsController Physics;
    [SerializeField]
    internal StateController States;

    public Vector3 Movimiento;
    public float Velocidad;

    void Start()
    {
        Audio = this.GetComponent<AudioController>();
        Input = this.GetComponent<InputController>();
        Physics = this.GetComponent<PhysicsController>(); 
        States = this.GetComponent<StateController>();
    }

    void Update()
    {
        Input.update(this);
        States.update(this);
    }

}
