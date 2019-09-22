/*
 * Mixer Unity SDK
 *
 * Copyright (c) Microsoft Corporation
 * All rights reserved.
 *
 * MIT License
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this
 * software and associated documentation files (the "Software"), to deal in the Software
 * without restriction, including without limitation the rights to use, copy, modify, merge,
 * publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
 * to whom the Software is furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
 * PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
 * FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
 * OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
 * DEALINGS IN THE SOFTWARE.
 */
using Microsoft.Mixer;
using UnityEngine;
using UnityEngine.UI;

namespace MixerInteractiveExamples
{
    public class MixerControl : MonoBehaviour
    {

        public float speed;
        string VisualizerColor = "White";
        string PreVisualizerColor;
        string userPurple;

        Kino.Mirror mirror;

        void Start()
        {
            MixerInteractive.GoInteractive();
            MixerInteractive.OnInteractiveButtonEvent += OnInteractiveButtonEvent;

            mirror = FindObjectOfType<Kino.Mirror>();
            
        }

        public void OnInteractiveButtonEvent(object sender, InteractiveButtonEventArgs e)
        {
            //e.CaptureTransaction(); -charges sparks

            if (MixerInteractive.GetButtonDown("Purple"))
            {
                print(e.Participant.UserName);
                ColorChange("Purple");
                mirror.ChangeState(4, 90f, 30f, true);
                mirror.ChangeCamera(-15.717f, -0.27f, -50.8f, 0f, 90f, 0f, 60f);
            }
            if (MixerInteractive.GetButton("Blue"))
            {
                ColorChange("Blue");
            }
            if (MixerInteractive.GetButton("Green"))
            {
                mirror.ChangeState(3, 90f, 30f, true);
                mirror.ChangeCamera(-15.717f, -0.27f, -47.29f, 0f, 90f, 0f, 76.2f);
                ColorChange("Green");
            }
            if (MixerInteractive.GetButton("White"))
            {
                ColorChange("White");
            }
        }

        void Update()
        {
            JoystickControl();
        }

        void ColorChange(string colorToChange)
        {
            PreVisualizerColor = VisualizerColor;
            VisualizerColor = colorToChange;
            BroadcastMessage(VisualizerColor);
            BroadcastMessage(PreVisualizerColor + "X");
        }

        private void JoystickControl()
        {
            if (MixerInteractive.GetJoystickX("joystick1") < 0)
            {
                print("ah");
                transform.position += new Vector3(-1 * speed, 0, 0);
            }
            else if (MixerInteractive.GetJoystickX("joystick1") > 0)
            {
                print("wah");
                transform.position += new Vector3(speed, 0, 0);
            }
            if (MixerInteractive.GetJoystickY("joystick1") < 0)
            {
                print("zah");
                transform.position += new Vector3(0, -1 * speed, 0);
            }
            else if (MixerInteractive.GetJoystickY("joystick1") > 0)
            {
                print("hah");
                transform.position += new Vector3(0, speed, 0);
            }
        }
    }
}

