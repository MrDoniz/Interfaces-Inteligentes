using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notificador : MonoBehaviour {
  public delegate void mensaje();
  public event mensaje OnMiEvento;
  public int contador;
  
  void Start() {
    contador = 0;
  }

  void Update() {
    contador = contador + 1;
    if (contador % 1000 == 0)
      OnMiEvento();
  }
}
