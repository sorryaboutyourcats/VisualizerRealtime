//
// KinoMirror - Mirroring and kaleidoscope effect
//
// Copyright (C) 2015 Keijiro Takahashi
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using UnityEngine;

namespace Kino
{
    [ExecuteInEditMode]
    [RequireComponent(typeof(Camera))]
    [AddComponentMenu("Kino Image Effects/Mirror")]
    public class Mirror : MonoBehaviour
    {
        #region Public Properties

        [SerializeField]
        int _repeat;

        [SerializeField]
        float _offset;

        [SerializeField]
        float _roll;

        [SerializeField]
        bool _symmetry;

        #endregion

        #region Private Properties

        [SerializeField] Shader _shader;
        Material _material;

        Camera theCamera;

        #endregion

        #region MonoBehaviour Functions

        void Start()
        {
            theCamera = GetComponent<Camera>();
        }

        void OnRenderImage(RenderTexture source, RenderTexture destination)
        {
            if (_material == null)
            {
                _material = new Material(_shader);
                _material.hideFlags = HideFlags.DontSave;
            }

            var div = Mathf.PI * 2 / Mathf.Max(1, _repeat);

            _material.SetFloat("_Divisor", div);
            _material.SetFloat("_Offset", _offset * Mathf.Deg2Rad);
            _material.SetFloat("_Roll", _roll * Mathf.Deg2Rad);

            if (_symmetry)
                _material.EnableKeyword("SYMMETRY_ON");
            else
                _material.DisableKeyword("SYMMETRY_ON");

            Graphics.Blit(source, destination, _material);
        }

        #endregion

        #region Meow 

        public void RandomRepeat()
        {
            _repeat = Random.Range(2, 10);
        }
        public void RandomOffset()
        {
            _offset = Random.Range(0, 90);
        }
        public void RandomRoll()
        {
            _roll = Random.Range(-45, 45);
        }
        public void SwitchSymmetric()
        {
            _symmetry = !_symmetry;
        }
        public void RandomCamPos()
        {
            transform.position = new Vector3(Random.Range(-15.717f, -9.9f), Random.Range(-1.2f, 1f), Random.Range(-47.5f, -48.5f));
        }
        public void RandomCamRot()
        {
            transform.eulerAngles = new Vector3(Random.Range(0f, 14.5f), Random.Range(65f, 90f), Random.Range(-25f, 45f));
        }
        public void RandomFOV()
        {
            theCamera.fieldOfView = Random.Range(25f, 90f);
        }

        public void ChangeState(int repeat, float offset, float roll, bool symmetry)
        {
            _repeat = repeat;
            _offset = offset;
            _roll = roll;
            _symmetry = symmetry;
        }

        public void ChangeCamera(float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fov)
        {
            theCamera.fieldOfView = fov;
            transform.position = new Vector3(posX, posY, posZ);
            transform.eulerAngles = new Vector3(rotX, rotY, rotZ);
        }
        public void ChangeCameraX(float posX)
        {
            Vector3 temp = transform.position;
            temp.x = posX;
            transform.position = temp;
        }
        public void ChangeCameraY(float posY)
        {
            Vector3 temp = transform.position;
            temp.y = posY;
            transform.position = temp;
        }
        public void ChangeCameraZ(float posZ)
        {
            Vector3 temp = transform.position;
            temp.z = posZ;
            transform.position = temp;
        }
        public void ChangeRotX(float rotX)
        {
            Vector3 temp = transform.eulerAngles;
            temp.x = rotX;
            transform.eulerAngles = temp;
        }
        public void ChangeRotY(float rotY)
        {
            Vector3 temp = transform.eulerAngles;
            temp.y = rotY;
            transform.eulerAngles = temp;
        }
        public void ChangeRotZ(float rotZ)
        {
            Vector3 temp = transform.eulerAngles;
            temp.z = rotZ;
            transform.eulerAngles = temp;
        }
        #endregion
    }
}
