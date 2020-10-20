using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {
   
    
    public GameObject obj;

    public float range = 5f, moveSpeed = 3f, turnSpeed = 40f;

    // private Light myLight;
//    private int numEnemies = 10;
//    void Start () {
 //       myLight = GetComponent <Light> ();
   //     for (int i = 0; i < numEnemies; i++ )
  //  Debug.Log ("Create" + i + "enemies");
   // }

  //  void Update() {
   //     if (Input.GetKeyUp (KeyCode.Space)) {
   //         myLight.enabled = !myLight.enabled;
//}

//if (Input.GetKeyUp (KeyCode.A)){
  //  obj.SetActive (false);
//}

//if (Input.GetKeyUp (KeyCode.S)){
  //  Destroy (obj);
//}
//if (Input.GetKeyUp (KeyCode.R))
  //  obj.GetComponent <Renderer> ().material.color = Color.red;
  //      else if (Input.GetKeyUp (KeyCode.G))
  //  obj.GetComponent <Renderer> ().material.color = Color.green;
  //      else if (Input.GetKeyUp (KeyCode.B))
  //  obj.GetComponent <Renderer> ().material.color = Color.blue;

    
   void Update () {
 //       float h = Input.GetAxis ("Horizontal");
 //       float xPos = h * range;

 //       obj.transform.position = new Vector3 (xPos, 0, 0);
    

      if(Input.GetKey(KeyCode.UpArrow))
        obj.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

      if(Input.GetKey(KeyCode.DownArrow))
        obj.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

      if(Input.GetKey(KeyCode.LeftArrow))
        obj.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

      if(Input.GetKey(KeyCode.RightArrow))
        obj.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }



 //   }
}
