using UnityEngine;

namespace Food.Runtime
{
    public class VFXplayer : MonoBehaviour
    {
       
        void Start()
        {
            GetComponent<ParticleSystem>().Play();
        
        }

        
        void Update()
        {
        
        }
    }
}
