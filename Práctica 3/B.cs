using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour {
  public float cuanto = 5.0f;
  private Transform tranformB;
  public Jugador jugador;
  public C C;

  void Start() {
    tranformB = GetComponent<Transform>();
    jugador.crecenLosB += incrementaEscala;
    C.CercaA += rotar;
  }

  void Update() {}

  public void incrementaEscala() {
    cuanto += 1.0f;
    tranformB.localScale += new Vector3(cuanto, cuanto, cuanto);
  }

  void rotar() {
    GameObject toOrientate = GameObject.Find("EsferaNegra");
    transform.LookAt(toOrientate.transform);
    Debug.DrawRay(transform.position, toOrientate.transform.position - transform.position, Color.red);
  }
}
