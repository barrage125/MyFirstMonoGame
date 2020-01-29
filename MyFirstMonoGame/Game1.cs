using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Diagnostics;

namespace MyFirstMonoGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Texture2D image;
        private double playerPosX;
        private double playerPosY;
        private double playerTargetX;
        private double playerTargetY;
        private bool rightPress;
        private int window;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            playerPosX = 384;
            playerPosY = 224;
            playerTargetX = playerPosX;
            playerTargetY = playerPosY;
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            image = Content.Load<Texture2D>("Player");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            Keyboard.GetState();
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.IsPressed(Keys.Escape))
            {
                //Console.ReadLine();
                Exit();
            }
            // TODO: Add your update logic here
            //if (Keyboard.GetState().IsKeyDown(Keys.W)) {
            //    playerPosY -= 2;
            //}
            //if (Keyboard.GetState().IsKeyDown(Keys.A)) {
            //    playerPosX -= 2;
            //}
            //if (Keyboard.GetState().IsKeyDown(Keys.S)) {
            //    playerPosY += 2;
            //}
            //if (Keyboard.GetState().IsKeyDown(Keys.D)) {
            //    playerPosX += 2;
            //}

            
            if (Keyboard.IsPressed(Keys.W))
            {
                playerTargetY -= 5;
            }
            if (Keyboard.IsPressed(Keys.A))
            {
                playerTargetX -= 5;
            }
            if (Keyboard.IsPressed(Keys.S))
            {
                playerTargetY += 5;
            }
            if (Keyboard.IsPressed(Keys.D))
            {
                //playerTargetX += 5;
                //rightPress = true;
                //window = 500;
            }
            //Keyboard.GetState();
            //Debug.WriteLine("Help!");
            if (Keyboard.HasBeenPressed(Keys.D))
            {
                Debug.WriteLine("Help!");
                playerTargetX += 20;
                //rightPress = false;
                //window = 0;
            }

            playerPosX += ((playerTargetX - playerPosX) * 0.1);
            playerPosY += ((playerTargetY - playerPosY) * 0.1);

            //if (window > 0)
            //{
            //    window--;
            //}
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(image, new Rectangle((int)playerPosX, (int)playerPosY, 32, 32), Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
