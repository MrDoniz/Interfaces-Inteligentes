using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour {
  [Header("Jugador")]
  [Tooltip("Velocidad")]
  public float MoveSpeed = 20.0f;
  [Tooltip("Sprint")]
  public float sprint = 40.0f;
  private Rigidbody rb;
  public int puntos = 0;

  public delegate void mensaje();
  public event mensaje amigosMover;
  public event mensaje BioTorpedoParriba;

  void Start() {
    rb = GetComponent<Rigidbody>();
  }

  void Update() {
    if (Input.GetKey(KeyCode.W)) {
      transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.S)) {
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

    if (Physics.Raycast(transform.position, transform.forward, 100)) {
      //Debug.Log("Mirada centrada");
      amigosMover();
      BioTorpedoParriba();
    }
  }

  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "AlienFighterWhite") {
      Debug.Log("Chocaste con AlienFighterWhite");
      puntos++;
      Debug.Log("Puntos:\n" + puntos);
      GameObject.FindWithTag("Puntos").GetComponent<TMPro.TextMeshProUGUI>().text = "Puntos:\n" + puntos;
    }
  }
}
