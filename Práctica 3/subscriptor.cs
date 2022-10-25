using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subscriptor : MonoBehaviour {
  public notificador notificador;

  void Start() {
  notificador.OnMiEvento += miRespuesta;
  }

  void Update() {}

  void miRespuesta() {
    Debug.Log("Soy el cilindro");
    Debug.Log(notificador.contador);
  }
}
