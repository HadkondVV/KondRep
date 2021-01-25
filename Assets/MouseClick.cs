using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    public GameObject GO;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GO.transform.localPosition = Vector3.MoveTowards(GO.transform.localPosition,End.transform.position,3);
    }

    private void OnMouseUp() {
        Instantiate(GO);
        transform.localScale -= new Vector3(0.1f, 0.1f, 0);
    }
}
