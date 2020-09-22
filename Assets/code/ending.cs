using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D activator){
   Debug.Log(activator.name +"Something eneter this trigger");
   //Release balls
   Destroy(gameObject);
  }
}
