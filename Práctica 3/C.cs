using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C : MonoBehaviour {
  public Jugador jugador;
  public A A;
  private float perimetro = 30.0f;

  public delegate void mensaje();
  public event mensaje CercaA;
  public event mensaje NoCercaA;

  void Start() {}
  void Update() {
    float distance_player = Vector3.Distance(jugador.transform.position, transform.position);
    if (distance_player < perimetro) {
      Debug.Log("Cerca de C, A cambia de color y saltan, B se rotan hacia D");
      CercaA();
    } else {
      NoCercaA();
    }
  }
}
