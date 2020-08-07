using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEventsComponent : MonoBehaviour,IHasOriginalColour
{
    Color _originalColour;
    void Start () 
    {
        _originalColour = this.GetComponent <MeshRenderer >().materials[0].color;
    }


    void Update () 
    {

    }
    public Color GetOriginalColour()
    {
        return this._originalColour;
    }

    private void OnCollisionEnter(Collision collision)
    {
        this.GetComponent <MeshRenderer >().materials[0].color = Color.black;
    }
    private void OnCollisionStay(Collision collision)
    {

    }
    private void OnCollisionExit(Collision collision)
    {
        this.GetComponent <MeshRenderer >().materials[0].color = _originalColour;
    }
}