using UnityEngine;

public class update : MonoBehaviour
{
   public GameObject cube,sphere,plane;
   public Material newCubeMaterial, newSphereMaterial, newPlaneMaterial;

   public Texture newCubeTexture, newSphereTexture, newPlaneTexture;

   public void changeCuberAppearance(){
    Renderer cubeR= cube.GetComponent<Renderer>();
    cubeR.material= newCubeMaterial;
    cubeR.material.mainTexture= newCubeTexture;
    cubeR.material.color=Color.red;
   }

   public void changeSphereAppearance(){
    Renderer sphereR = sphere.GetComponent<Renderer>();
    sphereR.material=newSphereMaterial;
    sphereR.material.mainTexture=newSphereTexture;
    sphereR.material.color=Color.blue;

   }
   public void changePlaneAppearance(){
    Renderer PlaneR = plane.GetComponent<Renderer>();
    PlaneR.material=newSphereMaterial;
    PlaneR.material.mainTexture=newSphereTexture;
    PlaneR.material.color=Color.blue;

   }
}

