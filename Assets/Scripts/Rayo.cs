using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rayo : MonoBehaviour
{
 
    private Transform cam;
    private float currentVelocity;

    [SerializeField]private LayerMask groundLayer;
    [SerializeField]private LayerMask ignoreLayer;
 

    // Start is called before the first frame update
    void Awake()
    {
        cam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayHit;

            if(Physics.Raycast(ray, out rayHit))
            {
                Debug.Log(rayHit.transform.name);

                if(rayHit.transform.name == "Sphere")
                {
                    Invoke("LoadSphere", 5);
                }

                if(rayHit.transform.name == "Cubo1")
                {
                    Invoke("LoadCubo1", 5);
                }

                if(rayHit.transform.name == "Cubo2")
                {
                    Invoke("LoadCubo2", 5);
                }
            }
        }
    }

    
    public void LoadSphere()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadCubo1()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadCubo2()
    {
        SceneManager.LoadScene(3);
    }
    
    /*public void LoadLevel(int sceneIndex)
   {
        SceneManager.LoadScene("Scene 1 1");
   }
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Cubo")
        {
            SceneManager.Instance.LoadLevel("Scene 1 1");
        }
    }*/
}
