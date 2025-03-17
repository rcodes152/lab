using UnityEditor;
using UnityEngine;

public class sprite : MonoBehaviour
{
    [SerializeField] float speed= 20f;
    [SerializeField] float distance= 10f;

    RaycastHit2D hit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Press enter to begin");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward*speed*Time.deltaTime);
        hit = Physics2D.Raycast(transform.position,transform.right,distance);
        if (hit.collider!=null){
            Debug.DrawRay (transform.position, hit.point,Color.red);
            Debug.Log ("Hit"+hit.collider.name +" | Distance"+ hit.distance);
        }
        else{
            Debug.DrawRay(transform.position,transform.right*distance,Color.green);
            Debug.Log("NO HIT");
        }

    }
}
