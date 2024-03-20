using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{

    [SerializeField] float yValue = 0.00f;
    [SerializeField] float moveSpeed = 10f;
    void Start()
    {

    }


    void Update()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);

    }
}
