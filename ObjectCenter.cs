using System.Collections;
using UnityEngine;

public class ObjectCenter : MonoBehaviour
{
    public float gizmoSize =0.5f;
    public Color gizmocolor=Color.yellow;
    // Start is called before the first frame update
    void OnDrawGizmos()
    {
        Gizmos.color=gizmocolor;
        Gizmos.DrawWireSphere (transform.position, gizmoSize);
    }

}
