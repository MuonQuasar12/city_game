﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace city_game
{
    class side_menu_brownfield : side_menu_base
    {
        
        public side_menu_brownfield(ref grid player_grid)
        {
            buttons = new List<side_menu_button>();

            int displace_button = 0;

            if (player_grid.get_num_copper_mines() > 0 && !player_grid.Mint_built())
            {
                for (int i = -1; i < 2; i++)
                {
                    for (int j = -1; j < 2; j++)
                    {
                        if (player_grid.get_tile(tile.selected_sq[0] + i, tile.selected_sq[1] + j).get_state() == tile.states.town_hall)
                        {
                            buttons.Add(new build_mint_button(sidebar.get_start() + 10, 100));
                            displace_button = 40;
                        }
                    }
                }

            }
            buttons.Add(new build_button(sidebar.get_start() + 10, 100 + displace_button));
            buttons.Add(new make_farm_button(sidebar.get_start() + 10, 140 + displace_button));
            buttons.Add(new cancel_button(sidebar.get_start() + 10, 180 + displace_button));

        }

        public override void Update(float mouse_x, float mouse_y)
        {
            for (int i = 0; i < buttons.Count; i++)
            {

                buttons[i].Update(mouse_x, mouse_y);

            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < buttons.Count; i++)
            {

                buttons[i].Draw(spriteBatch);

            }
        }

    }

}

