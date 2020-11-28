using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace OBJ
{
    public class GeometryObjectModel : MonoBehaviour
    {
        int ClickCount;
        public int MinClicksCount;
        public int MaxClicksCount;
        public Color ObjectColor;
        CompositeDisposable disposables;
        static System.Random rand = new System.Random();
        void Start () 
        {
            Observable.Timer(System.TimeSpan.FromSeconds(3)).Repeat().Subscribe(_ => 
            { 
                this.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            }).AddTo (disposables);
        }
        void OnEnable() 
        {
            disposables = new CompositeDisposable();
        }
        void OnDisable() 
        {
            if (disposables != null) disposables.Dispose ();
        }
        void OnMouseDown() 
        {
            if(++ClickCount >= MinClicksCount && ClickCount <= MaxClicksCount) this.gameObject.GetComponent<Renderer>().material.color = ObjectColor;
        }
    }
}
