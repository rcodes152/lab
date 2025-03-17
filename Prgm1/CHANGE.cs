using UnityEngine;

public class CHANGE : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  public GameObject cube, sphere, plane;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
             cube.transform.position  += new Vector3(0,0,0.5f);
        }
        if (Input.GetKey(KeyCode.S)) {
             cube.transform.position  -= new Vector3(0,0,0.5f);
        }
        if (Input.GetKey(KeyCode.A)) {
             sphere.transform.position  += new Vector3(0.5f,0,0);
        }
        if (Input.GetKey(KeyCode.D)) {
             sphere.transform.position  -= new Vector3(0.5f,0,0);
        }
        if (Input.GetKey(KeyCode.X)) {
             plane.transform.position  += new Vector3(0,0.5f,0);
        }
          if (Input.GetKey(KeyCode.Z)) {
             plane.transform.position  -= new Vector3(0,0.5f,0);
        }
        if (Input.GetKey(KeyCode.R)) {
              cube.transform.Rotate(1,0,0);
        }
        if (Input.GetKey(KeyCode.T)) {
              sphere.transform.Rotate(0,1,0);
        }
        if (Input.GetKey(KeyCode.Y)) {
              plane.transform.Rotate(0,0,1);
        }
         if (Input.GetKey(KeyCode.P)) {
             plane.transform.localScale  += new Vector3(0,0.5f,0);
        }
      
         if (Input.GetKey(KeyCode.I)) {
             cube.transform.localScale  += new Vector3(0.5f,0,0);
        }
      
         if (Input.GetKey(KeyCode.L)) {
             sphere.transform.localScale   += new Vector3(0,0,0.5f);
        }
      
    }
} 