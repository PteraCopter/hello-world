using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public GameObject Body;
    public GameObject PitchWing;
    public float n1=-1;
    public float n2=-1;
    float preBodyAngle=0;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ForMoving forMoving=GetComponent<ForMoving>();
        float BodyAngle=Body.transform.localEulerAngles.z;
        if(BodyAngle>180f) {
            BodyAngle-=360f;
            Debug.Log("fu");
        }else Debug.Log("sei");
        float BodyAnglarSpeed=(BodyAngle-preBodyAngle)/Time.deltaTime;
        float f1=-n1*n2;
        float f2=n1+n2;
        float PitchWingAngle=
            Mathf.Asin(-(f1*BodyAngle+f2*BodyAnglarSpeed)*Mathf.PI/180f/forMoving.WingConstant/20);
        PitchWing.transform.localRotation= Quaternion.Euler(0.0f, 0.0f, PitchWingAngle*180f/Mathf.PI);;
        preBodyAngle=BodyAngle;
        Debug.Log("anguler"+BodyAngle);
        Debug.Log("angularSp"+BodyAnglarSpeed);
        Debug.Log(-(f1*BodyAngle+f2*BodyAnglarSpeed)*Mathf.PI/180f/forMoving.WingConstant/20);
    }
}
