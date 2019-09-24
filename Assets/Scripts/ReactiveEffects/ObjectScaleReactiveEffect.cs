using Assets.Scripts.ReactiveEffects.Base;
using UnityEngine;

namespace Assets.Scripts.ReactiveEffects
{
    public class ObjectScaleReactiveEffect : VisualizationEffectBase
    {
        #region Private Member Variables

        private Vector3 _initialScale;

        #endregion

        #region Public Properties

        public Vector3 ScaleIntensity;

        #endregion

        #region Startup / Shutdown

        MixerInteractiveExamples.MixerControl MixerControl;

        public override void Start()
        {
            base.Start();

            _initialScale = transform.localScale;

            //MixerControl = GetComponent<MixerInteractiveExamples.MixerControl>();
            MixerControl = FindObjectOfType<MixerInteractiveExamples.MixerControl>();
        }

        #endregion

        #region Render

        public float mixplayX;
        public float mixplayY;
        public float mixplayZ;

        public void Update()
        {
            float audioData = GetAudioData();
            float xScaleAmount = audioData * ScaleIntensity.x + mixplayX;
            float yScaleAmount = audioData * ScaleIntensity.y + mixplayY;
            float zScaleAmount = audioData * ScaleIntensity.z + mixplayZ;
            gameObject.transform.localScale = _initialScale + new Vector3(xScaleAmount, yScaleAmount, zScaleAmount);
        }

        #endregion

        #region Meow

        //public void ChangeScale(float x, float y, float z)

        public void ChangeScale()
        {
            //mixplayX = MixerControl.testX;
            //mixplayY = MixerControl.testX;
            //mixplayZ = MixerControl.testZ;

            print(MixerControl.testX);
            print(MixerControl.testY);
            print(MixerControl.testZ);

            ScaleIntensity.x = MixerControl.testX;
            ScaleIntensity.y = MixerControl.testY;
            ScaleIntensity.z = MixerControl.testZ;
        }

        public void ChangeScaleInternal(float x, float y, float z)
        {
            mixplayX = x;
            mixplayY = y;
            mixplayZ = z;
        }

        #endregion
    }
}