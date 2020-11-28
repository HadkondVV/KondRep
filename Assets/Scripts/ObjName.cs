using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OBJ
{
    public class ObjName : MonoBehaviour
    {
        public GameObject[] Objs;
        Vector3 clickPos;
        Plane plane;
        GeometryObjectModel GOM;
        void Start()
        {
            clickPos = Vector3.one;
            plane = new Plane(Vector3.up, 0f);
            ObjectName ON = JsonUtility.FromJson<ObjectName>(File.ReadAllText(Application.dataPath + @"\ObjNameFile.json"));
            for(int i = 0; i <= 3; i += 1) Objs[i].name = ON.name[i];
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);   
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit)) if(hit.collider.name != "Terrain") return;
                float dist;         
                if (plane.Raycast(ray, out dist)) 
                {
                    clickPos = ray.GetPoint(dist);
                    Instantiate(Objs[Random.Range(0, 4)]).transform.position = clickPos + new Vector3(0, 3, 0);
                }
            }
        }
        class ObjectName
        {
            public string[] name;
        }
    }
}
