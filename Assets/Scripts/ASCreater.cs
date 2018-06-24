using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using AudiStory;

namespace AudiStory
{

    public class ASCreater: MonoBehaviour
    {
        public static ASCreater Instance;
        public ASTask taskData; 

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
            }
            else
            {
                DontDestroyOnLoad(gameObject);
                Instance = this;
            }
            taskData = new ASTask();
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


