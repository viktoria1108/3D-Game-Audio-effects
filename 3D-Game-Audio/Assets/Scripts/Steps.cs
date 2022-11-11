using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Steps : MonoBehaviour
{
    FirstPersonController myController;
    public AudioClip[] stepsWater;
    public AudioClip[] stepsTerrain;

    void Start()
    {
        myController = GetComponent<FirstPersonController>();
    }

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position,-transform.up,out hit, 2))
        {
            if (hit.collider.tag == ("SurfaceWater"))
            {
                myController.m_FootstepSounds = stepsWater;
            }
            else
            {
                myController.m_FootstepSounds = stepsTerrain;
            }
        }
    }
}