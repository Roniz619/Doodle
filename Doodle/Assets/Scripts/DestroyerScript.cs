using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour

{
    public GameObject lostCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlatformScript>())
            Destroy(other.gameObject);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
            canvasOn();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void canvasOn()
    {
        lostCanvas.SetActive(true);
    }
}
