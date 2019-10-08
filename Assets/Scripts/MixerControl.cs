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

namespace MixerInteractiveExamples
{
    public class MixerControl : MonoBehaviour
    {

        public float speed;
        string VisualizerColor = "White";
        string PreVisualizerColor;

        Kino.Mirror mirror;
        GlitchEffect glitchEffect;
        Kino.Datamosh datamosh;
        GrabAvatar grabbyTheAvatar;

        public float scaleX;
        public float scaleY;
        public float scaleZ;

        public Color32 vRandomAll;

        void Start()
        {
            MixerInteractive.OnInteractiveButtonEvent += OnInteractiveButtonEvent;
            MixerInteractive.GoInteractive();
            
            mirror = FindObjectOfType<Kino.Mirror>();
            glitchEffect = FindObjectOfType<GlitchEffect>();
            datamosh = FindObjectOfType<Kino.Datamosh>();
            grabbyTheAvatar = FindObjectOfType<GrabAvatar>();
        }

        public void OnInteractiveButtonEvent(object sender, InteractiveButtonEventArgs e)
        {
            //e.CaptureTransaction(); -charges sparks
            InteractiveParticipant participant = e.Participant;
            if (MixerInteractive.GetButtonDown("chooseColor"))
            {
                participant.Group = MixerInteractive.GetGroup("color");
            }

            if (MixerInteractive.GetButtonDown("cameraSettings"))
            {
                participant.Group = MixerInteractive.GetGroup("camera");
            }

            if (MixerInteractive.GetButtonDown("mirrorAdjustments"))
            {
                participant.Group = MixerInteractive.GetGroup("mirror");
            }

            if (MixerInteractive.GetButtonDown("glitchEffect"))
            {
                participant.Group = MixerInteractive.GetGroup("glitch");
            }

            if (MixerInteractive.GetButtonDown("datamoshEffect"))
            {
                participant.Group = MixerInteractive.GetGroup("datamosh");
            }

            if (MixerInteractive.GetButtonDown("avatarFun"))
            {
                participant.Group = MixerInteractive.GetGroup("avatar");
            }

            if (MixerInteractive.GetButtonDown("backColor"))
            {
                participant.Group = MixerInteractive.GetGroup("default");
            }

            if (MixerInteractive.GetButtonDown("backCamera"))
            {
                participant.Group = MixerInteractive.GetGroup("default");
            }

            if (MixerInteractive.GetButtonDown("backMirror"))
            {
                participant.Group = MixerInteractive.GetGroup("default");
            }

            if (MixerInteractive.GetButtonDown("backGlitch"))
            {
                participant.Group = MixerInteractive.GetGroup("default");
            }

            if (MixerInteractive.GetButtonDown("backDatamosh"))
            {
                participant.Group = MixerInteractive.GetGroup("default");
            }

            if (MixerInteractive.GetButtonDown("backAvatar"))
            {
                participant.Group = MixerInteractive.GetGroup("default");
            }


            if (MixerInteractive.GetButtonDown("resetCamera"))
            {
                mirror.ChangeCamera(-15.717f, -0.7f, -47.387f, 0f, 90f, 0f, 90f);
            }

            if (MixerInteractive.GetButtonDown("resetMirror"))
            {
                scaleX = 0;
                BroadcastMessage("ChangeScaleX");
                scaleY = 1;
                BroadcastMessage("ChangeScaleY");
                scaleZ = 0;
                BroadcastMessage("ChangeScaleZ");
                mirror.ResetMirror();
            }

            if (MixerInteractive.GetButtonDown("colorBackground"))
            {
                BroadcastMessage("RandomBackgroundColor");
            }

            if (MixerInteractive.GetButtonDown("randomColor"))
            {
                BroadcastMessage("RandomColor");
            }

            if (MixerInteractive.GetButtonDown("randomColorAll"))
            {
                vRandomAll = new Color32((byte)Random.Range(0, 255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 255);
                BroadcastMessage("RandomColorAll");
            }

            if (MixerInteractive.GetButtonDown("randomRed"))
            {
                BroadcastMessage("RandomRed");
            }

            if (MixerInteractive.GetButtonDown("randomGreen"))
            {
                BroadcastMessage("RandomGreen");
            }

            if (MixerInteractive.GetButtonDown("randomBlue"))
            {
                BroadcastMessage("RandomBlue");
            }

            if (MixerInteractive.GetButtonDown("mirrorRepeat"))
            {
                mirror.RandomRepeat();
            }

            if (MixerInteractive.GetButtonDown("mirrorOffset"))
            {
                mirror.RandomOffset();
            }

            if (MixerInteractive.GetButtonDown("mirrorRoll"))
            {
                mirror.RandomRoll();
            }

            if (MixerInteractive.GetButtonDown("mirrorSymmetric"))
            {
                mirror.SwitchSymmetric();
            }

            if (MixerInteractive.GetButtonDown("scaleX"))
            {
                scaleX = Random.Range(0.1f, 1f);
                BroadcastMessage("ChangeScaleX");
            }

            if (MixerInteractive.GetButtonDown("scaleY"))
            {
                scaleY = Random.Range(0.1f, 1f);
                BroadcastMessage("ChangeScaleY");
            }

            if (MixerInteractive.GetButtonDown("scaleZ"))
            {
                scaleZ = Random.Range(0.1f, 1f);
                BroadcastMessage("ChangeScaleZ");
            }

            if (MixerInteractive.GetButtonDown("cameraPosX"))
            {
                //mirror.RandomCamPos();
                mirror.ChangeCameraX(Random.Range(-9f, -14f));
            }

            if (MixerInteractive.GetButtonDown("cameraPosY"))
            {
                mirror.ChangeCameraY(Random.Range(7f, -3f));
            }

            if (MixerInteractive.GetButtonDown("cameraPosZ"))
            {
                mirror.ChangeCameraZ(Random.Range(-35f, -55f));
            }

            if (MixerInteractive.GetButtonDown("cameraRotX"))
            {
                mirror.ChangeRotX(Random.Range(11f, -40f));
            }

            if (MixerInteractive.GetButtonDown("cameraRotY"))
            {
                mirror.ChangeRotY(Random.Range(115f, 35f));
            }

            if (MixerInteractive.GetButtonDown("cameraRotZ"))
            {
                mirror.ChangeRotZ(Random.Range(61f, -28f));
            }

            if (MixerInteractive.GetButtonDown("cameraFOV"))
            {
                mirror.RandomFOV();
            }

            if (MixerInteractive.GetButtonDown("randomGlitchIntensity"))
            {
                glitchEffect.RandomGlitchIntensity();
            }

            if (MixerInteractive.GetButtonDown("randomGlitchFlip"))
            {
                glitchEffect.RandomGlitchFlip();
            }

            if (MixerInteractive.GetButtonDown("randomGlitchColor"))
            {
                glitchEffect.RandomGlitchColor();
            }

            if (MixerInteractive.GetButtonDown("resetGlitch"))
            {
                glitchEffect.resetGlitch();
            }

            if (MixerInteractive.GetButtonDown("DatamoshOn"))
            {
                datamosh.DatamoshOn();
            }

            if (MixerInteractive.GetButtonDown("DatamoshOff"))
            {
                datamosh.DatamoshOff();
            }

            if (MixerInteractive.GetButtonDown("RandomBlock"))
            {
                datamosh.RandomBlock();
            }

            if (MixerInteractive.GetButtonDown("RandomEntropy"))
            {
                datamosh.RandomEntropy();
            }

            if (MixerInteractive.GetButtonDown("RandomNoiseContrast"))
            {
                datamosh.RandomNoiseContrast();
            }

            if (MixerInteractive.GetButtonDown("RandomVelocityScale"))
            {
                datamosh.RandomVelocityScale();
            }

            if (MixerInteractive.GetButtonDown("RandomDiffusion"))
            {
                datamosh.RandomDiffusion();
            }

            if (MixerInteractive.GetButtonDown("avatarOn"))
            {
                int userID = (int)participant.UserID;
                grabbyTheAvatar.AvatarOn(userID);
            }

            if (MixerInteractive.GetButtonDown("avatarOff"))
            {
                grabbyTheAvatar.AvatarOff();
            }

            if (MixerInteractive.GetButtonDown("avatarCats"))
            {
                grabbyTheAvatar.AvatarOn(267345);
            }

            if (MixerInteractive.GetButtonDown("avatarLychi"))
            {
                grabbyTheAvatar.AvatarOn(604453);
            }

            if (MixerInteractive.GetButtonDown("avatarMatt"))
            {
                grabbyTheAvatar.AvatarOn(137);
            }

            if (MixerInteractive.GetButtonDown("avatarJames"))
            {
                grabbyTheAvatar.AvatarOn(294);
            }

            if (MixerInteractive.GetButtonDown("avatarRandomRotateOn"))
            {
                grabbyTheAvatar.AvatarRandomRotateOn();
            }

            if (MixerInteractive.GetButtonDown("avatarRandomRotateOff"))
            {
                grabbyTheAvatar.AvatarRandomRotateOff();
            }

            if (MixerInteractive.GetButtonDown("avatarRandomOffsetOn"))
            {
                grabbyTheAvatar.AvatarRandomOffsetOn();
            }

            if (MixerInteractive.GetButtonDown("avatarRandomOffsetOff"))
            {
                grabbyTheAvatar.AvatarRandomOffsetOff();
            }

            if (MixerInteractive.GetButtonDown("avatarColorMess"))
            {
                grabbyTheAvatar.AvatarColorMess();
            }

            if (MixerInteractive.GetButtonDown("avatarColorReset"))
            {
                grabbyTheAvatar.AvatarColorReset();
            }

            if (MixerInteractive.GetButtonDown("avatarRandomAlpha"))
            {
                grabbyTheAvatar.AvatarRandomAlpha();
            }

            #region Not using ATM

            if (MixerInteractive.GetButtonDown("Purple"))
            {
                print(e.Participant.UserName);

                mirror.ChangeState(4, 90f, 30f, true);
                scaleX = 1f; scaleY = 1f; scaleZ = 0.94f;
                BroadcastMessage("ChangeScale");
                mirror.ChangeCamera(-15.717f, -0.27f, -50.8f, 0f, 90f, 0f, 60f);

                ColorChange("Purple");
            }

            if (MixerInteractive.GetButton("Blue"))
            {
                print(e.Participant.UserName);

                mirror.ChangeState(3, 90f, 30f, true);
                scaleX = 0.1f; scaleY = 1f; scaleZ = 0.1f;
                BroadcastMessage("ChangeScale");
                mirror.ChangeCamera(-15.717f, -0.27f, -47.29f, 0f, 90f, 0f, 76.2f);

                ColorChange("Blue");
            }
            if (MixerInteractive.GetButton("Green"))
            {
                print(e.Participant.UserName);

                mirror.ChangeState(3, 90f, 30f, true);
                scaleX = 0.35f; scaleY = 1.99f; scaleZ = 0.03f;
                BroadcastMessage("ChangeScale");
                mirror.ChangeCamera(-15.717f, -0.7f, -47.29f, 0f, 90f, 0f, 90f);

                ColorChange("Green");
            }
            if (MixerInteractive.GetButton("White"))
            {
                print(e.Participant.UserName);

                mirror.ChangeState(3, 30f, 30f, false);
                scaleX = 1.2f; scaleY = 0.9f; scaleZ = 1.1f;
                BroadcastMessage("ChangeScale");
                mirror.ChangeCamera(-15.717f, -1.7f, -49.59f, 0f, 90f, 0f, 60f);

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

        #endregion
    }
}
