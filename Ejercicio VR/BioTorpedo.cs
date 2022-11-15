using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BioTorpedo : MonoBehaviour
{
  public jugador jugador;
  // Start is called before the first frame update
  void Start()
  {
    jugador.BioTorpedoParriba += parriba;
  }

  public void parriba() {
    transform.Translate(Vector3.up * 5 * Time.deltaTime);
  }

  // Update is called once per frame
  void Update()
  {
      
  }
}
