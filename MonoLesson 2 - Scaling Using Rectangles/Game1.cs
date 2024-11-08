using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoLesson_2___Scaling_Using_Rectangles
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D circleTexture, rectangleTexture, spaceTexture;

        //add textfont
        SpriteFont spriteFont;
        
    

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;

            _graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            circleTexture = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            spaceTexture = Content.Load<Texture2D>("Space");
            spriteFont = Content.Load<SpriteFont>("textSus");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();
            //backpack
          

            _spriteBatch.Draw(spaceTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(280, 180, 100, 250), Color.DarkRed);
            //the legs
            _spriteBatch.Draw(circleTexture, new Rectangle(350, 260, 100, 300), Color.Red);
            _spriteBatch.Draw(circleTexture, new Rectangle(500, 260, 100, 300), Color.Red);

            //Amongus crewmate drawing
            _spriteBatch.Draw(circleTexture, new Rectangle(350, 100, 250, 400), Color.Red);
            //the facehood
            _spriteBatch.Draw(circleTexture, new Rectangle(350, 200, 300, 100), Color.Cyan);
            
        //text

            _spriteBatch.DrawString(spriteFont, "Sussy Baka was not the imposter.", new Vector2(100, 100), Color.White);


            

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
