using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereColliderScript : MonoBehaviour
{
   /// <summary>
   /// OnCollisionEnter is called when this collider/rigidbody has begun
   /// touching another rigidbody/collider.
   /// </summary>
   /// <param name="other">The Collision data associated with this collision.</param>
   void OnCollisionEnter(Collision other)
   {
        Debug.Log("Choque con "+other.gameObject.name);
   }
}
