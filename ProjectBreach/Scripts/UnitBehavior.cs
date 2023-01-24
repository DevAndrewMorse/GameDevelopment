using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitBehavior : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 4f;
    private Vector3 _targetPosition;


    private void Update()
    {
        ClickControls();
    }

    private void ClickControls ()
    {
        float stoppingDistance = .1f;

        if (Vector3.Distance(transform.position, _targetPosition) > stoppingDistance)
        {
            Vector3 moveDirection = (_targetPosition - transform.position).normalized;
            transform.position += moveDirection * _moveSpeed * Time.deltaTime;
        }

        //Testing
        if (Input.GetMouseButtonDown(0))
        {
            Move(MouseBehavior.GetPosition());
        }
    }

    private void Move(Vector3 targetPosition) 
    {
        this._targetPosition = targetPosition;
    }
}
