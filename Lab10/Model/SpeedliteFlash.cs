using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.Model
{
    public class SpeedliteFlash
    {
        private string model;

        public SpeedliteFlash(string model)
        {
            this.model = model;
        }

        public string GetModel()
        {
            return model;
        }

        public void SetModel(string model)
        {
            this.model = model;
        }
    }
}
