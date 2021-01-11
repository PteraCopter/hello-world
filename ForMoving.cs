using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForMoving : MonoBehaviour
{
    
    
    public float WingConstant=5f;
    public GameObject PitchWing;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody body=GetComponent<Rigidbody>();
        Transform thisTransform=this.GetComponent<Transform>();
        float WingAngle=PitchWing.transform.localEulerAngles.z;
        float PitchTorque=WingConstant*Mathf.Sin(-WingAngle*Mathf.PI/180f);
        //Vector3 TranslationalForce=new Vector3(0f,VerticalForce,0f);
        //body.AddRelativeForce(TranslationalForce);
        //body.AddForce(0,-9.81f*body.mass,0);
        body.AddRelativeTorque(0,0,PitchTorque);
        //thisTransform.Rotate(0,YawSpeed,0);
        //Debug.Log(WingAngle);
    }
}
