using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructObj : InteractObject {
    FracturedObject fracturedObject;
    public override void InteractAction()
    {
        base.InteractAction();
        fracturedObject=GetComponent<FracturedObject>();
        fracturedObject.Explode(transform.position, 300f);
    }
}
