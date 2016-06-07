using System;
using NoculusDriftInternals;
using TUIO;

namespace NoculusDrift
{
    public class Listener : TuioListener
    {
        private Input _input = new Input();

        private int? _cursorId = null;

        private float _lastX = 0.0f;

        private float _lastY = 0.0f;

        public void addTuioObject(TuioObject tobj)
        {
            throw new System.NotImplementedException();
        }

        public void updateTuioObject(TuioObject tobj)
        {
            throw new System.NotImplementedException();
        }

        public void removeTuioObject(TuioObject tobj)
        {
            throw new System.NotImplementedException();
        }

        public void addTuioCursor(TuioCursor tcur)
        {
            if (_cursorId == null)
            {
                _cursorId = tcur.CursorID;
                _lastX = tcur.X;
                _lastY = tcur.Y;
                Console.WriteLine("Cursor found");
            }
        }

        public void updateTuioCursor(TuioCursor tcur)
        {
            if (_cursorId != null && _cursorId.Value == tcur.CursorID)
            {
                float diffY = (_lastY - tcur.Y) * 1000;
                float diffX = (_lastX - tcur.X) * 1000;

                if (diffY < 100 && diffX < 100)
                {
                    _input.MoveMouse(-(int) diffY, (int) diffX);
                }

                _lastX = tcur.X;
                _lastY = tcur.Y;
            }
        }

        public void removeTuioCursor(TuioCursor tcur)
        {
            if (_cursorId != null && _cursorId.Value == tcur.CursorID)
            {
                _cursorId = null;
                Console.WriteLine("Cursor lost");
            }
        }

        public void addTuioBlob(TuioBlob tblb)
        {
            throw new System.NotImplementedException();
        }

        public void updateTuioBlob(TuioBlob tblb)
        {
            throw new System.NotImplementedException();
        }

        public void removeTuioBlob(TuioBlob tblb)
        {
            throw new System.NotImplementedException();
        }

        public void refresh(TuioTime ftime)
        {
        }
    }
}