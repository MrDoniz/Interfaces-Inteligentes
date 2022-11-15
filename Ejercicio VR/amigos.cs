using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amigos : MonoBehaviour
{
    public jugador jugador;
    void Start()
    {
        jugador.amigosMover += mover;
    }

  public void mover() {
    transform.Translate(Vector3.forward * 5 * Time.deltaTime);
  }
}
