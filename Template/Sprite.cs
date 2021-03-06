using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class Sprite
    {
        protected Texture2D _texture;

        public Vector2 position;
        public Vector2 velocity;
        public float speed;
        


        public Rectangle rectangle
        {
            get
            {
                return new Rectangle((int)position.X, (int)position.Y, _texture.Width, _texture.Height);
            }
        }

            public Sprite(Texture2D texture)
        {
            _texture = texture;
        }

        public virtual void Update(GameTime gameTime, List<Sprite> sprites)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, position, Color.White);
        }

        #region Collision
        protected bool IsTouchingLeft(Sprite sprite)
        {
            return this.rectangle.Right + this.velocity.X > sprite.rectangle.Left &&
                   this.rectangle.Left < sprite.rectangle.Left &&
                   this.rectangle.Bottom > sprite.rectangle.Top &&
                   this.rectangle.Top < sprite.rectangle.Bottom;
        }

        protected bool IsTouchingRight(Sprite sprite)
        {
            return this.rectangle.Left + this.velocity.X < sprite.rectangle.Right &&
                   this.rectangle.Right < sprite.rectangle.Right &&
                   this.rectangle.Bottom > sprite.rectangle.Top &&
                   this.rectangle.Top < sprite.rectangle.Bottom;
        }

        protected bool IsTouchingTop(Sprite sprite)
        {
            return this.rectangle.Bottom + this.velocity.X < sprite.rectangle.Top &&
                   this.rectangle.Top < sprite.rectangle.Top &&
                   this.rectangle.Right > sprite.rectangle.Left &&
                   this.rectangle.Left < sprite.rectangle.Right;
        }

        protected bool IsTouchingBottom(Sprite sprite)
        {
            return this.rectangle.Top + this.velocity.X < sprite.rectangle.Bottom &&
                   this.rectangle.Bottom < sprite.rectangle.Bottom &&
                   this.rectangle.Right > sprite.rectangle.Left &&
                   this.rectangle.Left < sprite.rectangle.Right;
        }
        #endregion


    }
}

