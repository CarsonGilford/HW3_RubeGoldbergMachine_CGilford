using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
   public Transform cameraTransform; 
   Transform cameraFocusTarget;
   //Auto happen when something with a rigidBody2D enters Trigger
void OnTriggerEnter2D(Collider2D activator){
   Debug.Log(activator.name +"Something eneter this trigger");

   //Move camera
   cameraFocusTarget = activator.transform;
}

void Update(){
   if (cameraFocusTarget != null){
   cameraTransform.position = cameraFocusTarget.transform.position + new Vector3(0f,0f, -10f);
  }
}

void OnTriggerExit2D(Collider2D activator){
   if (activator.transform == cameraFocusTarget){
      cameraFocusTarget = null;
      
  }
}
}
