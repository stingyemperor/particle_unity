using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;



namespace soil {
    
    public struct Particle
    {
        public Vector3 position;
        public float inverseMass;
    }
    
    
    public class soil_particle : MonoBehaviour
    {
        public float m_mass = 1;
        public int m_particlesCount;  // Number of Particles
        public int m_maxParticles;  // Max number of particles
        public int m_particleIndex = -1;

        public Particle[] m_partcles;   //container for particle positions
        public Particle[] m_restParticles;  //Particle positions in rest - collisions disabled
        public Particle[] m_smoothedParticles;  //For rendering;
        public Color[] m_colors;
        public Vector3 m_velocities;
        public bool[] m_particleActivity;
        public Vector3 m_initialVelocity;

        public Bounds m_bounds;
        public int m_activeCount = 0; 


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            m_activeCount = 0;
            for (int i = 0; i < m_particlesCount; i++)
            {
                m_activeCount++;
            }
        }
    }
}


