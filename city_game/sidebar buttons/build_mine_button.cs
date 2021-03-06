﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace city_game
{
    class build_mine_button:side_menu_button
    {        

        public build_mine_button(int x, int y, city player_city_)
        {

            player_city = player_city_;
            x_pos = x;
            y_pos = y;

        }

        public override void Update(float mouse_x, float mouse_y)
        {

            if (mouse_over(mouse_x, mouse_y))
            {

                if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                {

                    tile.selection = false; //deselect tile
                    grid.get_selected_tile().set_state(tile.states.copper_mine);
                    player_city.get_copper().increment(copper.get_yield());

                }
            }

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sidebar_menu_button, new Vector2(x_pos, y_pos), Color.White);
            spriteBatch.DrawString(font, "Build mine here", new Vector2(x_pos + 10, y_pos), Color.Black);
            if (is_mouse_over)
            {

                spriteBatch.Draw(highlighter, new Vector2(x_pos, y_pos), Color.White);

            }
        }

    }
}
