using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  wasd : MonoBehaviour {

  public float vel;
  public float omega;
  public RigidBody rb;
  public float strength;

  void Update (){

    if (Input.GetKey(KeyCode.W)){
      transform.Translate(0f, vel, 0f);
    }

    if (Input.GetKey(KeyCode.S)){
      transform.Translate(0f, -vel, 0f);
    }

    if (Input.GetKey(KeyCode.A)){
      transform.Rotate(0f, -omega, 0f);
    }

    if (Input.GetKey(KeyCode.D)){
      transform.Rotate(0f, omega, 0f);
    }

    if (Input.GetKey(KeyCode.Space)){
      rb.AddForce(0f, strength, 0f);
    }
  }
}
