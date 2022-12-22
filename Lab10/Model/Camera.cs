using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.Model
{
    public class Camera
    {
        private string model;
        private Frame frame;
        private Type type;
        public enum Frame
        {
            FullFrame,
            Crop
        }

        public enum Type
        {
            Mirrorless,
            Mirror
        }

        public Camera() { }

        public Camera(string model)
        {
            this.model = model;
        }
        public Camera(string model, Type type, Frame frame)
        {
            this.model = model;
            this.frame = frame;
            this.type = type;
        }

        public string GetModel()
        {
            return model;
        }

        public void SetModel(string model)
        {
            this.model = model;
        }

        public Type GetType()
        {
            return type;
        }

        public void SetType(Type type)
        {
            this.type = type;
        }

        public Frame GetFrame()
        {
            return frame;
        }

        public void SetFrame(Frame frame)
        {
            this.frame = frame;
        }
    }
}
