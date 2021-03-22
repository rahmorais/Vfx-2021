using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectprojectile : MonoBehaviour
{
    public GameObject vfxHit;
    private Material Hitshield;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "projectile")
        {
            var hit = Instantiate(vfxHit, transform) as GameObject;
            var psr = hit.transform.GetComponent<ParticleSystemRenderer>();
            Hitshield = psr.material;
            Hitshield.SetVector("_SCenter", other.transform.position - transform.position);
            Destroy(hit, 2);
        }


    }
   
      
    

    
}
