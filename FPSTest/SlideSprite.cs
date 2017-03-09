using System;
using System.Drawing;
using System.Windows;

namespace FPSTest
{
    class SlideSprite : Sprite
    {
        private Image image;
        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

        public SlideSprite(Image image, float x, float y)
        {
            this.image = image;
            Y = y;
            X = x;
        }

        private float targetX = 100;
        public float TargetX
        {
            get { return targetX; }
            set { targetX = value; }
        }

        private float targetY = 100;
        public float TargetY
        {
            get { return targetY; }
            set { targetY = value; }
        }

        private float velocity;
        public float Velocity
        {
            get { return velocity; }
            set { velocity = value; }
        }

        private bool isMoving = false;
        public bool IsMoving
        {
            get { return isMoving; }
            set { isMoving = value; }
        }

        private float distance;
        public float Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        private float directionX;
        public float DirectionX
        {
            get { return directionX; }
            set { directionX = value; }
        }

        private float directionY;
        public float DirectionY
        {
            get { return directionY; }
            set { directionY = value; }
        }

        public void updateMove()
        {
            distance = (float)Math.Sqrt(Math.Pow(targetX - X, 2) + Math.Pow(targetY - Y, 2));
            directionX = (targetX - X) / distance;
            directionY = (targetY - Y) / distance;
            isMoving = true;
        }

        public override void Act()
        {
            if (isMoving == true)
            {
                X += directionX * velocity;
                Y += directionY * velocity;
                if (X == targetX && Y == targetY)
                {
                    X = targetX;
                    Y = targetY;
                    isMoving = false;
                }
            }
        }

        public override void Paint(Graphics g)
        {
            g.DrawImage(image, this.X, this.Y);
        }
    }
}
