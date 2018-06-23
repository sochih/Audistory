using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using AudiStory;

namespace AudiStory {

    public class ASPlayer : MonoBehaviour
    {
        public static ASPlayer Instance;


		private void Awake()
		{
            if (Instance != null){
                Destroy(gameObject);
            }else {
                Instance = this; 
            }
		}

		// Use this for initialization
		void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}


