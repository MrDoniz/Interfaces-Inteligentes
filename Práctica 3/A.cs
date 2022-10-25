using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour {
  private Transform tranformA;
  public Jugador jugador;
  public C C;

  private Rigidbody rb;

  private bool cerca_bool = false;
  private bool esta_dentro = false;

  void Start() {
    rb = GetComponent<Rigidbody>();
    tranformA = GetComponent<Transform>();

    C.CercaA += cerca;
    C.NoCercaA += noCerca;

    jugador.mueveAhaciaC += moverHaciaC;
  }

  void Update() {
    if (cerca_bool && !esta_dentro) {
      salta();
      cambiaColor();
      cerca_bool = false;
      esta_dentro = true;
    }
  }

  void cerca() {
    cerca_bool = true;
  }

  void noCerca() {
    cerca_bool = false;
    esta_dentro = false;
  }

  void salta() {
    rb.AddForce(Vector3.up * 10, ForceMode.Impulse);
  }

  void cambiaColor() {
    Color color = new Color(Random.value, Random.value, Random.value, 1.0f);
    GetComponent<Renderer>().material.color = color;
  }

  void moverHaciaC() {
    tranformA.position = Vector3.MoveTowards(tranformA.position, C.transform.position, 10.0f);
  }
}