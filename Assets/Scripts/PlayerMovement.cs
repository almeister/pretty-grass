using System;
using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
  [SerializeField, Range(0, 100)] float movementSpeed = 5f;

  public Transform head;

  void Update()
  {
    float xAxis = Input.GetAxis("Horizontal");
    Debug.Log($"xAxis: {xAxis}");
    float zAxis = Input.GetAxis("Vertical");
    Debug.Log($"zAxis: {zAxis}");

    Vector3 movement = new Vector3(xAxis, 0, zAxis);
    transform.Translate(movementSpeed * Time.deltaTime * movement);
  }
}
