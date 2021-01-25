using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject End;
    // Start is called before the first frame update
    bool finish;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!finish)transform.position = Vector3.MoveTowards(transform.position, End.transform.position, 0.2f);
        if(transform.position == End.transform.position) finish = !finish;
        
    }
    private void OnTriggerEnter(Collider other) {
        GetComponent<SphereCollider>().radius = 1;
        if(other.gameObject.name.Substring(0, 4) == "Cube") Destroy(other.gameObject);
    }
}
