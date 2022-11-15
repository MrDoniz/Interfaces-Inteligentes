using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienDestroyer : MonoBehaviour
{
  [Header("AlienDestroyer")]
  [Tooltip("Distancia AlienDestroyer")]
public float distancia = 50.0f;
  void Start() {
      
  }
  void Update() {
    if (Vector3.Distance(GameObject.FindWithTag("Jugador").transform.position, transform.position) < distancia) {
      Debug.Log("Cerca");
      GameObject.FindWithTag("Jugador").transform.position = new Vector3(transform.position.x, 4.159f, transform.position.z);
    }
  }
}
