using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {
  [Header("Jugador")]
  [Tooltip("Velocidad")]
  public float MoveSpeed = 20.0f;
  [Tooltip("Sprint")]
  public float sprint = 40.0f;

  public delegate void mensaje();
  public event mensaje crecenLosB;
  public event mensaje mueveAhaciaC;

  private Rigidbody rb;

  void Start() {
    rb = GetComponent<Rigidbody>();
  }

  void Update() {
    if (Input.GetKey(KeyCode.W)) {
      transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.S)) {
      //Se mueve hacia la derecha
      transform.Translate(Vector3.back * MoveSpeed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.A)) {
      transform.Rotate(Vector3.up * -90 * Time.deltaTime);
      transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.D)) {
      transform.Rotate(Vector3.up * 90 * Time.deltaTime);
      transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.LeftShift)) {
      transform.Translate(Vector3.forward * sprint * Time.deltaTime);
    }
  }

  void  OnCollisionEnter(Collision collision) {
    if (collision.gameObject.name == "A") {
      Debug.Log("Crecen los B");
      crecenLosB();
    }
    if (collision.gameObject.name == "B") {
      Debug.Log("Mueve los A hacia C");
      mueveAhaciaC();
    }
  }
}
