﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RBSnake
{
    public class UITransitionCanvas : MonoBehaviour
    {
        public string NextScene;
        public Animator TransitionUIAnimator;

        private Coroutine TransitionRoutine;

        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }

        public void TriggerSceneTransition()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(NextScene);
        }
    }
}