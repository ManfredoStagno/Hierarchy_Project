using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HP.Timers
{
    public class TimeController : MonoBehaviour
    {
        [SerializeField] Text timeText;
        [SerializeField] Text dateText;
        [SerializeField] List<int> speeds;
        
        TimeDate timeDate;
        private bool isRunning = true;
        private float timer;
        private float currentSpeed = 1;
        private int speedIndex = 0;

        void Start() 
        {
            if(timeDate == null) timeDate = new TimeDate();           
        }

        void Update() 
        {
            MoveTime();
            if(isRunning)
            {
                Run();
            }
            UpdateUI();
        }

        private void MoveTime()
        {
            //Stop Time
            if(Input.GetKeyDown(KeyCode.Space)) isRunning = !isRunning;            
            //MoveTime
            if(Input.GetKeyDown(KeyCode.W)) speedIndex += 1;
            if (Input.GetKeyDown(KeyCode.S)) speedIndex -= 1;

            if(speedIndex > speeds.Count - 1) speedIndex = speeds.Count - 1;
            if (speedIndex < 0) speedIndex = 0;
            currentSpeed = speeds[speedIndex];
            print(speedIndex);
        }

        private void Run()
        {
            timer += Time.deltaTime * currentSpeed;
            if (timer > 1f)
            {
                timer = 0f;
                timeDate.IncreaseMins();
            }
        }

        private void UpdateUI()
        {
            timeText.text = timeDate.GetTime();
            dateText.text = timeDate.GetDate();
        }
    }
}


